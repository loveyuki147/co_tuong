namespace CoTuong
{
    partial class FmNewGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmNewGame));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxTurn2 = new System.Windows.Forms.CheckBox();
            this.lbNof = new System.Windows.Forms.Label();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.checkBoxTurn1 = new System.Windows.Forms.CheckBox();
            this.txbPlayer2 = new System.Windows.Forms.TextBox();
            this.txbPlayer1 = new System.Windows.Forms.TextBox();
            this.checkBoxCoolDown = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlNewGame = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlNewGame.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.checkBoxTurn2);
            this.panel1.Controls.Add(this.lbNof);
            this.panel1.Controls.Add(this.cbTime);
            this.panel1.Controls.Add(this.checkBoxTurn1);
            this.panel1.Controls.Add(this.txbPlayer2);
            this.panel1.Controls.Add(this.txbPlayer1);
            this.panel1.Controls.Add(this.checkBoxCoolDown);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(42, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 147);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Đi trước:";
            // 
            // checkBoxTurn2
            // 
            this.checkBoxTurn2.AutoSize = true;
            this.checkBoxTurn2.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTurn2.Location = new System.Drawing.Point(231, 70);
            this.checkBoxTurn2.Name = "checkBoxTurn2";
            this.checkBoxTurn2.Size = new System.Drawing.Size(76, 24);
            this.checkBoxTurn2.TabIndex = 3;
            this.checkBoxTurn2.Text = "Cờ đen";
            this.checkBoxTurn2.UseVisualStyleBackColor = true;
            this.checkBoxTurn2.CheckedChanged += new System.EventHandler(this.CheckBoxTurn2_CheckedChanged);
            // 
            // lbNof
            // 
            this.lbNof.AutoSize = true;
            this.lbNof.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNof.ForeColor = System.Drawing.Color.Red;
            this.lbNof.Location = new System.Drawing.Point(106, 124);
            this.lbNof.Name = "lbNof";
            this.lbNof.Size = new System.Drawing.Size(145, 17);
            this.lbNof.TabIndex = 6;
            this.lbNof.Text = "(Tên không hợp lệ)";
            // 
            // cbTime
            // 
            this.cbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTime.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTime.Items.AddRange(new object[] {
            "2 minute",
            "5 minute",
            "10 minute",
            "15 minute"});
            this.cbTime.Location = new System.Drawing.Point(209, 93);
            this.cbTime.Name = "cbTime";
            this.cbTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbTime.Size = new System.Drawing.Size(91, 25);
            this.cbTime.TabIndex = 5;
            // 
            // checkBoxTurn1
            // 
            this.checkBoxTurn1.AutoSize = true;
            this.checkBoxTurn1.Checked = true;
            this.checkBoxTurn1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTurn1.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTurn1.Location = new System.Drawing.Point(144, 70);
            this.checkBoxTurn1.Name = "checkBoxTurn1";
            this.checkBoxTurn1.Size = new System.Drawing.Size(70, 24);
            this.checkBoxTurn1.TabIndex = 2;
            this.checkBoxTurn1.Text = "Cờ đỏ";
            this.checkBoxTurn1.UseVisualStyleBackColor = true;
            this.checkBoxTurn1.CheckedChanged += new System.EventHandler(this.CheckBoxTurn1_CheckedChanged);
            // 
            // txbPlayer2
            // 
            this.txbPlayer2.BackColor = System.Drawing.Color.BurlyWood;
            this.txbPlayer2.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPlayer2.Location = new System.Drawing.Point(144, 40);
            this.txbPlayer2.Name = "txbPlayer2";
            this.txbPlayer2.Size = new System.Drawing.Size(156, 28);
            this.txbPlayer2.TabIndex = 1;
            this.txbPlayer2.TextChanged += new System.EventHandler(this.TbPlayer1_TextChanged);
            // 
            // txbPlayer1
            // 
            this.txbPlayer1.BackColor = System.Drawing.Color.BurlyWood;
            this.txbPlayer1.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPlayer1.Location = new System.Drawing.Point(144, 7);
            this.txbPlayer1.Name = "txbPlayer1";
            this.txbPlayer1.Size = new System.Drawing.Size(156, 28);
            this.txbPlayer1.TabIndex = 0;
            this.txbPlayer1.TextChanged += new System.EventHandler(this.TbPlayer1_TextChanged);
            // 
            // checkBoxCoolDown
            // 
            this.checkBoxCoolDown.AutoSize = true;
            this.checkBoxCoolDown.Checked = true;
            this.checkBoxCoolDown.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCoolDown.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCoolDown.Location = new System.Drawing.Point(111, 95);
            this.checkBoxCoolDown.Name = "checkBoxCoolDown";
            this.checkBoxCoolDown.Size = new System.Drawing.Size(92, 24);
            this.checkBoxCoolDown.TabIndex = 4;
            this.checkBoxCoolDown.Text = "Thời gian";
            this.checkBoxCoolDown.UseVisualStyleBackColor = true;
            this.checkBoxCoolDown.CheckedChanged += new System.EventHandler(this.CheckBoxCoolDown_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cờ đen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cờ đỏ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(83, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 63);
            this.label1.TabIndex = 6;
            this.label1.Text = "New Game";
            // 
            // pnlNewGame
            // 
            this.pnlNewGame.BackColor = System.Drawing.Color.Transparent;
            this.pnlNewGame.BackgroundImage = global::CoTuong.Properties.Resources.o_chua_2;
            this.pnlNewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNewGame.Controls.Add(this.label5);
            this.pnlNewGame.Location = new System.Drawing.Point(75, 229);
            this.pnlNewGame.Name = "pnlNewGame";
            this.pnlNewGame.Size = new System.Drawing.Size(130, 42);
            this.pnlNewGame.TabIndex = 6;
            this.pnlNewGame.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlNewGame_MouseClick);
            this.pnlNewGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlExit_MouseDown);
            this.pnlNewGame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlExit_MouseUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(199)))), ((int)(((byte)(162)))));
            this.label5.Location = new System.Drawing.Point(16, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 0;
            this.label5.Tag = "";
            this.label5.Text = "Trò chơi mới";
            this.label5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlNewGame_MouseClick);
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label4_MouseDown);
            this.label5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Label4_MouseUp);
            // 
            // pnlExit
            // 
            this.pnlExit.BackColor = System.Drawing.Color.Transparent;
            this.pnlExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlExit.BackgroundImage")));
            this.pnlExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlExit.Controls.Add(this.label6);
            this.pnlExit.Location = new System.Drawing.Point(238, 229);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Size = new System.Drawing.Size(130, 42);
            this.pnlExit.TabIndex = 7;
            this.pnlExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlExit_MouseClick);
            this.pnlExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlExit_MouseDown);
            this.pnlExit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlExit_MouseUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(199)))), ((int)(((byte)(162)))));
            this.label6.Location = new System.Drawing.Point(41, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 1;
            this.label6.Tag = "pnl";
            this.label6.Text = "Thoát";
            this.label6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlExit_MouseClick);
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label4_MouseDown);
            this.label6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Label4_MouseUp);
            // 
            // FmNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CoTuong.Properties.Resources.background_ziga;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(443, 293);
            this.Controls.Add(this.pnlExit);
            this.Controls.Add(this.pnlNewGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FmNewGame";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Co Tuong";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlNewGame.ResumeLayout(false);
            this.pnlNewGame.PerformLayout();
            this.pnlExit.ResumeLayout(false);
            this.pnlExit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPlayer2;
        private System.Windows.Forms.TextBox txbPlayer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.CheckBox checkBoxCoolDown;
        private System.Windows.Forms.Label lbNof;
        private System.Windows.Forms.CheckBox checkBoxTurn2;
        private System.Windows.Forms.CheckBox checkBoxTurn1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlNewGame;
        private System.Windows.Forms.Panel pnlExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}