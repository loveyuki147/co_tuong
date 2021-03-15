using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoTuong
{
    class OCo
    {
        static public int HeightPtb = 28;
        static public int WitdhtPtb = 28;
        PictureBox canMove;
        int row;
        int col;
        int loaiCo;
        QuanCo chess;
        int phe;

        public PictureBox CanMove { get => canMove; private set => canMove = value; }
        public int Row { get => row; private set => row = value; }
        public int Col { get => col; private set => col = value; }
        public int LoaiCo { get => loaiCo; set => loaiCo = value; }
        public int Phe { get => phe; set => phe = value; }
        internal QuanCo Chess
        {
            get => chess; set
            {
                chess = value;
                SetLoaiCo();
            }
        }



        public OCo()
        {
            CanMove = new PictureBox();
            Row = 0;
            Col = 0;
            LoaiCo = 0;
        }
        public OCo(int hang, int cot)
        {
            Row = hang;
            Col = cot;
            CanMove = new PictureBox();
            SetLoaiCo();
            loadPTB(hang, cot);

        }

        #region Methods
        void SetLoaiCo()
        {
            if (Chess == null)
            {
                LoaiCo = 0;
                Phe = 0;
                DrawPTBCanMove();
            }
            else
            {
                LoaiCo = Chess.LoaiQuan;
                chess.Row = row;
                chess.Col = col;
                chess.SetLocationPtbByCurrIndex();
                Phe = chess.Phe;
                SetBitmapCanMoveWhenHaveChess(Chess.BitmapChess);
            }
        }
        void loadPTB(int hang, int cot)
        {
            DrawPTBCanMove();
            CanMove.Cursor = Cursors.Hand;
            CanMove.BackColor = Color.Transparent;
            CanMove.Visible = false;
            CanMove.WaitOnLoad = true;
        }
        void DrawPTBCanMove()
        {
            CanMove.BackgroundImageLayout = ImageLayout.None;
            CanMove.Image = CoTuong.Properties.Resources.CanMove;
            CanMove.Width = 28;
            CanMove.Height = 28;

            if (Col == 0 || Col == 1 || Col == 2)
                CanMove.Location = new Point(col * 53 + 70, row * 53 + 87);
            else
                CanMove.Location = new Point(col * 53 + 68, row * 53 + 87);
            if (Row >= 5)
                CanMove.Top = CanMove.Top - 2;
        }

        void SetBitmapCanMoveWhenHaveChess(Bitmap image)
        {
            CanMove.Left = Col * 53 + 59;
            CanMove.Top = Row * 53 + 78;
            CanMove.Width = 46;
            CanMove.Height = 46;
            CanMove.Image = BitmapHaveChess(image);
        }
        Bitmap BitmapHaveChess(Bitmap image)
        {
            Bitmap rsl = new Bitmap(46, 46);
            using (Graphics graphics = Graphics.FromImage(rsl))
            {
                Rectangle rectangle1 = new Rectangle(2, 2, 42, 42);
                Rectangle rectangle2 = new Rectangle(new Point(9, 9), new Size(28, 28));
                Rectangle rectangle3 = new Rectangle(0, 0, 46, 46);
                graphics.DrawImage(CoTuong.Properties.Resources.have_chess, rectangle3);
                graphics.DrawImage(image, rectangle1);
                graphics.DrawImage(CoTuong.Properties.Resources.CanMove, rectangle2);
            }
            return rsl;
        }

        #endregion
    }
}
