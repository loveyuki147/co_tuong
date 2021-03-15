using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoTuong
{
    public partial class FmPlayGame : Form
    {
        GameCoTuong playGame;
        FmNewGame formNewGame;
        bool dangKeo = false;
        Point pointStart;
        int time_Minutes;
        int time_Seconds;
        FmSetting fmSetting;
        public FmNewGame FormNewGame { get => formNewGame; private set => formNewGame = value; }
        public int Time_Minutes { get => time_Minutes; private set => time_Minutes = value; }
        public int Time_Seconds { get => time_Seconds; set => time_Seconds = value; }
        internal GameCoTuong PlayGame { get => playGame; set => playGame = value; }

        public FmPlayGame()
        {
            InitializeComponent();
            fmSetting = new FmSetting();
            PlayGame = new GameCoTuong(this, flpChess1, flpChess2);

        }



        #region Load
        private void FmPlayGame_Load(object sender, EventArgs e)
        {
            LoadForm();
            LoadControls_Event();
            FmIntroduce fmIntroduce = new FmIntroduce();
            fmIntroduce.ShowDialog();
            fmIntroduce.Dispose();
            Music.PlayBgMusic();
        }
        void LoadForm()
        {
            lbName1.Text = "";
            lbName2.Text = "";
            FormNewGame = new FmNewGame();
            FormNewGame.NamePlayer1 = "Player 1";
            FormNewGame.NamePlayer2 = "Player 2";
        }

        void LoadControls_Event()
        {
            // load ptb chiếu tướng
            ptbCheckmate.Width = 298;
            ptbCheckmate.Height = 366;
            ptbCheckmate.Location = new Point(155, 155);
            // ptbWinWin.Location = new Point(232, 324);

            pnl_ErrorCheckmate.Location = new Point(216, 317);

            pnlGG.Width = pnlWin.Width = 506;
            pnlGG.Height = pnlWin.Height = 542;
            pnlGG.Location = pnlWin.Location = new Point(41, 76);



        }


        #endregion

        #region Methods Other
        void Undo()
        {
            if (playGame.Undo())
                Time_Seconds = time_Minutes * 60;
        }
        void Reset()
        {
            ptbTurn1.Image = ptbTurn2.Image = CoTuong.Properties.Resources.NotTurn;
            ptbCheckmate.Visible = false;
            pnlWin.Visible = false;
            pnlGG.Visible = false;
            timeCoolDown.Stop();
            lbName1.Text = "";
            lbName2.Text = "";
            playGame.DisposeChess();
            lbCooldown.Text = "";
            lbCooldown.ForeColor = Color.FromArgb(221, 199, 162);
            pnlPause.Enabled = false;
            pnlUndo.Enabled = false;
            ptbBtnGG1.Visible = ptbBtnGG2.Visible = ptbBtnWinWin1.Visible = ptbBtnWinWin2.Visible = false;

        }
        void OpenFormNewGame()
        {
            timeCoolDown.Stop();
            if (FormNewGame.ShowDialog() == DialogResult.OK)
            {
                NewGame();
            }
            if (pnlPause.Enabled == true)
                timeCoolDown.Start();

        }

        void StartGame()
        {
            Music.PlayStartGameAndCheckmate();
            ptbReady.Visible = false;
            if (Time_Minutes > 0)
                timeCoolDown.Start();
            PlayGame.StartGame();
            UppdateSttAfterChangeTurn(PlayGame.Turn);
            pnlPause.Enabled = true;
            pnlUndo.Enabled = true;
        }

        void NewGame()
        {
            Reset();
            ptbReady.Visible = true;
            PlayGame.NewGame();

            timeCoolDown.Stop();
            PlayGame.Players[0].Name = FormNewGame.NamePlayer1;
            PlayGame.Players[1].Name = FormNewGame.NamePlayer2;
            lbName1.Text = PlayGame.Players[0].Name;
            lbName2.Text = PlayGame.Players[1].Name;



            PlayGame.Turn = FormNewGame.Turn;
            Time_Minutes = FormNewGame.GetTime();
            Time_Seconds = Time_Minutes * 60;
            lbCooldown.Text = "Thời gian: " + FormatTime(time_Seconds);
           

            ptbTurn1.Image = CoTuong.Properties.Resources.NotTurn;
            ptbTurn2.Image = CoTuong.Properties.Resources.NotTurn;
            lbCooldown.ForeColor = Color.FromArgb(221, 199, 162);

            pnlUndo.Enabled = false;
            pnlPause.Enabled = false;
        }

        void Setting()
        {
            timeCoolDown.Stop();
            fmSetting.ShowDialog();
            if(pnlPause.Enabled == true)
            {
                timeCoolDown.Start();
            }
        }

        public void UppdateSttAfterChangeTurn(int turn)
        {
            Time_Seconds = Time_Minutes * 60;
            if (turn == 1)
            {
                ptbTurn2.Image = CoTuong.Properties.Resources.NotTurn;
                ptbTurn1.Image = CoTuong.Properties.Resources.Turning;
                ptbBtnWinWin1.Visible = ptbBtnGG1.Visible = true;
                ptbBtnWinWin2.Visible = ptbBtnGG2.Visible = false;

            }
            else if (turn == 2)
            {
                ptbTurn1.Image = CoTuong.Properties.Resources.NotTurn;
                ptbTurn2.Image = CoTuong.Properties.Resources.Turning;
                ptbBtnWinWin1.Visible = ptbBtnGG1.Visible = false;
                ptbBtnWinWin2.Visible = ptbBtnGG2.Visible = true;
            }
        }


        string FormatTime(int seconds)
        {
            string rsl = "00:00";
            if (seconds <= 0)
                return rsl;
            int minutes = seconds / 60;
            int s = seconds % 60;
            rsl = String.Format("{0:00}:{1:00}", minutes, s);
            return rsl;
        }

        void CoolDown()
        {
            time_Seconds--;
            lbCooldown.ForeColor = lbCooldown.ForeColor = time_Seconds < 60 ?
                Color.Red : Color.FromArgb(221, 199, 162);
            lbCooldown.Text = "Thời gian: " + FormatTime(time_Seconds);
            if (time_Seconds <= 0)
            {
                Lose();
            }
        }

        void PauseGame()
        {
            timeCoolDown.Stop();
            FmPauseGame fmPauseGame = new FmPauseGame();
            fmPauseGame.ShowDialog();
            fmPauseGame.Dispose();
            timeCoolDown.Start();
        }

        Bitmap CutBitmap(Bitmap image, int X, int Y, int Width, int Height)
        {
            Bitmap rsl = new Bitmap(Width, Height);
            Graphics graphics = Graphics.FromImage(rsl);
            graphics.DrawImage(image, new Point(-X, -Y));
            return rsl;
        }

        void WinWin()
        {
            pnlUndo.Enabled = pnlPause.Enabled = false;
            timeCoolDown.Stop();
            Music.PlayWin();           
            ptbWinWin.Visible = true;
            ptbLose.Visible = false;
            pnlOver2.Visible = false;
            DisplayLoseAndWinWin();
        }

        void Lose()
        {
           pnlUndo.Enabled = pnlPause.Enabled = false;
            timeCoolDown.Stop();
            Music.PlayLose();
            ptbWinWin.Visible = false;
            ptbLose.Visible = true;
            pnlOver2.Visible = true;
            DisplayLoseAndWinWin();
        }
        #endregion

        #region Xử lí giao diện chiếu tướng
        public void DisplayCheckmate()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Tick += Timer_Tick;
            timer.Interval = 1200;
            Bitmap bm = playGame.DrawChessboardCurr();
            Bitmap rsl = CutBitmap(bm, ptbCheckmate.Location.X, ptbCheckmate.Location.Y,
                ptbCheckmate.Width, ptbCheckmate.Height);
            ptbCheckmate.BackgroundImage = rsl;
            timer.Tag = PlayGame.Turn;
            PlayGame.Turn = 0;
            ptbCheckmate.Show();
            timeCoolDown.Stop();
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = sender as System.Windows.Forms.Timer;
            ptbCheckmate.Hide();
            PlayGame.Turn = (int)timer.Tag;
            playGame.ChangeTurn();
            timeCoolDown.Start();
            timer.Stop();
            timer.Dispose();
        }
        //------------------------------------------------------------------------------------------------
        public void DisplayErrorCheckmate()
        {
            System.Windows.Forms.Timer timerErrorCheckmate = new System.Windows.Forms.Timer();
            timerErrorCheckmate.Tick += TimerErrorCheckmate_Tick;
            timerErrorCheckmate.Interval = 1000;
            Music.PlayErrorCheckmate();
            pnl_ErrorCheckmate.Visible = true;
            timeCoolDown.Stop();
            timerErrorCheckmate.Start();
        }

        private void TimerErrorCheckmate_Tick(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = sender as System.Windows.Forms.Timer;
            pnl_ErrorCheckmate.Visible = false;
            timeCoolDown.Start();
            timer.Stop();
            timer.Dispose();
        }
        //------------------------------------------------------------------------------------------------
        public void DisplayWin()
        {
            pnlUndo.Enabled = pnlPause.Enabled = false;
            timeCoolDown.Stop();
            Music.PlayWin();
            // thực hiện chụp màn hình
            Bitmap bm = playGame.DrawChessboardCurr();
            Bitmap rsl = CutBitmap(bm, pnlWin.Location.X, pnlWin.Location.Y,
                pnlWin.Width, pnlWin.Height);
            pnlWin.BackgroundImage = rsl;
            pnlWin.Visible = true;
            lbNameOver1.Text = PlayGame.Turn == 1 ? lbName1.Text : lbName2.Text;
            lbNameOver1.Location = new Point(pnlOver1.Width / 2 - lbNameOver1.Width / 2, lbNameOver1.Location.Y);          
        }
        //------------------------------------------------------------------------------------------------
        void DisplayLoseAndWinWin()
        {
            timeCoolDown.Stop();
            Bitmap bm = playGame.DrawChessboardCurr();
            Bitmap rsl = CutBitmap(bm, pnlGG.Location.X, pnlGG.Location.Y,
                 pnlGG.Width, pnlGG.Height);
            pnlGG.BackgroundImage = rsl;
            pnlGG.Visible = true;
            lbNameOver2.Text = PlayGame.Turn == 1 ? lbName1.Text : lbName2.Text;
            lbNameOver2.Location = new Point(pnlOver2.Width / 2 - lbNameOver2.Width / 2, lbNameOver2.Location.Y);
        }
        #endregion

        #region Event Tick

        private void TimeCoolDown_Tick(object sender, EventArgs e)
        {
            if (time_Minutes <= 0)
            {
                timeCoolDown.Stop();
                return;
            }
            CoolDown();
        }

        #endregion

        #region Event cho button
        private void PtbExit_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            PictureBox ptb = sender as PictureBox;
            ptb.Location = new Point(ptb.Location.X + 4, ptb.Location.Y + 3);
            ptb.Size = new Size(ptb.Width - 6, ptb.Height - 5);
        }

        private void PtbExit_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            PictureBox ptb = sender as PictureBox;
            ptb.Location = new Point(ptb.Location.X - 4, ptb.Location.Y - 3);
            ptb.Size = new Size(ptb.Width + 6, ptb.Height + 5);
        }

        private void PnlMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Panel pnl = sender as Panel;
            pnl.Size = new Size(pnl.Width - 5, pnl.Height - 5);
            pnl.Location = new Point(pnl.Location.X + 3, pnl.Location.Y + 3);
            Label lb = pnl.Controls[0] as Label;
            lb.Location = new Point(lb.Location.X - 2, lb.Location.Y - 2);
        }

        private void PnlMenu_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Panel pnl = sender as Panel;
            pnl.Size = new Size(pnl.Width + 5, pnl.Height + 5);
            pnl.Location = new Point(pnl.Location.X - 3, pnl.Location.Y - 3);
            Label lb = pnl.Controls[0] as Label;
            lb.Location = new Point(lb.Location.X + 2, lb.Location.Y + 2);
        }

        private void LabelButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Label lb = sender as Label;
            Panel pnl = lb.Parent as Panel;
            PnlMenu_MouseDown(pnl, new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0));
        }

        private void LabelButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Label lb = sender as Label;
            Panel pnl = lb.Parent as Panel;
            PnlMenu_MouseUp(pnl, new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0)); ;
        }

        // mở form new game
        private void PnlNewGame_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Music.PlayClick();
            OpenFormNewGame();

        }
        private void Label2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Music.PlayClick();
            OpenFormNewGame();

        }
        //--------------------------------------------------------------
        // tạm dừng
        private void PnlPause_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Music.PlayClick();
            if (timeCoolDown.Enabled == false)
                return;
           
            PauseGame();

        }
        private void Label3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Music.PlayClick();
            if (timeCoolDown.Enabled == false)
                return;         
            PauseGame();
        }
        //-----------------------------------------------------------------
        // undo
        private void PnlUndo_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Music.PlayClick();
            if (timeCoolDown.Enabled == false)
                return;
            Undo();
        }
        private void Label4_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Music.PlayClick();
            if (timeCoolDown.Enabled == false)
                return;
            Undo();
        }
        //-----------------------------------------------------------------
        // setting
        private void PnlSetting_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Music.PlayClick();
            Setting();
        }
        private void Label5_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Music.PlayClick();
            Setting();
        }

        //------------------------------------------------------------------
        // Undo sau khi win
        private void PnlUndoAfterWin_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Music.PlayClick();
            Undo();
            Undo();
            pnlWin.Visible = false;
            pnlUndo.Enabled = pnlPause.Enabled = true;
            timeCoolDown.Start();
        }
        private void Label6_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Music.PlayClick();
            Undo();
            Undo();
            pnlWin.Visible = false;
            pnlUndo.Enabled = true;
            timeCoolDown.Start();
        }
        //------------------------------------------------------------------
        // chịu thua
        private void PnlBtnClose_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Music.PlayClick();
            Reset();


        }
        private void Label7_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Music.PlayClick();
            Reset();

        }

        //------------------------------------------------------------------
        // Xin thua
        private void PtbBtnGG1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Music.PlayClick();
            if (timeCoolDown.Enabled == false)
                return;
            Lose();
        }
        //------------------------------------------------------------------

        // Cầu hòa
        private void PtbBtnWinWin1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Music.PlayClick();
            if (timeCoolDown.Enabled == false)
                return;
            WinWin();
        }
      
        #endregion

        #region Event Other
        private void PtbReady_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            StartGame();
        }

        private void PtbExit_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            Music.PlayClick();
            this.Close();
        }


        private void FmPlayGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region xử lí event thực hiên kéo thả form

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dangKeo = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dangKeo && pointStart != null)
            {
                // lấy ra điểm của trỏ chuột so với màn hình
                Point diemDen = this.PointToScreen(new Point(e.X, e.Y));
                // dữ nguyễn cửa sổ của form nếu k có form sẽ di chuyễn từ tọa độ 0,0 theo trỏ chuột
                diemDen.Offset(-pointStart.X, -pointStart.Y);
                this.Location = diemDen;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pointStart = new Point(e.X, e.Y);
                dangKeo = true;
            }
            else
                dangKeo = false;
        }







        #endregion
    }
}
