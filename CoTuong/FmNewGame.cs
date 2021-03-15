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
    public partial class FmNewGame : Form
    {
        private string namePlayer1, namePlayer2;
        private int turn;
        public string NamePlayer1
        {
            get => namePlayer1; set
            {
                namePlayer1 = value;
                txbPlayer1.Text = namePlayer1;
            }
        }
        public string NamePlayer2
        {
            get => namePlayer2; set
            {
                namePlayer2 = value;
                txbPlayer2.Text = namePlayer2;
            }
        }

        public int Turn { get => turn; }

        public FmNewGame()
        {
            InitializeComponent();
            turn = 1;
            //LoadBoder();
            cbTime.SelectedIndex = 1;
            AddDataBinding();
            displayNof();
        }


        #region methods
        void AddDataBinding()
        {
            cbTime.DataBindings.Add(new Binding("Enabled", checkBoxCoolDown, "Checked"));
        }

        bool isValidName(string name)
        {
            if (name.Length > 10 || name.Length < 2)
                return false;
           
            foreach (char item in name.ToCharArray())
            {
                if (((item < 'a' || item > 'z') && (item < 'A' || item > 'Z')) && item != ' ' && (item < '0' || item > '9'))
                    return false;
            }
            return true;
        }

        void displayNof()
        {
            if (!isValidName(txbPlayer1.Text) || !isValidName(txbPlayer2.Text) || txbPlayer1.Text.Equals(txbPlayer2.Text))
            {
                lbNof.Visible = true;
                pnlNewGame.Enabled = false;
            }
            else
            {
                lbNof.Visible = false;
                pnlNewGame.Enabled = true;
            }
        }
        public int GetTime()
        {
            if (checkBoxCoolDown.Checked == false)
                return 0;
            try
            {
                string time = cbTime.SelectedItem as string;
                string[] timeArray = time.Split(' ');
                int rsl = int.Parse(timeArray[0]);
                return rsl;
            }
            catch
            {
                return 0;
            }
        }
        #endregion

        #region Events
        private void PnlExit_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Music.PlayClick();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void PnlNewGame_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            NamePlayer1 = txbPlayer1.Text;
            NamePlayer2 = txbPlayer2.Text;
            turn = checkBoxTurn1.Checked ? 1 : 2;
            Music.PlayClick();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void CheckBoxTurn1_CheckedChanged(object sender, EventArgs e)
        {
            Music.PlayClick();
            checkBoxTurn2.Checked = !checkBoxTurn1.Checked;
            turn = checkBoxTurn1.Checked ? 1 : 2;

        }

        private void CheckBoxTurn2_CheckedChanged(object sender, EventArgs e)
        {
            Music.PlayClick();
            checkBoxTurn1.Checked = !checkBoxTurn2.Checked;
            turn = checkBoxTurn1.Checked ? 1 : 2;
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

        private void CheckBoxCoolDown_CheckedChanged(object sender, EventArgs e)
        {
            Music.PlayClick();
        }

        private void TbPlayer1_TextChanged(object sender, EventArgs e)
        {
            displayNof();
        }
        
        #endregion


    }
}
