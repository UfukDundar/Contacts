﻿namespace Contacts
{
    partial class Form1
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
            this.txtCalls = new System.Windows.Forms.TextBox();
            this.lstFound = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCalls
            // 
            this.txtCalls.Location = new System.Drawing.Point(55, 47);
            this.txtCalls.Name = "txtCalls";
            this.txtCalls.Size = new System.Drawing.Size(245, 22);
            this.txtCalls.TabIndex = 0;
            this.txtCalls.TextChanged += new System.EventHandler(this.txtCalls_TextChanged);
            // 
            // lstFound
            // 
            this.lstFound.FormattingEnabled = true;
            this.lstFound.ItemHeight = 16;
            this.lstFound.Location = new System.Drawing.Point(55, 104);
            this.lstFound.Name = "lstFound";
            this.lstFound.Size = new System.Drawing.Size(245, 292);
            this.lstFound.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Calls";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstFound);
            this.Controls.Add(this.txtCalls);
            this.Name = "Form1";
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCalls;
        private System.Windows.Forms.ListBox lstFound;
        private System.Windows.Forms.Label label1;
    }
}

