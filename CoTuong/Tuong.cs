using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoTuong
{
    class Tuong : QuanCo
    {
        Bitmap bitmapChieuTuong;
        bool areCheckmate;
        public Bitmap BitmapChieuTuong { get => bitmapChieuTuong; set => bitmapChieuTuong = value; }
        public bool AreCheckmate
        {
            get => areCheckmate; set
            {
                areCheckmate = value;
                if (areCheckmate == true)
                    PtbChess.Image = BitmapChieuTuong;
                else
                    PtbChess.Image = BitmapChess;
            }
        }

        public Tuong(int phe, int hang, int cot) : base(hang, cot)
        {
            Phe = phe;
            LoaiQuan = 7;
            LoadPictureBoxAndDrawChess();
            areCheckmate = false;
        }
        #region Methods
        public override void LoadPictureBoxAndDrawChess()
        {
            if (Phe == 1)
            {
                BitmapChess = CoTuong.Properties.Resources._1tuong;
                BitmapChessMarked = CoTuong.Properties.Resources._1tuong_marked;
                BitmapChieuTuong = CoTuong.Properties.Resources._1tuong_bichieu;
            }
            else if (Phe == 2)
            {
                BitmapChess = CoTuong.Properties.Resources._2tuong;
                BitmapChessMarked = CoTuong.Properties.Resources._2tuong_marked;
                BitmapChieuTuong = CoTuong.Properties.Resources._2tuong_bichieu;
            }

            DrawChess();
        }
        public override void OpenCanMove(OCo[,] oCo)
        {

            List<PictureBox> pictureboxs = new List<PictureBox>();
            if (Phe == 1)
            {
                if (Row + 1 < 3 && oCo[Row + 1, Col].Phe != Phe)
                    pictureboxs.Add(oCo[Row + 1, Col].CanMove);

                if (Row - 1 >= 0 && oCo[Row - 1, Col].Phe != Phe)
                    pictureboxs.Add(oCo[Row - 1, Col].CanMove);

                if (Col + 1 < 6 && oCo[Row, Col + 1].Phe != Phe)
                    pictureboxs.Add(oCo[Row, Col + 1].CanMove);

                if (Col - 1 >= 3 && oCo[Row, Col - 1].Phe != Phe)
                    pictureboxs.Add(oCo[Row, Col - 1].CanMove);
            }
            else if (Phe == 2)
            {
                if (Row + 1 < 10 && oCo[Row + 1, Col].Phe != Phe)
                    pictureboxs.Add(oCo[Row + 1, Col].CanMove);

                if (Row - 1 >= 7 && oCo[Row - 1, Col].Phe != Phe)
                    pictureboxs.Add(oCo[Row - 1, Col].CanMove);

                if (Col + 1 < 6 && oCo[Row, Col + 1].Phe != Phe)
                    pictureboxs.Add(oCo[Row, Col + 1].CanMove);

                if (Col - 1 >= 3 && oCo[Row, Col - 1].Phe != Phe)
                    pictureboxs.Add(oCo[Row, Col - 1].CanMove);
            }

            foreach (PictureBox item in pictureboxs)
            {
                item.Visible = true;
            }

        }

        public override bool IsCheckmate(OCo[,] oCo)
        {
            int row = 0;
            if (Phe == 1)
            {
                row = Row + 1;

                while (row < 10)
                {
                    if (oCo[row, Col].LoaiCo == 7)
                        return true;
                    if (oCo[row, Col].LoaiCo != 0)
                        return false;
                    row++;
                }
            }
            else if (Phe == 2)
            {
                row = Row - 1;
                while (row >= 0)
                {
                    if (oCo[row, Col].LoaiCo == 7)
                        return true;
                    if (oCo[row, Col].LoaiCo != 0)
                        return false;
                    row--;
                }
            }

            return false;
        }

        public override List<IndexArray> GetListIndexCanMove(OCo[,] oCo)
        {
            List<IndexArray> indexArrays = new List<IndexArray>();
            if (Phe == 1)
            {
                if (Row + 1 < 3 && oCo[Row + 1, Col].Phe != Phe)
                    indexArrays.Add(new IndexArray(Row + 1, Col));

                if (Row - 1 >= 0 && oCo[Row - 1, Col].Phe != Phe)
                    indexArrays.Add(new IndexArray(Row - 1, Col));

                if (Col + 1 < 6 && oCo[Row, Col + 1].Phe != Phe)
                    indexArrays.Add(new IndexArray(Row, Col + 1));

                if (Col - 1 >= 3 && oCo[Row, Col - 1].Phe != Phe)
                    indexArrays.Add(new IndexArray(Row, Col - 1));
            }
            else if (Phe == 2)
            {
                if (Row + 1 < 10 && oCo[Row + 1, Col].Phe != Phe)
                    indexArrays.Add(new IndexArray(Row + 1, Col));

                if (Row - 1 >= 7 && oCo[Row - 1, Col].Phe != Phe)
                    indexArrays.Add(new IndexArray(Row - 1, Col));

                if (Col + 1 < 6 && oCo[Row, Col + 1].Phe != Phe)
                    indexArrays.Add(new IndexArray(Row, Col + 1));

                if (Col - 1 >= 3 && oCo[Row, Col - 1].Phe != Phe)
                    indexArrays.Add(new IndexArray(Row, Col - 1));
            }

            return indexArrays;
        }
        #endregion
    }
}
