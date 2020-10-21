using System;

namespace miniSGBD
{
    partial class TestFormTables
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.text_table_name = new System.Windows.Forms.TextBox();
            this.label_table_name = new System.Windows.Forms.Label();
            this.panel_table_column = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_table_add_row = new System.Windows.Forms.Button();
            this.button_table_create = new System.Windows.Forms.Button();
            this.button_table_cancel = new System.Windows.Forms.Button();
            this.button_table_remove_row = new System.Windows.Forms.Button();
            this.button_add_reference = new System.Windows.Forms.Button();
            this.button_remove_reference = new System.Windows.Forms.Button();
            this.list_related_tables = new System.Windows.Forms.ListView();
            this.list_referenced_tables = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // text_table_name
            // 
            this.text_table_name.Location = new System.Drawing.Point(52, 69);
            this.text_table_name.Name = "text_table_name";
            this.text_table_name.Size = new System.Drawing.Size(177, 20);
            this.text_table_name.TabIndex = 0;
            // 
            // label_table_name
            // 
            this.label_table_name.AutoSize = true;
            this.label_table_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_table_name.Location = new System.Drawing.Point(48, 37);
            this.label_table_name.Name = "label_table_name";
            this.label_table_name.Size = new System.Drawing.Size(99, 20);
            this.label_table_name.TabIndex = 1;
            this.label_table_name.Text = "Nume tabela";
            this.label_table_name.Click += new System.EventHandler(this.label1_table_name_Click);
            // 
            // panel_table_column
            // 
            this.panel_table_column.ColumnCount = 6;
            this.panel_table_column.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_table_column.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_table_column.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.panel_table_column.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 227F));
            this.panel_table_column.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.panel_table_column.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.panel_table_column.Location = new System.Drawing.Point(52, 276);
            this.panel_table_column.Name = "panel_table_column";
            this.panel_table_column.RowCount = 2;
            this.panel_table_column.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_table_column.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_table_column.Size = new System.Drawing.Size(1040, 100);
            this.panel_table_column.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(798, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1011, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "label7";
            // 
            // button_table_add_row
            // 
            this.button_table_add_row.Location = new System.Drawing.Point(1113, 245);
            this.button_table_add_row.Name = "button_table_add_row";
            this.button_table_add_row.Size = new System.Drawing.Size(75, 23);
            this.button_table_add_row.TabIndex = 9;
            this.button_table_add_row.Text = "Add row";
            this.button_table_add_row.UseVisualStyleBackColor = true;
            // 
            // button_table_create
            // 
            this.button_table_create.Location = new System.Drawing.Point(52, 110);
            this.button_table_create.Name = "button_table_create";
            this.button_table_create.Size = new System.Drawing.Size(75, 23);
            this.button_table_create.TabIndex = 10;
            this.button_table_create.Text = "Add";
            this.button_table_create.UseVisualStyleBackColor = true;
            // 
            // button_table_cancel
            // 
            this.button_table_cancel.Location = new System.Drawing.Point(154, 110);
            this.button_table_cancel.Name = "button_table_cancel";
            this.button_table_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_table_cancel.TabIndex = 11;
            this.button_table_cancel.Text = "Cancel";
            this.button_table_cancel.UseVisualStyleBackColor = true;
            // 
            // button_table_remove_row
            // 
            this.button_table_remove_row.Location = new System.Drawing.Point(1113, 276);
            this.button_table_remove_row.Name = "button_table_remove_row";
            this.button_table_remove_row.Size = new System.Drawing.Size(75, 23);
            this.button_table_remove_row.TabIndex = 12;
            this.button_table_remove_row.Text = "Remove row";
            this.button_table_remove_row.UseVisualStyleBackColor = true;
            // 
            // button_add_reference
            // 
            this.button_add_reference.Location = new System.Drawing.Point(410, 69);
            this.button_add_reference.Name = "button_add_reference";
            this.button_add_reference.Size = new System.Drawing.Size(152, 23);
            this.button_add_reference.TabIndex = 13;
            this.button_add_reference.Text = "Add reference";
            this.button_add_reference.UseVisualStyleBackColor = true;
            this.button_add_reference.Click += new System.EventHandler(this.button_add_reference_Click);
            // 
            // button_remove_reference
            // 
            this.button_remove_reference.Location = new System.Drawing.Point(940, 69);
            this.button_remove_reference.Name = "button_remove_reference";
            this.button_remove_reference.Size = new System.Drawing.Size(152, 23);
            this.button_remove_reference.TabIndex = 14;
            this.button_remove_reference.Text = "Remove reference";
            this.button_remove_reference.UseVisualStyleBackColor = true;
            // 
            // list_related_tables
            // 
            this.list_related_tables.Location = new System.Drawing.Point(600, 69);
            this.list_related_tables.Name = "list_related_tables";
            this.list_related_tables.Size = new System.Drawing.Size(121, 122);
            this.list_related_tables.TabIndex = 15;
            this.list_related_tables.UseCompatibleStateImageBehavior = false;
            // 
            // list_referenced_tables
            // 
            this.list_referenced_tables.Location = new System.Drawing.Point(788, 69);
            this.list_referenced_tables.Name = "list_referenced_tables";
            this.list_referenced_tables.Size = new System.Drawing.Size(121, 122);
            this.list_referenced_tables.TabIndex = 16;
            this.list_referenced_tables.UseCompatibleStateImageBehavior = false;
            // 
            // TestFormTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 458);
            this.Controls.Add(this.list_referenced_tables);
            this.Controls.Add(this.list_related_tables);
            this.Controls.Add(this.button_remove_reference);
            this.Controls.Add(this.button_add_reference);
            this.Controls.Add(this.button_table_remove_row);
            this.Controls.Add(this.button_table_cancel);
            this.Controls.Add(this.button_table_create);
            this.Controls.Add(this.button_table_add_row);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_table_column);
            this.Controls.Add(this.label_table_name);
            this.Controls.Add(this.text_table_name);
            this.Name = "TestFormTables";
            this.Text = "TestFormTables";
            this.Load += new System.EventHandler(this.TestFormTables_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TestFormTables_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_table_name_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox text_table_name;
        private System.Windows.Forms.Label label_table_name;
        private System.Windows.Forms.TableLayoutPanel panel_table_column;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_table_add_row;
        private System.Windows.Forms.Button button_table_create;
        private System.Windows.Forms.Button button_table_cancel;
        private System.Windows.Forms.Button button_table_remove_row;
        private System.Windows.Forms.Button button_add_reference;
        private System.Windows.Forms.Button button_remove_reference;
        private System.Windows.Forms.ListView list_related_tables;
        private System.Windows.Forms.ListView list_referenced_tables;
    }
}