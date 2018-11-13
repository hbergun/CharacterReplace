namespace CharecterReplace
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ofdDosyaAc = new System.Windows.Forms.OpenFileDialog();
            this.btnFindPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOldValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddValue = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxNewValue = new System.Windows.Forms.ListBox();
            this.lbxOldValue = new System.Windows.Forms.ListBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFindPath
            // 
            this.btnFindPath.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnFindPath.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFindPath.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindPath.ForeColor = System.Drawing.Color.Red;
            this.btnFindPath.Location = new System.Drawing.Point(209, 38);
            this.btnFindPath.Name = "btnFindPath";
            this.btnFindPath.Size = new System.Drawing.Size(137, 26);
            this.btnFindPath.TabIndex = 1;
            this.btnFindPath.Text = "Text Dosyası Seç";
            this.btnFindPath.UseVisualStyleBackColor = false;
            this.btnFindPath.Click += new System.EventHandler(this.btnFindPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(109, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoşgeldin,Hemen Bul Ve Değiştir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bunu";
            // 
            // txtOldValue
            // 
            this.txtOldValue.Location = new System.Drawing.Point(77, 76);
            this.txtOldValue.Name = "txtOldValue";
            this.txtOldValue.Size = new System.Drawing.Size(80, 20);
            this.txtOldValue.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bunun ile ";
            // 
            // txtNewValue
            // 
            this.txtNewValue.Location = new System.Drawing.Point(241, 77);
            this.txtNewValue.Name = "txtNewValue";
            this.txtNewValue.Size = new System.Drawing.Size(82, 20);
            this.txtNewValue.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(329, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Değiştir.";
            // 
            // btnAddValue
            // 
            this.btnAddValue.Location = new System.Drawing.Point(397, 76);
            this.btnAddValue.Name = "btnAddValue";
            this.btnAddValue.Size = new System.Drawing.Size(79, 21);
            this.btnAddValue.TabIndex = 7;
            this.btnAddValue.Text = "Ekle";
            this.btnAddValue.UseVisualStyleBackColor = true;
            this.btnAddValue.Click += new System.EventHandler(this.btnAddValue_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightYellow;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(220, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "© 2018 Copyright";
            // 
            // lbxNewValue
            // 
            this.lbxNewValue.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lbxNewValue.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxNewValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbxNewValue.FormattingEnabled = true;
            this.lbxNewValue.ItemHeight = 21;
            this.lbxNewValue.Location = new System.Drawing.Point(77, 118);
            this.lbxNewValue.Name = "lbxNewValue";
            this.lbxNewValue.Size = new System.Drawing.Size(59, 109);
            this.lbxNewValue.TabIndex = 9;
            // 
            // lbxOldValue
            // 
            this.lbxOldValue.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lbxOldValue.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxOldValue.ForeColor = System.Drawing.Color.Red;
            this.lbxOldValue.FormattingEnabled = true;
            this.lbxOldValue.ItemHeight = 21;
            this.lbxOldValue.Location = new System.Drawing.Point(12, 118);
            this.lbxOldValue.Name = "lbxOldValue";
            this.lbxOldValue.Size = new System.Drawing.Size(59, 109);
            this.lbxOldValue.TabIndex = 8;
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(12, 233);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(124, 29);
            this.btnReplace.TabIndex = 10;
            this.btnReplace.Text = "Replace Et";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label6.ForeColor = System.Drawing.Color.Cyan;
            this.label6.Location = new System.Drawing.Point(9, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "@hbergun";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(565, 373);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.lbxOldValue);
            this.Controls.Add(this.lbxNewValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNewValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOldValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFindPath);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Değiştirici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdDosyaAc;
        private System.Windows.Forms.Button btnFindPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOldValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxNewValue;
        private System.Windows.Forms.ListBox lbxOldValue;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Label label6;
    }
}

