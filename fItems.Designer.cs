namespace Secury
{
    partial class fItems
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
            this.tbIPList = new System.Windows.Forms.TextBox();
            this.bCheckIPList = new System.Windows.Forms.Button();
            this.bAddIPToList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbIPList
            // 
            this.tbIPList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIPList.Location = new System.Drawing.Point(8, 8);
            this.tbIPList.Margin = new System.Windows.Forms.Padding(2);
            this.tbIPList.Multiline = true;
            this.tbIPList.Name = "tbIPList";
            this.tbIPList.Size = new System.Drawing.Size(227, 208);
            this.tbIPList.TabIndex = 0;
            // 
            // bCheckIPList
            // 
            this.bCheckIPList.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bCheckIPList.Location = new System.Drawing.Point(8, 220);
            this.bCheckIPList.Margin = new System.Windows.Forms.Padding(2);
            this.bCheckIPList.Name = "bCheckIPList";
            this.bCheckIPList.Size = new System.Drawing.Size(75, 23);
            this.bCheckIPList.TabIndex = 1;
            this.bCheckIPList.Text = "Check";
            this.bCheckIPList.UseVisualStyleBackColor = true;
            this.bCheckIPList.Click += new System.EventHandler(this.bCheckIPList_Click);
            // 
            // bAddIPToList
            // 
            this.bAddIPToList.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bAddIPToList.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bAddIPToList.Location = new System.Drawing.Point(160, 220);
            this.bAddIPToList.Margin = new System.Windows.Forms.Padding(2);
            this.bAddIPToList.Name = "bAddIPToList";
            this.bAddIPToList.Size = new System.Drawing.Size(75, 23);
            this.bAddIPToList.TabIndex = 1;
            this.bAddIPToList.Text = "Add";
            this.bAddIPToList.UseVisualStyleBackColor = true;
            this.bAddIPToList.Click += new System.EventHandler(this.bAddIPToList_Click);
            // 
            // fItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 254);
            this.Controls.Add(this.bAddIPToList);
            this.Controls.Add(this.bCheckIPList);
            this.Controls.Add(this.tbIPList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fItems";
            this.Text = "Add Items";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIPList;
        private System.Windows.Forms.Button bCheckIPList;
        private System.Windows.Forms.Button bAddIPToList;
    }
}