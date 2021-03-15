namespace CoTuong
{
    partial class FmSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmSetting));
            this.label1 = new System.Windows.Forms.Label();
            this.checkBSound = new System.Windows.Forms.CheckBox();
            this.checkBBGMusci = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlBGMusic = new System.Windows.Forms.Panel();
            this.btnReduction1 = new System.Windows.Forms.Button();
            this.btnIncrease1 = new System.Windows.Forms.Button();
            this.btnIncrease2 = new System.Windows.Forms.Button();
            this.btnReducation2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSound = new System.Windows.Forms.Panel();
            this.pnlApproved = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlApproved.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(139, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 63);
            this.label1.TabIndex = 7;
            this.label1.Text = "Setting";
            // 
            // checkBSound
            // 
            this.checkBSound.AutoSize = true;
            this.checkBSound.BackColor = System.Drawing.Color.Transparent;
            this.checkBSound.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBSound.Location = new System.Drawing.Point(57, 189);
            this.checkBSound.Name = "checkBSound";
            this.checkBSound.Size = new System.Drawing.Size(147, 35);
            this.checkBSound.TabIndex = 13;
            this.checkBSound.Text = "Âm thanh";
            this.checkBSound.UseMnemonic = false;
            this.checkBSound.UseVisualStyleBackColor = false;
            this.checkBSound.CheckedChanged += new System.EventHandler(this.CheckBSound_CheckedChanged);
            // 
            // checkBBGMusci
            // 
            this.checkBBGMusci.AutoSize = true;
            this.checkBBGMusci.BackColor = System.Drawing.Color.Transparent;
            this.checkBBGMusci.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.checkBBGMusci.FlatAppearance.BorderSize = 5;
            this.checkBBGMusci.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.checkBBGMusci.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkBBGMusci.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.checkBBGMusci.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBBGMusci.Location = new System.Drawing.Point(57, 82);
            this.checkBBGMusci.Name = "checkBBGMusci";
            this.checkBBGMusci.Size = new System.Drawing.Size(141, 35);
            this.checkBBGMusci.TabIndex = 0;
            this.checkBBGMusci.Text = "Nhạc nền";
            this.checkBBGMusci.UseMnemonic = false;
            this.checkBBGMusci.UseVisualStyleBackColor = false;
            this.checkBBGMusci.CheckedChanged += new System.EventHandler(this.CheckBBGMusci_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::CoTuong.Properties.Resources.o_chua__1_;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pnlBGMusic);
            this.panel2.Location = new System.Drawing.Point(107, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 53);
            this.panel2.TabIndex = 16;
            // 
            // pnlBGMusic
            // 
            this.pnlBGMusic.BackColor = System.Drawing.Color.Khaki;
            this.pnlBGMusic.Location = new System.Drawing.Point(30, 9);
            this.pnlBGMusic.MaximumSize = new System.Drawing.Size(200, 34);
            this.pnlBGMusic.MinimumSize = new System.Drawing.Size(0, 34);
            this.pnlBGMusic.Name = "pnlBGMusic";
            this.pnlBGMusic.Size = new System.Drawing.Size(200, 34);
            this.pnlBGMusic.TabIndex = 0;
            // 
            // btnReduction1
            // 
            this.btnReduction1.BackColor = System.Drawing.Color.Transparent;
            this.btnReduction1.BackgroundImage = global::CoTuong.Properties.Resources.arrow1__2_;
            this.btnReduction1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReduction1.FlatAppearance.BorderSize = 0;
            this.btnReduction1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReduction1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReduction1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReduction1.Location = new System.Drawing.Point(57, 123);
            this.btnReduction1.Name = "btnReduction1";
            this.btnReduction1.Size = new System.Drawing.Size(44, 44);
            this.btnReduction1.TabIndex = 1;
            this.btnReduction1.UseVisualStyleBackColor = false;
            this.btnReduction1.Click += new System.EventHandler(this.BtnReduction1_Click);
            this.btnReduction1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            this.btnReduction1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // btnIncrease1
            // 
            this.btnIncrease1.BackColor = System.Drawing.Color.Transparent;
            this.btnIncrease1.BackgroundImage = global::CoTuong.Properties.Resources.arrow1__1_;
            this.btnIncrease1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncrease1.FlatAppearance.BorderSize = 0;
            this.btnIncrease1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIncrease1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIncrease1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncrease1.Location = new System.Drawing.Point(373, 123);
            this.btnIncrease1.Name = "btnIncrease1";
            this.btnIncrease1.Size = new System.Drawing.Size(44, 44);
            this.btnIncrease1.TabIndex = 2;
            this.btnIncrease1.UseVisualStyleBackColor = false;
            this.btnIncrease1.Click += new System.EventHandler(this.BtnIncrease1_Click);
            this.btnIncrease1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            this.btnIncrease1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // btnIncrease2
            // 
            this.btnIncrease2.BackColor = System.Drawing.Color.Transparent;
            this.btnIncrease2.BackgroundImage = global::CoTuong.Properties.Resources.arrow1__1_;
            this.btnIncrease2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncrease2.FlatAppearance.BorderSize = 0;
            this.btnIncrease2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIncrease2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIncrease2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncrease2.Location = new System.Drawing.Point(373, 233);
            this.btnIncrease2.Name = "btnIncrease2";
            this.btnIncrease2.Size = new System.Drawing.Size(44, 44);
            this.btnIncrease2.TabIndex = 4;
            this.btnIncrease2.UseVisualStyleBackColor = false;
            this.btnIncrease2.Click += new System.EventHandler(this.BtnIncrease2_Click);
            this.btnIncrease2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            this.btnIncrease2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // btnReducation2
            // 
            this.btnReducation2.BackColor = System.Drawing.Color.Transparent;
            this.btnReducation2.BackgroundImage = global::CoTuong.Properties.Resources.arrow1__2_;
            this.btnReducation2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReducation2.FlatAppearance.BorderSize = 0;
            this.btnReducation2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReducation2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReducation2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReducation2.Location = new System.Drawing.Point(57, 233);
            this.btnReducation2.Name = "btnReducation2";
            this.btnReducation2.Size = new System.Drawing.Size(44, 44);
            this.btnReducation2.TabIndex = 3;
            this.btnReducation2.UseVisualStyleBackColor = false;
            this.btnReducation2.Click += new System.EventHandler(this.BtnReducation2_Click);
            this.btnReducation2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            this.btnReducation2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::CoTuong.Properties.Resources.o_chua__1_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pnlSound);
            this.panel1.Location = new System.Drawing.Point(107, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 53);
            this.panel1.TabIndex = 19;
            // 
            // pnlSound
            // 
            this.pnlSound.BackColor = System.Drawing.Color.Khaki;
            this.pnlSound.Location = new System.Drawing.Point(30, 9);
            this.pnlSound.MaximumSize = new System.Drawing.Size(200, 34);
            this.pnlSound.MinimumSize = new System.Drawing.Size(0, 34);
            this.pnlSound.Name = "pnlSound";
            this.pnlSound.Size = new System.Drawing.Size(200, 34);
            this.pnlSound.TabIndex = 1;
            // 
            // pnlApproved
            // 
            this.pnlApproved.BackColor = System.Drawing.Color.Transparent;
            this.pnlApproved.BackgroundImage = global::CoTuong.Properties.Resources.o_chua_2;
            this.pnlApproved.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlApproved.Controls.Add(this.label5);
            this.pnlApproved.Location = new System.Drawing.Point(83, 326);
            this.pnlApproved.Name = "pnlApproved";
            this.pnlApproved.Size = new System.Drawing.Size(130, 42);
            this.pnlApproved.TabIndex = 20;
            this.pnlApproved.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlNewGame_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(199)))), ((int)(((byte)(162)))));
            this.label5.Location = new System.Drawing.Point(37, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 0;
            this.label5.Tag = "";
            this.label5.Text = "Đồng ý";
            this.label5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Label5_MouseClick);
            // 
            // pnlExit
            // 
            this.pnlExit.BackColor = System.Drawing.Color.Transparent;
            this.pnlExit.BackgroundImage = global::CoTuong.Properties.Resources.o_chua_2;
            this.pnlExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlExit.Controls.Add(this.label2);
            this.pnlExit.Location = new System.Drawing.Point(263, 326);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Size = new System.Drawing.Size(130, 42);
            this.pnlExit.TabIndex = 21;
            this.pnlExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel3_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(199)))), ((int)(((byte)(162)))));
            this.label2.Location = new System.Drawing.Point(41, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 0;
            this.label2.Tag = "";
            this.label2.Text = "Thoát";
            this.label2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Label2_MouseClick);
            // 
            // FmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoTuong.Properties.Resources.background_ziga;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(477, 405);
            this.Controls.Add(this.pnlExit);
            this.Controls.Add(this.pnlApproved);
            this.Controls.Add(this.btnIncrease2);
            this.Controls.Add(this.btnReducation2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnIncrease1);
            this.Controls.Add(this.btnReduction1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.checkBSound);
            this.Controls.Add(this.checkBBGMusci);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FmSetting";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Co Tuong";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmSetting_FormClosing);
            this.Shown += new System.EventHandler(this.FmSetting_Shown);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlApproved.ResumeLayout(false);
            this.pnlApproved.PerformLayout();
            this.pnlExit.ResumeLayout(false);
            this.pnlExit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBSound;
        private System.Windows.Forms.CheckBox checkBBGMusci;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlBGMusic;
        private System.Windows.Forms.Button btnReduction1;
        private System.Windows.Forms.Button btnIncrease1;
        private System.Windows.Forms.Button btnIncrease2;
        private System.Windows.Forms.Button btnReducation2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSound;
        private System.Windows.Forms.Panel pnlApproved;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlExit;
        private System.Windows.Forms.Label label2;
    }
}