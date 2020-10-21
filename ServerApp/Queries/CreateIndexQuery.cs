﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ServerApp.Queries
{
    class CreateIndexQuery:AbstractQuery
    {
        private string DBName;
        private string TableName;
        private bool indexType;
        private string indexName;
        private string columnsString;
        private string[] columns;

        public CreateIndexQuery(string command, bool isUnique, string _queryAttributesDB, string _queryAttributesTB, string tableColumns, string idxName) : base(command)
        {
            indexType = isUnique;
            DBName = _queryAttributesDB;
            TableName = _queryAttributesTB;
            indexName = idxName;
            columnsString = tableColumns;
        }

        public override void ParseAttributes()
        {
            columns = columnsString.Split('|');
        }

        public override string ValidateQuery()
        {
            return Commands.MapCommandToSuccessResponse(base.QueryCommand);
        }

        public override void PerformXMLActions()
        {
            var xmlDocument = XDocument.Load(Application.StartupPath + "\\SGBDCatalog.xml");
            XElement[] databasesNodes = xmlDocument.Element("Databases").Descendants("Database").ToArray();
            XElement givenDB = Array.Find(databasesNodes, elem => elem.Attribute("databaseName").Value.Equals(DBName));
            XElement[] databasesTables = givenDB.Descendants("Table").ToArray();
            XElement givenTable = Array.Find(databasesTables, elem => elem.Attribute("tableName").Value.Equals(TableName));
            XElement indexFilesNode = givenTable.Descendants("IndexFiles").ToArray()[0];
            XElement indexNode = new XElement("IndexFile");

            foreach (var col in columns)
            {
                indexNode.Add(new XElement("IndexAttribute", col));
            }

            indexNode.SetAttributeValue("indexType", "BTree");
            indexNode.SetAttributeValue("isUnique", indexType);
            indexNode.SetAttributeValue("indexName", indexName);
            indexFilesNode.Add(indexNode);
            xmlDocument.Save(Application.StartupPath + "\\SGBDCatalog.xml");
        }
    }
}
