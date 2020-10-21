namespace miniSGBD
{
    partial class MainForm
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
            this.addDB_btn = new System.Windows.Forms.Button();
            this.addTable_btn = new System.Windows.Forms.Button();
            this.databasesList = new System.Windows.Forms.ListView();
            this.tablesList = new System.Windows.Forms.ListView();
            this.table_structure_list = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addDB_btn
            // 
            this.addDB_btn.Location = new System.Drawing.Point(28, 360);
            this.addDB_btn.Name = "addDB_btn";
            this.addDB_btn.Size = new System.Drawing.Size(128, 23);
            this.addDB_btn.TabIndex = 0;
            this.addDB_btn.Text = "Add Database";
            this.addDB_btn.UseVisualStyleBackColor = true;
            // 
            // addTable_btn
            // 
            this.addTable_btn.Location = new System.Drawing.Point(295, 360);
            this.addTable_btn.Name = "addTable_btn";
            this.addTable_btn.Size = new System.Drawing.Size(75, 23);
            this.addTable_btn.TabIndex = 1;
            this.addTable_btn.Text = "Add Table";
            this.addTable_btn.UseVisualStyleBackColor = true;
            // 
            // databasesList
            // 
            this.databasesList.Location = new System.Drawing.Point(13, 97);
            this.databasesList.Name = "databasesList";
            this.databasesList.Size = new System.Drawing.Size(170, 243);
            this.databasesList.TabIndex = 2;
            this.databasesList.UseCompatibleStateImageBehavior = false;
            // 
            // tablesList
            // 
            this.tablesList.Location = new System.Drawing.Point(224, 97);
            this.tablesList.Name = "tablesList";
            this.tablesList.Size = new System.Drawing.Size(223, 243);
            this.tablesList.TabIndex = 3;
            this.tablesList.UseCompatibleStateImageBehavior = false;
            // 
            // table_structure_list
            // 
            this.table_structure_list.Location = new System.Drawing.Point(473, 97);
            this.table_structure_list.Name = "table_structure_list";
            this.table_structure_list.Size = new System.Drawing.Size(474, 149);
            this.table_structure_list.TabIndex = 4;
            this.table_structure_list.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Databases";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tables";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(674, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Index";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 480);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.table_structure_list);
            this.Controls.Add(this.tablesList);
            this.Controls.Add(this.databasesList);
            this.Controls.Add(this.addTable_btn);
            this.Controls.Add(this.addDB_btn);
            this.Name = "MainForm";
            this.Text = "MainForm";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addDB_btn;
        private System.Windows.Forms.Button addTable_btn;
        private System.Windows.Forms.ListView databasesList;
        private System.Windows.Forms.ListView tablesList;
        private System.Windows.Forms.ListView table_structure_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}