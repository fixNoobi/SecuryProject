namespace Secury
{
    partial class fUnban
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.llSite = new System.Windows.Forms.LinkLabel();
            this.bUpdateIP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(113, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // llSite
            // 
            this.llSite.AutoSize = true;
            this.llSite.Location = new System.Drawing.Point(219, 18);
            this.llSite.Name = "llSite";
            this.llSite.Size = new System.Drawing.Size(102, 13);
            this.llSite.TabIndex = 4;
            this.llSite.TabStop = true;
            this.llSite.Text = "Open Site to UnBan";
            this.llSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSite_LinkClicked);
            // 
            // bUpdateIP
            // 
            this.bUpdateIP.Image = global::Secury.Properties.Resources.page_refresh;
            this.bUpdateIP.Location = new System.Drawing.Point(6, 13);
            this.bUpdateIP.Name = "bUpdateIP";
            this.bUpdateIP.Size = new System.Drawing.Size(85, 24);
            this.bUpdateIP.TabIndex = 5;
            this.bUpdateIP.Text = "Update IP";
            this.bUpdateIP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bUpdateIP.UseVisualStyleBackColor = true;
            // 
            // fUnban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 77);
            this.Controls.Add(this.bUpdateIP);
            this.Controls.Add(this.llSite);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fUnban";
            this.Text = " UnBan ip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel llSite;
        private System.Windows.Forms.Button bUpdateIP;
    }
}