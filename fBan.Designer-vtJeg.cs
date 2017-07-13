namespace Secury
{
    partial class fBan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bIPListSave = new System.Windows.Forms.Button();
            this.bIPListRefresh = new System.Windows.Forms.Button();
            this.bBanListApply = new System.Windows.Forms.Button();
            this.bBanListOk = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bRead = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.bIPListSave);
            this.groupBox1.Controls.Add(this.bIPListRefresh);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 244);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP in Base";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(173, 186);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 6;
            // 
            // bIPListSave
            // 
            this.bIPListSave.Location = new System.Drawing.Point(104, 19);
            this.bIPListSave.Name = "bIPListSave";
            this.bIPListSave.Size = new System.Drawing.Size(75, 23);
            this.bIPListSave.TabIndex = 5;
            this.bIPListSave.Text = "Save";
            this.bIPListSave.UseVisualStyleBackColor = true;
            this.bIPListSave.Click += new System.EventHandler(this.bIPListSave_Click);
            // 
            // bIPListRefresh
            // 
            this.bIPListRefresh.Location = new System.Drawing.Point(6, 19);
            this.bIPListRefresh.Name = "bIPListRefresh";
            this.bIPListRefresh.Size = new System.Drawing.Size(75, 23);
            this.bIPListRefresh.TabIndex = 4;
            this.bIPListRefresh.Text = "Refresh";
            this.bIPListRefresh.UseVisualStyleBackColor = true;
            this.bIPListRefresh.Click += new System.EventHandler(this.bIPListRefresh_Click);
            // 
            // bBanListApply
            // 
            this.bBanListApply.Location = new System.Drawing.Point(400, 31);
            this.bBanListApply.Name = "bBanListApply";
            this.bBanListApply.Size = new System.Drawing.Size(75, 23);
            this.bBanListApply.TabIndex = 6;
            this.bBanListApply.Text = "Apply";
            this.bBanListApply.UseVisualStyleBackColor = true;
            this.bBanListApply.Click += new System.EventHandler(this.bBanListApply_Click);
            // 
            // bBanListOk
            // 
            this.bBanListOk.Location = new System.Drawing.Point(400, 60);
            this.bBanListOk.Name = "bBanListOk";
            this.bBanListOk.Size = new System.Drawing.Size(75, 23);
            this.bBanListOk.TabIndex = 6;
            this.bBanListOk.Text = "Ok";
            this.bBanListOk.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(400, 89);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Cancel";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 262);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(463, 117);
            this.textBox1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(206, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 244);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IP in FireWall";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(6, 48);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(173, 186);
            this.listBox2.Sorted = true;
            this.listBox2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bRead
            // 
            this.bRead.Location = new System.Drawing.Point(400, 233);
            this.bRead.Name = "bRead";
            this.bRead.Size = new System.Drawing.Size(75, 23);
            this.bRead.TabIndex = 6;
            this.bRead.Text = "Read";
            this.bRead.UseVisualStyleBackColor = true;
            this.bRead.Click += new System.EventHandler(this.bRead_Click);
            // 
            // fBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 391);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bRead);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.bBanListOk);
            this.Controls.Add(this.bBanListApply);
            this.Controls.Add(this.groupBox1);
            this.Name = "fBan";
            this.Text = "fBan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bIPListSave;
        private System.Windows.Forms.Button bIPListRefresh;
        private System.Windows.Forms.Button bBanListApply;
        private System.Windows.Forms.Button bBanListOk;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bRead;
    }
}