using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoTuong
{
    public partial class FmSetting : Form
    {
        public FmSetting()
        {
            InitializeComponent();
            pnlSound.MaximumSize = pnlBGMusic.MaximumSize = new Size(200, 34);
            pnlSound.MinimumSize = pnlBGMusic.MinimumSize = new Size(0, 34);
            LoadSetting();
        }
        void LoadSetting()
        {
            checkBBGMusci.Checked = Music.IsPlayMusic;
            checkBSound.Checked = Music.IsPlaySound;
            pnlSound.Width = Music.VolumeOfSound * 2;
            pnlBGMusic.Width = Music.VolumeOfMusicBg * 2;
        }

        #region Event của From
        private void FmSetting_Shown(object sender, EventArgs e)
        {
            LoadSetting();
        }
        private void FmSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Music.LoadSetting();
        }
        #endregion

        #region event hiệu ứng bấm nút
        private void Button_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Button button = sender as Button;
            button.Width = button.Width - 2;
            button.Height = button.Height - 2;
            // button.Location = new Point(button.Location.X + 1, button.Location.Y + 1);
        }
        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Button button = sender as Button;
            button.Width = button.Width + 2;
            button.Height = button.Height + 2;
            // button.Location = new Point(button.Location.X - 1, button.Location.Y - 1);
        }

        private void PnlExit_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            try
            {
                Panel pnl = sender as Panel;
                pnl.Size = new Size(pnl.Width - 5, pnl.Height - 5);
                pnl.Location = new Point(pnl.Location.X + 3, pnl.Location.Y + 3);
                Label lb = pnl.Controls[0] as Label;
                lb.Location = new Point(lb.Location.X - 2, lb.Location.Y - 2);
            }
            catch
            {

            }
        }

        private void PnlExit_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            try
            {
                Panel pnl = sender as Panel;
                pnl.Size = new Size(pnl.Width + 5, pnl.Height + 5);
                pnl.Location = new Point(pnl.Location.X - 3, pnl.Location.Y - 3);
                Label lb = pnl.Controls[0] as Label;
                lb.Location = new Point(lb.Location.X + 2, lb.Location.Y + 2);
            }
            catch
            {

            }
        }

        private void Label4_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button != MouseButtons.Left)
                return;
            try
            {
                Label lb = sender as Label;
                PnlExit_MouseDown(lb.Parent as Panel, new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0));
            }
            catch
            {

            }
        }

        private void Label4_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            try
            {
                Label lb = sender as Label;
                PnlExit_MouseUp(lb.Parent as Panel, new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0));
            }
            catch
            {

            }
        }
        #endregion

        #region events xử lí âm thanh
        private void BtnReduction1_Click(object sender, EventArgs e)
        {
            pnlBGMusic.Width -= 10;
            Music.SetElementsTempForSetting(checkBBGMusci.Checked, checkBSound.Checked,
                pnlBGMusic.Width / 2, pnlSound.Width / 2);
            Music.PlayClick();
        }

        private void BtnIncrease1_Click(object sender, EventArgs e)
        {
            pnlBGMusic.Width += 10;
            Music.SetElementsTempForSetting(checkBBGMusci.Checked, checkBSound.Checked,
                pnlBGMusic.Width / 2, pnlSound.Width / 2);
            Music.PlayClick();
        }

        private void BtnReducation2_Click(object sender, EventArgs e)
        {
            pnlSound.Width -= 10;
            Music.SetElementsTempForSetting(checkBBGMusci.Checked, checkBSound.Checked,
               pnlBGMusic.Width / 2, pnlSound.Width / 2);
            Music.PlayClick();
        }

        private void BtnIncrease2_Click(object sender, EventArgs e)
        {
            pnlSound.Width += 10;
            Music.SetElementsTempForSetting(checkBBGMusci.Checked, checkBSound.Checked,
                pnlBGMusic.Width / 2, pnlSound.Width / 2);
            Music.PlayClick();
        }

        private void CheckBBGMusci_CheckedChanged(object sender, EventArgs e)
        {
            Music.SetElementsTempForSetting(checkBBGMusci.Checked, checkBSound.Checked,
               pnlBGMusic.Width / 2, pnlSound.Width / 2);
            Music.PlayClick();
        }

        private void CheckBSound_CheckedChanged(object sender, EventArgs e)
        {
            Music.SetElementsTempForSetting(checkBBGMusci.Checked, checkBSound.Checked,
                  pnlBGMusic.Width / 2, pnlSound.Width / 2);
            Music.PlayClick();
        }

        #endregion

        #region event nút bấm xử lí save setting
        private void PnlNewGame_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Music.WriteFileForSetting(checkBBGMusci.Checked, checkBSound.Checked,
                  pnlBGMusic.Width / 2, pnlSound.Width / 2);
            Music.PlayClick();
            this.Close();
        }

        private void Label5_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Music.WriteFileForSetting(checkBBGMusci.Checked, checkBSound.Checked,
                  pnlBGMusic.Width / 2, pnlSound.Width / 2);
            Music.PlayClick();
            this.Close();
        }

        private void Label2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Music.PlayClick();
            this.Close();
        }

        private void Panel3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Music.PlayClick();
            this.Close();
        }
        #endregion

        
    }
}
