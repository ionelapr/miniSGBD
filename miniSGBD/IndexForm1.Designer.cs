﻿namespace miniSGBD
{
    partial class IndexForm1
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
            this.attributeNames = new System.Windows.Forms.CheckedListBox();
            this.addIndex_Btn = new System.Windows.Forms.Button();
            this.cancelIndex_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IndexType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // attributeNames
            // 
            this.attributeNames.FormattingEnabled = true;
            this.attributeNames.Location = new System.Drawing.Point(145, 108);
            this.attributeNames.Name = "attributeNames";
            this.attributeNames.Size = new System.Drawing.Size(147, 34);
            this.attributeNames.TabIndex = 0;
            this.attributeNames.SelectedIndexChanged += new System.EventHandler(this.attributeNames_SelectedIndexChanged);
            // 
            // addIndex_Btn
            // 
            this.addIndex_Btn.Location = new System.Drawing.Point(203, 187);
            this.addIndex_Btn.Name = "addIndex_Btn";
            this.addIndex_Btn.Size = new System.Drawing.Size(75, 23);
            this.addIndex_Btn.TabIndex = 1;
            this.addIndex_Btn.Text = "Add";
            this.addIndex_Btn.UseVisualStyleBackColor = true;
            this.addIndex_Btn.Click += new System.EventHandler(this.addIndex_Btn_Click_1);
            // 
            // cancelIndex_btn
            // 
            this.cancelIndex_btn.Location = new System.Drawing.Point(351, 187);
            this.cancelIndex_btn.Name = "cancelIndex_btn";
            this.cancelIndex_btn.Size = new System.Drawing.Size(75, 23);
            this.cancelIndex_btn.TabIndex = 2;
            this.cancelIndex_btn.Text = "Cancel";
            this.cancelIndex_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Index name";
            // 
            // IndexType
            // 
            this.IndexType.FormattingEnabled = true;
            this.IndexType.Location = new System.Drawing.Point(313, 114);
            this.IndexType.Name = "IndexType";
            this.IndexType.Size = new System.Drawing.Size(154, 21);
            this.IndexType.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Index Type";
            // 
            // IndexForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 292);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IndexType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelIndex_btn);
            this.Controls.Add(this.addIndex_Btn);
            this.Controls.Add(this.attributeNames);
            this.Name = "IndexForm1";
            this.Text = "IndexForm1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox attributeNames;
        private System.Windows.Forms.Button addIndex_Btn;
        private System.Windows.Forms.Button cancelIndex_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox IndexType;
        private System.Windows.Forms.Label label2;
    }
}