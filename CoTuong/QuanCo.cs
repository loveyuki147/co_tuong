using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoTuong
{
    class QuanCo
    {
        int phe;
        int loaiQuan;
        Bitmap bitmapChess;
        Bitmap bitmapChessMarked;
        Bitmap bitmapDieChess;
        PictureBox ptbChess;
        int row;
        int col;
        bool isLock;
        bool isMarked;

        public int Phe { get => phe; set => phe = value; }
        public int LoaiQuan { get => loaiQuan; set => loaiQuan = value; }
        public int Row { get => row; set => row = value; }
        public int Col { get => col; set => col = value; }
        public bool IsLock
        {
            get => isLock; set
            {
                isLock = value;
            }
        }
        public PictureBox PtbChess { get => ptbChess; set => ptbChess = value; }
        public Bitmap BitmapChess { get => bitmapChess; protected set => bitmapChess = value; }
        public Bitmap BitmapChessMarked { get => bitmapChessMarked; protected set => bitmapChessMarked = value; }
        public bool IsMarked
        {
            get => isMarked; set
            {
                isMarked = value;
                if (isMarked)
                    PtbChess.Image = BitmapChessMarked;
                else
                    PtbChess.Image = BitmapChess;
            }
        }

        public Bitmap BitmapDieChess { get => bitmapDieChess; protected set => bitmapDieChess = value; }

        public QuanCo(int hang, int cot)
        {
            Row = hang;
            Col = cot;
            phe = 0;
            loaiQuan = 0;
            PtbChess = new PictureBox();
            IsMarked = false;
            IsLock = true;

        }

        #region Xử lí chiếu tướng
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
        public int PlayerCheckmate(OCo[,] oCo)
        {
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 9; j++)
                {
                    if (oCo[i, j].Phe != 0)
                        if (oCo[i, j].Chess.IsCheckmate(oCo))
                            return oCo[i, j].Chess.Phe == 1 ? 2 : 1;
                }

            return 0;
        }
        public bool IsCheckmate(OCo[,] oCo, List<IndexArray> indexArrays)
        {
            foreach (IndexArray item in indexArrays)
            {
                if (oCo[item.I, item.J].Phe != 0)
                    if (oCo[item.I, item.J].Chess.IsCheckmate(oCo))
                        return true;
            }

            return false;
        }

        #endregion


        #region Methods
        public void DrawChess()
        {
            if (BitmapChess != null)
                PtbChess.Image = BitmapChess;
            PtbChess.Width = 42;
            PtbChess.Height = 42;
            SetLocationPtbByCurrIndex();
            PtbChess.BackColor = Color.Transparent;
            PtbChess.Tag = this;
            PtbChess.Visible = false;
            PtbChess.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public void SetLocationPtbByCurrIndex()
        {
            PtbChess.Left = Col * 53 + 61;
            PtbChess.Top = Row * 53 + 80;
        }

        public void ChangerChessAfterDie()
        {
            PtbChess.Image = null;
            PtbChess.BackgroundImage = bitmapDieChess;
            PtbChess.Size = bitmapDieChess.Size;
            PtbChess.Height = PtbChess.Height - 2;
            PtbChess.Cursor = Cursors.Default;
            PtbChess.Enabled = false;
        }

        public void Revival(int row, int col)
        {
            Row = row;
            Col = col;
            DrawChess();
            PtbChess.Visible = true;
        }
        #endregion
        #region Kế thừa
        public virtual void LoadPictureBoxAndDrawChess()
        {

        }
        public virtual bool CheckCanMoveTest(int i, int j)
        {
            return false;
        }
        /// <summary>
        /// Thực hiện mở tất cả ô có thể đi
        /// </summary>
        /// <param name="oCo"></param>
        public virtual void OpenCanMove(OCo[,] oCo)
        {

            // do somthing
        }
        /// <summary>
        /// Kiểm trả quân cờ hiện có chiếu tướng đối thủ không
        /// </summary>
        /// <param name="oCo"></param>
        /// <returns></returns>
        public virtual bool IsCheckmate(OCo[,] oCo)
        {
            return false;
        }
        /// <summary>
        /// Trả về list index có thể di chuyển
        /// </summary>
        /// <param name="oCo"></param>
        /// <returns></returns>
        public virtual List<IndexArray> GetListIndexCanMove(OCo[,] oCo)
        {
            return new List<IndexArray>();
        }
        #endregion

    }
}
