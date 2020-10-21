﻿using ClientApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniSGBD
{
    public partial class MainForm : Form
    {
        private readonly Client tcpClient;
        private TreeNode rootNode = new TreeNode("Databases");
        private static string DELETE_DATABASE = "Delete Database";
        private static string CREATE_TABLE = "Create Table";
        private static string DELETE_TABLE = "Delete Table";
        private static string CREATE_INDEX = "Create Index";

        private static string selectedDatabase = "";
        private static string selectedTable = "";

        MenuItem deleteTableMenuItem = new MenuItem(DELETE_TABLE);
        MenuItem createIndexMenuItem = new MenuItem(CREATE_INDEX);
        ContextMenu cm3 = new ContextMenu();

        MenuItem deleteDBMenuItem = new MenuItem(DELETE_DATABASE);
        MenuItem createTBMenuItem = new MenuItem(CREATE_TABLE);
        ContextMenu cm2 = new ContextMenu();


        public MainForm(Client client)
        {
            tcpClient = client;
            tcpClient.Connect();
            InitializeComponent();

            cm3.MenuItems.Add(deleteTableMenuItem);
            cm3.MenuItems.Add(createIndexMenuItem);
            cm2.MenuItems.Add(deleteDBMenuItem);
            cm2.MenuItems.Add(createTBMenuItem);
            deleteDBMenuItem.Click += new EventHandler(contextMenu_deleteDB);
            deleteTableMenuItem.Click += new EventHandler(contextMenu_deleteTB);
            createIndexMenuItem.Click += new EventHandler(contextMenu_createIN);
            createTBMenuItem.Click += new EventHandler(addTB_Click);
            addTable_btn.Visible = false;

            populateDatabases();
        }
        //populare baza de date
        private void populateDatabases()
        {
            databasesList.Clear();
            tcpClient.Write(Commands.GET_ALL_DATABASES + ';');
            var serverResponse = tcpClient.ReadFromServer();

            var commandSplit = serverResponse.Split(';');

            try
            {
                var databasesNames = commandSplit[1].Split('|');
                foreach (var dbName in databasesNames)
                    databasesList.Items.Add(dbName);
            }
            catch (Exception) { }
        }

        //upulare tabele
        private void populateTables()
        {
            tablesList.Clear();
            tcpClient.Write(Commands.GET_ALL_TABLES + ';' + selectedDatabase);
            var serverResponse = tcpClient.ReadFromServer();
            var commandSplit = serverResponse.Split(';');

            try
            {
                var tableNames = commandSplit[1].Split('|');
                foreach (var tName in tableNames)
                    tablesList.Items.Add(tName);
            }
            catch (Exception) { }
        }
        //functionalitate pentru a putea selecta cu mouse-ul baza de date si tabelele
        private void databasesList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && databasesList.FocusedItem.Bounds.Contains(e.Location))
            {
                cm2.Show(databasesList, e.Location);
            }
            else if (e.Button == MouseButtons.Left && databasesList.FocusedItem.Bounds.Contains(e.Location))
            {
                table_structure_list.Clear();
                addTable_btn.Visible = true;
                selectedDatabase = databasesList.FocusedItem.Text;
                populateTables();
            }
        }

        private void tablesList_MouseClick(object sender, MouseEventArgs e)
        {
            selectedTable = tablesList.FocusedItem.Text;
            if (e.Button == MouseButtons.Right && tablesList.FocusedItem.Bounds.Contains(e.Location))
            {
                cm3.Show(tablesList, e.Location);
            }
            else if (e.Button == MouseButtons.Left && tablesList.FocusedItem.Bounds.Contains(e.Location))
            {
                table_structure_list.Clear();

                // Get info about the structure of the clicked table
                selectedTable = tablesList.FocusedItem.Text;

                tcpClient.Write(Commands.GET_TABLE_INFORMATION + ";" + selectedDatabase + ";" + selectedTable);
                var serverResponse = tcpClient.ReadFromServer().Split(';');
                var retreivedInformation = serverResponse[1].Split('|');
                foreach (string tableInfo in retreivedInformation)
                {
                    table_structure_list.Items.Add(tableInfo);
                }
            }
        }
        // adauga baza de date
        private void addDB_buttonClick(object sender, EventArgs e)
        {
            AddDatabaseForm createDBForm = new AddDatabaseForm(tcpClient);
            createDBForm.ShowDialog(this);
            populateDatabases();
        }
        //stergerea unei baze de date
        private void contextMenu_deleteDB(object sender, EventArgs e)
        {
            var selectedDBName = databasesList.FocusedItem.Text;
            tcpClient.Write(Commands.DROP_DATABASE + ";" + selectedDBName);
            var serverResponse = tcpClient.ReadFromServer();
            MessageBox.Show(serverResponse, "Query Execution Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            populateDatabases();
        }
        // stergerea unei tabele din baza de date
        private void contextMenu_deleteTB(object sender, EventArgs e)
        {
            var selectedTBName = tablesList.FocusedItem.Text;
            tcpClient.Write(Commands.DROP_TABLE + ';' + selectedDatabase + ";" + selectedTBName);
            var serverResponse = tcpClient.ReadFromServer();
            MessageBox.Show(serverResponse, "Execution result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            populateTables();
        }
        // creare index
        private void contextMenu_createIN(object sender, EventArgs e)
        {
            IndexForm1 createDBForm = new IndexForm1(tcpClient, selectedDatabase, selectedTable);
            createDBForm.ShowDialog(this);
        }
        //adauga tabela noua
        private void addTB_Click(object sender, EventArgs e)
        {
            TestFormTables addTableForm = new TestFormTables(selectedDatabase, tcpClient);
            addTableForm.ShowDialog(this);
            populateTables();
        }

    }
}
