namespace Fake_Name_Generator
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnTitle = new System.Windows.Forms.Panel();
            this.btnMinisize = new Fake_Name_Generator.ThanhDatButtonTurmbl(this.components);
            this.btnClose = new Fake_Name_Generator.ThanhDatButtonTurmbl(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitleMain = new System.Windows.Forms.Label();
            this.pnMain = new System.Windows.Forms.Panel();
            this.btnGenerate = new Fake_Name_Generator.ThanhDatButtonSuccess(this.components);
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.cbb_name_set = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnMain.SuspendLayout();
            this.pnBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.Controls.Add(this.btnMinisize);
            this.pnTitle.Controls.Add(this.btnClose);
            this.pnTitle.Controls.Add(this.pictureBox1);
            this.pnTitle.Controls.Add(this.lblTitleMain);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(2, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(480, 32);
            this.pnTitle.TabIndex = 0;
            this.pnTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTitle_MouseDown);
            this.pnTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnTitle_MouseMove);
            this.pnTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnTitle_MouseUp);
            // 
            // btnMinisize
            // 
            this.btnMinisize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(92)))));
            this.btnMinisize.FlatAppearance.BorderSize = 0;
            this.btnMinisize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(95)))), ((int)(((byte)(124)))));
            this.btnMinisize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(95)))), ((int)(((byte)(124)))));
            this.btnMinisize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinisize.ForeColor = System.Drawing.Color.White;
            this.btnMinisize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinisize.Image")));
            this.btnMinisize.Location = new System.Drawing.Point(415, 0);
            this.btnMinisize.Name = "btnMinisize";
            this.btnMinisize.Size = new System.Drawing.Size(32, 32);
            this.btnMinisize.TabIndex = 1;
            this.btnMinisize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinisize.UseVisualStyleBackColor = false;
            this.btnMinisize.Click += new System.EventHandler(this.btnMinisize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(92)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(95)))), ((int)(((byte)(124)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(95)))), ((int)(((byte)(124)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(448, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 0;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Fake_Name_Generator.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitleMain
            // 
            this.lblTitleMain.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitleMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleMain.ForeColor = System.Drawing.Color.White;
            this.lblTitleMain.Location = new System.Drawing.Point(0, 0);
            this.lblTitleMain.Name = "lblTitleMain";
            this.lblTitleMain.Size = new System.Drawing.Size(480, 32);
            this.lblTitleMain.TabIndex = 0;
            this.lblTitleMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.White;
            this.pnMain.Controls.Add(this.btnGenerate);
            this.pnMain.Controls.Add(this.txt_email);
            this.pnMain.Controls.Add(this.txt_name);
            this.pnMain.Controls.Add(this.cbb_name_set);
            this.pnMain.Controls.Add(this.label3);
            this.pnMain.Controls.Add(this.label2);
            this.pnMain.Controls.Add(this.label4);
            this.pnMain.Controls.Add(this.pnBottom);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(2, 32);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(480, 136);
            this.pnMain.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(338, 19);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(119, 73);
            this.btnGenerate.TabIndex = 10;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txt_email
            // 
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Location = new System.Drawing.Point(123, 79);
            this.txt_email.Name = "txt_email";
            this.txt_email.ReadOnly = true;
            this.txt_email.Size = new System.Drawing.Size(198, 13);
            this.txt_email.TabIndex = 8;
            // 
            // txt_name
            // 
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.Location = new System.Drawing.Point(123, 48);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(198, 13);
            this.txt_name.TabIndex = 9;
            // 
            // cbb_name_set
            // 
            this.cbb_name_set.FormattingEnabled = true;
            this.cbb_name_set.Items.AddRange(new object[] {
            "Japanese",
            "American",
            "Arabic",
            "Chinese",
            "German",
            "Russian",
            "Croatian",
            "Persian",
            "Brazil",
            "Czech",
            "Danish",
            "Dutch",
            "French",
            "Hungarian",
            "Polish",
            "Thai",
            "Scottish"});
            this.cbb_name_set.Location = new System.Drawing.Point(123, 19);
            this.cbb_name_set.Name = "cbb_name_set";
            this.cbb_name_set.Size = new System.Drawing.Size(198, 21);
            this.cbb_name_set.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name Country";
            // 
            // pnBottom
            // 
            this.pnBottom.Controls.Add(this.lblVersion);
            this.pnBottom.Controls.Add(this.label1);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottom.Location = new System.Drawing.Point(0, 111);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(480, 25);
            this.pnBottom.TabIndex = 0;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(396, 6);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(81, 13);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Version: 1.0.0.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fake Name Generator - Copyright © 2016 Thanh Dat LLC. All rights reserved.";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 170);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fake Name Generator";
            this.pnTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.pnBottom.ResumeLayout(false);
            this.pnBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ThanhDatButtonTurmbl btnClose;
        private ThanhDatButtonTurmbl btnMinisize;
        private System.Windows.Forms.Label lblTitleMain;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.ComboBox cbb_name_set;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private ThanhDatButtonSuccess btnGenerate;
    }
}

