using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoTuong
{
    class GameCoTuong
    {
        Chessboard chessBoard;
        List<QuanCo> listAllChessesCurr;
        QuanCo currChessMarked;
        QuanCo chessWillDie;
        FmPlayGame fmMain;
        int turn;
        Player[] players;
        FlowLayoutPanel flpChess1;
        FlowLayoutPanel flpChess2;
        Stack<InfoTurn> stackUndo;

        #region đóng gói
        internal Chessboard Chessboard { get => chessBoard; set => chessBoard = value; }
        internal List<QuanCo> ListAllChessesCurr { get => listAllChessesCurr; private set => listAllChessesCurr = value; }

        public FmPlayGame FmMain { get => fmMain; private set => fmMain = value; }
        public int Turn { get => turn; set => turn = value; }
        internal Player[] Players { get => players; set => players = value; }
        internal QuanCo CurrChessMarked { get => currChessMarked; private set => currChessMarked = value; }
        public FlowLayoutPanel FlpChess1 { get => flpChess1; private set => flpChess1 = value; }
        public FlowLayoutPanel FlpChess2 { get => flpChess2; private set => flpChess2 = value; }
        internal Stack<InfoTurn> StackUndo { get => stackUndo; }
        #endregion

        #region ctor và load
        public GameCoTuong(FmPlayGame fm, FlowLayoutPanel flowLayoutPanel1, FlowLayoutPanel flowLayoutPanel2)
        {
            CurrChessMarked = null;
            FlpChess1 = flowLayoutPanel1;
            FlpChess2 = flowLayoutPanel2;
            // LoadPlayers();
            FmMain = fm;
            // Chessboard = new BanCo();
            ListAllChessesCurr = new List<QuanCo>();
            stackUndo = new Stack<InfoTurn>();
            Turn = 0;
        }
        void LoadPlayers()
        {
            Players = new Player[2];
            Players[0] = new Player(1);
            Players[1] = new Player(2);
        }
        #endregion

        #region Methods_Other
        public Bitmap DrawChessboardCurr()
        {
            Bitmap bm = new Bitmap(FmMain.Width, FmMain.Height);
            using (Graphics graphics = Graphics.FromImage(bm))
            {
                Rectangle rectangle_tmp = new Rectangle(new Point(0, 0), new Size(FmMain.Width, FmMain.Height));
                graphics.DrawImage(CoTuong.Properties.Resources.bg, rectangle_tmp);
                foreach (var item in ListAllChessesCurr)
                {
                    Rectangle rectangle = new Rectangle(new Point(item.PtbChess.Location.X, item.PtbChess.Location.Y),
                        new Size(item.PtbChess.Width, item.PtbChess.Height));
                    graphics.DrawImage(item.PtbChess.Image, rectangle);
                }
                for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 9; j++)
                    {
                        if (Chessboard.MangOco[i, j].CanMove.Visible == true)
                        {
                            Rectangle rectangle = new Rectangle(new Point(Chessboard.MangOco[i, j].CanMove.Location.X, Chessboard.MangOco[i, j].CanMove.Location.Y),
                        new Size(Chessboard.MangOco[i, j].CanMove.Width, Chessboard.MangOco[i, j].CanMove.Height));
                            graphics.DrawImage(Chessboard.MangOco[i, j].CanMove.Image, rectangle);
                        }
                    }
                graphics.Save();
            }
            return bm;
        }
        public void LoadBanCo()
        {
            Chessboard.LoadOco();
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 9; j++)
                {
                    FmMain.Controls.Add(Chessboard.MangOco[i, j].CanMove);
                    Chessboard.MangOco[i, j].CanMove.MouseClick += CanMove_MouseClick;
                }

            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 9; j++)
                {
                    QuanCo quanCo = Chessboard.MangOco[i, j].Chess;
                    if (quanCo != null)
                    {
                        FmMain.Controls.Add(quanCo.PtbChess);
                        quanCo.PtbChess.MouseClick += PtbQuanCo_MouseClick;
                        ListAllChessesCurr.Add(quanCo);
                        if (quanCo.Phe == 1)
                        {
                            Players[0].ListChess.Add(quanCo);
                            if (quanCo.LoaiQuan == 7)
                            {
                                Players[0].Tuong = quanCo as Tuong;
                            }
                        }
                        else
                        {
                            Players[1].ListChess.Add(quanCo);
                            if (quanCo.LoaiQuan == 7)
                            {
                                Players[1].Tuong = quanCo as Tuong;
                            }
                        }

                    }

                }
        }
        public void NewGame()
        {
            Turn = 0;
            DisposeChess();
            LoadPlayers();
            LoadBanCo();
            currChessMarked = null;
            chessWillDie = null;

        }
        public void StartGame()
        {
            ShowAllChesses();
            OpenClick(Turn);
        }
        public void ChangeTurn()
        {
            Turn = Turn == 1 ? 2 : 1;
            ChangeSttAfterChangeTurn(Turn);
        }
        void ChangeSttAfterChangeTurn(int turn)
        {
            FmMain.UppdateSttAfterChangeTurn(turn);
            OpenClick(turn);
        }
        void ShowAllChesses()
        {
            //DrawChessboardBegin(FmMain);
            foreach (QuanCo item in ListAllChessesCurr)
            {
                item.PtbChess.Visible = true;
            }

        }
        public void DisposeChess()
        {

            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 9; j++)
                {
                    if (Chessboard.MangOco[i, j] != null)
                        Chessboard.MangOco[i, j].CanMove.Dispose();
                }
            foreach (QuanCo item in ListAllChessesCurr)
            {
                item.PtbChess.Dispose();
            }
            foreach (Control item in FlpChess1.Controls)
            {
                item.Dispose();
            }
            foreach (Control item in FlpChess2.Controls)
            {
                item.Dispose();
            }
            FlpChess1.Controls.Clear();
            FlpChess2.Controls.Clear();
            ListAllChessesCurr.Clear();

        }
        void ResetStatusChessboard()
        {
            if (currChessMarked != null)
            {

                currChessMarked.IsMarked = false;
                if (currChessMarked.LoaiQuan == 7 && (currChessMarked as Tuong).AreCheckmate)
                {
                    Tuong tuong = (currChessMarked as Tuong);
                    tuong.PtbChess.Image = tuong.BitmapChieuTuong;
                }
            }
            Chessboard.ResetCanMove();
        }
        void MoveChess(QuanCo qc, OCo oCo)
        {
            ResetStatusChessboard();
            int row = qc.Row;
            int col = qc.Col;
            chessWillDie = oCo.Chess;
            oCo.Chess = qc;
            Chessboard.MangOco[row, col].Chess = null;
        }
        void OpenClick(int turn)
        {
            if (turn <= 0)
                return;
            foreach (QuanCo item in ListAllChessesCurr)
            {
                if (turn == item.Phe)
                    item.PtbChess.Cursor = Cursors.Hand;
                else
                    item.PtbChess.Cursor = Cursors.Default;
            }

        }
        public void CloseAllClick()
        {
            foreach (QuanCo item in ListAllChessesCurr)
            {
                item.PtbChess.Cursor = Cursors.Default;
            }
        }
        void Checkmark(int turnCheckmate)
        {
            Music.PlayStartGameAndCheckmate();
            if (turnCheckmate == 2)
            {
                Players[1].Tuong.AreCheckmate = true;
            }
            else
            {
                Players[0].Tuong.AreCheckmate = true;
            }
        }
        void NotCheckmark()
        {
            Music.PlayMoveChess();
            Players[0].Tuong.AreCheckmate = false;
            Players[1].Tuong.AreCheckmate = false;
        }
        void MakeAMoveChess(QuanCo currChessMarked, OCo oCo)
        {
            if (currChessMarked != null)
            {
                int row = currChessMarked.Row;
                int col = currChessMarked.Col;
                MoveChess(currChessMarked, oCo);
                if (chessWillDie != null)
                    ListAllChessesCurr.Remove(chessWillDie);
                int playerCheckmate = PlayerCheckmate(ListAllChessesCurr, Chessboard.MangOco);
                if (playerCheckmate != 0)
                {
                    if (playerCheckmate == Turn)
                    {
                        // nếu gặp lỗi chiếu tướng thì thực hiện đi lại
                        QuanCo tmp = chessWillDie;
                        MoveChess(currChessMarked, Chessboard.MangOco[row, col]);
                        if (tmp != null)
                        {
                            oCo.Chess = tmp;
                            ListAllChessesCurr.Add(tmp);
                        }

                        FmMain.DisplayErrorCheckmate();
                    }
                    else
                    {
                        AddStackNode(currChessMarked, Chessboard.MangOco[row, col], chessWillDie);
                        EatChess(chessWillDie, oCo, Turn);
                        if (IsWiner(Turn))
                        {
                            FmMain.DisplayWin();
                            return;
                        }
                        Checkmark(playerCheckmate);
                        CloseAllClick();
                        FmMain.DisplayCheckmate();
                    }
                    return;
                }
                else
                {
                    AddStackNode(currChessMarked, Chessboard.MangOco[row, col], chessWillDie);
                    NotCheckmark();
                    EatChess(chessWillDie, oCo, Turn);
                    ChangeTurn();

                }


            }
        }

        #endregion

        #region Xử lí undo
        void AddStackNode(QuanCo chess, OCo oCo, QuanCo ChessBeenEating)
        {
            InfoTurn infoTurn = new InfoTurn(chess, oCo, ChessBeenEating);
            stackUndo.Push(infoTurn);
        }

        public bool Undo()
        {
            if (StackUndo.Count == 0)
                return false;
            InfoTurn infoTurn = StackUndo.Pop();
            int row = infoTurn.Chess.Row;
            int col = infoTurn.Chess.Col;
            MoveChess(infoTurn.Chess, infoTurn.OCo);
            if (infoTurn.ChessBeenEating != null)
            {
                if (infoTurn.ChessBeenEating.Phe == 1)
                {
                    FlpChess1.Controls.Remove(infoTurn.ChessBeenEating.PtbChess);
                }
                else
                {
                    FlpChess2.Controls.Remove(infoTurn.ChessBeenEating.PtbChess);
                }
                FmMain.Controls.Add(infoTurn.ChessBeenEating.PtbChess);
                infoTurn.ChessBeenEating.Revival(row, col);
                Chessboard.MangOco[row, col].Chess = infoTurn.ChessBeenEating;
                ListAllChessesCurr.Add(infoTurn.ChessBeenEating);
            }
            this.Turn = infoTurn.Chess.Phe;
            ChangeSttAfterChangeTurn(this.Turn);
            // hồi sinh quân cờ kiểm tra xem có chiếu tướng không
            int playerCheckmate = PlayerCheckmate(ListAllChessesCurr, Chessboard.MangOco);
            if (playerCheckmate != 0)
            {
                Checkmark(playerCheckmate);
            }
            else
            {
                NotCheckmark();
            }
            return true;
        }
        #endregion

        #region Xử lí chiếu tướng
        /// <summary>
        /// Trả về phe bị chiếu
        /// </summary>
        /// <param name="Chesses"></param>
        /// <param name="oCo"></param>
        /// <returns></returns>
        public int PlayerCheckmate(List<QuanCo> Chesses, OCo[,] oCo)
        {
            foreach (QuanCo item in Chesses)
            {
                if (item.Phe != 0)
                {
                    if (item.IsCheckmate(oCo))
                        return item.Phe == 1 ? 2 : 1;
                }
            }
            return 0;
        }
        public int PlayerCheckmate(QuanCo item, OCo[,] oCo)
        {
            if (item != null && item.Phe != 0)
            {
                if (item.IsCheckmate(oCo))
                    return item.Phe == 1 ? 2 : 1;
            }

            return 0;
        }
        public bool IsWiner(int currTurn)
        {
            bool check = true;
            List<QuanCo> ListChess = currTurn == 1 ? Players[1].ListChess : Players[0].ListChess;
            List<QuanCo> ListCurrChess = currTurn == 1 ? Players[0].ListChess : Players[1].ListChess;
            foreach (var item in ListChess)
            {
                // xét vị trí tại quân cờ thành 0
                Chessboard.MangOco[item.Row, item.Col].Phe = 0;
                Chessboard.MangOco[item.Row, item.Col].LoaiCo = 0;
                int row_tmp = item.Row;
                int col_tmp = item.Col;
                List<IndexArray> indexArrays = item.GetListIndexCanMove(Chessboard.MangOco);
                foreach (var info in indexArrays)
                {
                    // di chuyển từng vị trí có thể đi được
                    int tmp1 = Chessboard.MangOco[info.I, info.J].Phe;
                    int tmp2 = Chessboard.MangOco[info.I, info.J].LoaiCo;
                    QuanCo chess_tmp = null;
                    if (Chessboard.MangOco[info.I, info.J].Chess != null)
                    {
                        chess_tmp = Chessboard.MangOco[info.I, info.J].Chess;
                        ListCurrChess.Remove(chess_tmp);
                    }
                    item.Row = info.I;
                    item.Col = info.J;
                    Chessboard.MangOco[info.I, info.J].Phe = item.Phe;
                    Chessboard.MangOco[info.I, info.J].LoaiCo = item.LoaiQuan;
                    int rsl = PlayerCheckmate(ListCurrChess, Chessboard.MangOco);
                    if (chess_tmp != null)
                        ListCurrChess.Add(chess_tmp);
                    Chessboard.MangOco[info.I, info.J].Phe = tmp1;
                    Chessboard.MangOco[info.I, info.J].LoaiCo = tmp2;

                    if (rsl == 0)
                    {
                        check = false;
                        break;
                    }
                }
                // trả lại vị trí ban đầu
                item.Row = row_tmp;
                item.Col = col_tmp;
                Chessboard.MangOco[item.Row, item.Col].Phe = item.Phe;
                Chessboard.MangOco[item.Row, item.Col].LoaiCo = item.LoaiQuan;
                if (!check)
                    break;
            }

            return check;
        }
        #endregion

        #region Xử lí ăn cờ
        void AfterEat(QuanCo eatChess, int turn)
        {
            eatChess.ChangerChessAfterDie();
            Music.PlayEatChess();
            ListAllChessesCurr.Remove(eatChess);
            if (turn == 2)
            {
                FlpChess1.Controls.Add(eatChess.PtbChess);
                players[0].ListChess.Remove(eatChess);
            }
            else if (turn == 1)
            {
                FlpChess2.Controls.Add(eatChess.PtbChess);
                players[1].ListChess.Remove(eatChess);
            }
        }
        void EatChess(QuanCo qc, OCo oCo, int turn)
        {
            if (qc == null) return;
            if (oCo.Chess.Phe != qc.Phe && oCo.Chess.Phe != 0)
            {
                AfterEat(qc, turn);
            }
        }
        #endregion

        #region events

        private void PtbQuanCo_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                return;
            PictureBox ptb = sender as PictureBox;
            QuanCo quanCo = ptb.Tag as QuanCo;
            if (Turn != quanCo.Phe)
                return;
            if (quanCo.IsMarked)
            {
                ResetStatusChessboard();
                return;
            }
            ResetStatusChessboard();
            CurrChessMarked = quanCo;
            CurrChessMarked.IsMarked = true;
            CurrChessMarked.OpenCanMove(Chessboard.MangOco);
        }

        private void CanMove_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                return;
            PictureBox ptb = sender as PictureBox;
            OCo oCo = ptb.Tag as OCo;
            MakeAMoveChess(CurrChessMarked, oCo);
        }
        #endregion

    }
}
