namespace CoTuong
{
    partial class FmPauseGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmPauseGame));
            this.lb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlNewGame = new System.Windows.Forms.Panel();
            this.pnlExit.SuspendLayout();
            this.pnlNewGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.BackColor = System.Drawing.Color.Transparent;
            this.lb.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.Color.Black;
            this.lb.Location = new System.Drawing.Point(132, 172);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(108, 20);
            this.lb.TabIndex = 5;
            this.lb.Text = "I don\'t know";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(133, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "**Quotations**";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(33, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 63);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pause Game";
            // 
            // pnlExit
            // 
            this.pnlExit.BackColor = System.Drawing.Color.Transparent;
            this.pnlExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlExit.BackgroundImage")));
            this.pnlExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlExit.Controls.Add(this.label4);
            this.pnlExit.Location = new System.Drawing.Point(111, 91);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Size = new System.Drawing.Size(151, 49);
            this.pnlExit.TabIndex = 8;
            this.pnlExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlExit_MouseClick);
            this.pnlExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlExit_MouseDown);
            this.pnlExit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlExit_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(199)))), ((int)(((byte)(162)))));
            this.label4.Location = new System.Drawing.Point(27, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 1;
            this.label4.Tag = "";
            this.label4.Text = "Tiếp tục";
            this.label4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Label4_MouseClick);
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelClick_MouseDown);
            this.label4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelClick_MouseUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(199)))), ((int)(((byte)(162)))));
            this.label5.Location = new System.Drawing.Point(14, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 0;
            this.label5.Tag = "";
            this.label5.Text = "Trò chơi mới";
            // 
            // pnlNewGame
            // 
            this.pnlNewGame.BackColor = System.Drawing.Color.Transparent;
            this.pnlNewGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlNewGame.BackgroundImage")));
            this.pnlNewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNewGame.Controls.Add(this.label5);
            this.pnlNewGame.Location = new System.Drawing.Point(106, 67);
            this.pnlNewGame.Name = "pnlNewGame";
            this.pnlNewGame.Size = new System.Drawing.Size(141, 49);
            this.pnlNewGame.TabIndex = 8;
            // 
            // FmPauseGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CoTuong.Properties.Resources.background_ziga;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(373, 217);
            this.Controls.Add(this.pnlExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FmPauseGame";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Co Tuong";
            this.pnlExit.ResumeLayout(false);
            this.pnlExit.PerformLayout();
            this.pnlNewGame.ResumeLayout(false);
            this.pnlNewGame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlNewGame;
        private System.Windows.Forms.Label label4;
    }
}