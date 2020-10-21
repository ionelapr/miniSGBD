using System;

namespace miniSGBD
{
    partial class AddDatabaseForm
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
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.create_db_btn = new System.Windows.Forms.Button();
            this.cancel_db_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_db_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // create_db_btn
            // 
            this.create_db_btn.Location = new System.Drawing.Point(72, 140);
            this.create_db_btn.Name = "create_db_btn";
            this.create_db_btn.Size = new System.Drawing.Size(75, 23);
            this.create_db_btn.TabIndex = 0;
            this.create_db_btn.Text = "Add";
            this.create_db_btn.UseVisualStyleBackColor = true;
            this.create_db_btn.Click += new System.EventHandler(this.create_db_btn_Click);
            // 
            // cancel_db_btn
            // 
            this.cancel_db_btn.Location = new System.Drawing.Point(187, 140);
            this.cancel_db_btn.Name = "cancel_db_btn";
            this.cancel_db_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_db_btn.TabIndex = 1;
            this.cancel_db_btn.Text = "Cancel";
            this.cancel_db_btn.UseVisualStyleBackColor = true;
            this.cancel_db_btn.Click += new System.EventHandler(this.cancel_db_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Create database";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // text_db_name
            // 
            this.text_db_name.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.text_db_name.Location = new System.Drawing.Point(72, 102);
            this.text_db_name.Name = "text_db_name";
            this.text_db_name.Size = new System.Drawing.Size(190, 20);
            this.text_db_name.TabIndex = 3;
            // 
            // AddDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 290);
            this.Controls.Add(this.text_db_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_db_btn);
            this.Controls.Add(this.create_db_btn);
            this.Name = "AddDatabaseForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AddDatabaseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void AddDatabaseForm_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private System.Windows.Forms.Button create_db_btn;
        private System.Windows.Forms.Button cancel_db_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_db_name;
    }
}