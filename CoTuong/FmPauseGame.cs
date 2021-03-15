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
    public partial class FmPauseGame : Form
    {
        List<string> listString;
        public FmPauseGame()
        {
            InitializeComponent();
            LoadListString();
            LoadQuotations();
        }
        #region Methods


        void LoadListString()
        {
            listString = new List<string>();
            listString.Add("Don’t cry because it’s over,\nsmile because it happened.");
            listString.Add("You only live once, but if you \n do it right, once is enough.");
            listString.Add("Life is what happens to us while \n    we are making other plans.");
            listString.Add("Everything you can imagine is real.");
            listString.Add("It does not do to dwell on \ndreams and forget to live.");
            listString.Add("This too, shall pass.");
            listString.Add("Life’s too mysterious to take too serious.");
            listString.Add("Believe you can and you’re halfway there.");
            listString.Add("Love means you never have to say you’re sorry");
        }
        void LoadQuotations()
        {
            if (listString.Count == 0)
                return;
            Random random = new Random();
            int numRad = random.Next(0, listString.Count);
            lb.Text = listString[numRad];
            lb.Location = new Point(this.Width / 2 - lb.Width / 2, lb.Location.Y);
        }
        #endregion
        #region Events

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

        private void LabelClick_MouseDown(object sender, MouseEventArgs e)
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

        private void LabelClick_MouseUp(object sender, MouseEventArgs e)
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

        private void PnlExit_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Music.PlayClick();
            this.Close();
        }

        private void Label4_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Music.PlayClick();
            this.Close();
        }
        #endregion
    }
}
