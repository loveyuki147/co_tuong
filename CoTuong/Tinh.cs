using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoTuong
{
    class Tinh : QuanCo
    {
        public Tinh(int phe, int hang, int cot) : base(hang, cot)
        {
            Phe = phe;
            LoaiQuan = 3;
            LoadPictureBoxAndDrawChess();

        }
        #region Methods
        public override void LoadPictureBoxAndDrawChess()
        {
            if (Phe == 1)
            {
                BitmapChess = CoTuong.Properties.Resources._1tinh;
                BitmapChessMarked = CoTuong.Properties.Resources._1tinh_marked;
                BitmapDieChess = CoTuong.Properties.Resources._1tinh_bian;
            }
            else if (Phe == 2)
            {
                BitmapChess = CoTuong.Properties.Resources._2tinh;
                BitmapChessMarked = CoTuong.Properties.Resources._2tinh_marked;
                BitmapDieChess = CoTuong.Properties.Resources._2tinh_bian;
            }

            DrawChess();
        }

        public override bool CheckCanMoveTest(int i, int j)
        {
            if (Chessboard.MangOco[i, j].Phe == Phe)
                return false;
            if (Phe == 1)
            {
                if (i > 4)
                    return false;
                if (Row == 0)
                {
                    if (i != 2 || (j != Col + 2 && j != Col - 2))
                        return false;
                }
                else if (Row == 2)
                {
                    if ((i != 4 && i != 0) || (j != Col + 2 && j != Col - 2))
                        return false;
                }
                else if (Row == 4)
                {
                    if ((i != 2) || (j != Col + 2 && j != Col - 2))
                        return false;
                }
            }
            else if (Phe == 2)
            {

                if (i < 5)
                    return false;
                if (Row == 9)
                {
                    if (i != 7 || (j != Col + 2 && j != Col - 2))
                        return false;
                }
                else if (Row == 7)
                {
                    if ((i != 5 && i != 9) || (j != Col + 2 && j != Col - 2))
                        return false;
                }
                else if (Row == 5)
                {
                    if ((i != 7) || (j != Col + 2 && j != Col - 2))
                        return false;
                }
            }


            return true;
        }

        public override void OpenCanMove(OCo[,] oCo)
        {
            List<PictureBox> pictureboxs = new List<PictureBox>();
            if (Phe == 1)
            {
                if (Row + 2 <= 4 && Col + 2 < 9)
                {
                    if (oCo[Row + 2, Col + 2].Phe != Phe)
                        pictureboxs.Add(oCo[Row + 2, Col + 2].CanMove);
                }
                if (Row + 2 <= 4 && Col - 2 >= 0)
                {
                    if (oCo[Row + 2, Col - 2].Phe != Phe)
                        pictureboxs.Add(oCo[Row + 2, Col - 2].CanMove);
                }
                if (Row - 2 >= 0 && Col - 2 >= 0)
                {
                    if (oCo[Row - 2, Col - 2].Phe != Phe)
                        pictureboxs.Add(oCo[Row - 2, Col - 2].CanMove);
                }
                if (Row - 2 >= 0 && Col + 2 < 9)
                {
                    if (oCo[Row - 2, Col + 2].Phe != Phe)
                        pictureboxs.Add(oCo[Row - 2, Col + 2].CanMove);
                }
            }
            else if (Phe == 2)
            {
                if (Row + 2 < 10 && Col + 2 < 9)
                {
                    if (oCo[Row + 2, Col + 2].Phe != Phe)
                        pictureboxs.Add(oCo[Row + 2, Col + 2].CanMove);
                }
                if (Row + 2 < 10 && Col - 2 >= 0)
                {
                    if (oCo[Row + 2, Col - 2].Phe != Phe)
                        pictureboxs.Add(oCo[Row + 2, Col - 2].CanMove);
                }
                if (Row - 2 >= 5 && Col - 2 >= 0)
                {
                    if (oCo[Row - 2, Col - 2].Phe != Phe)
                        pictureboxs.Add(oCo[Row - 2, Col - 2].CanMove);
                }
                if (Row - 2 >= 5 && Col + 2 < 9)
                {
                    if (oCo[Row - 2, Col + 2].Phe != Phe)
                        pictureboxs.Add(oCo[Row - 2, Col + 2].CanMove);
                }
            }
            foreach (PictureBox item in pictureboxs)
            {
                item.Visible = true;
            }

        }

        public override List<IndexArray> GetListIndexCanMove(OCo[,] oCo)
        {
            List<IndexArray> indexArrays = new List<IndexArray>();
            if (Phe == 1)
            {
                if (Row + 2 <= 4 && Col + 2 < 9)
                {
                    if (oCo[Row + 2, Col + 2].Phe != Phe)
                        indexArrays.Add(new IndexArray(Row + 2, Col + 2));
                }
                if (Row + 2 <= 4 && Col - 2 >= 0)
                {
                    if (oCo[Row + 2, Col - 2].Phe != Phe)
                        indexArrays.Add(new IndexArray(Row + 2, Col - 2));
                }
                if (Row - 2 >= 0 && Col - 2 >= 0)
                {
                    if (oCo[Row - 2, Col - 2].Phe != Phe)
                        indexArrays.Add(new IndexArray(Row - 2, Col - 2));
                }
                if (Row - 2 >= 0 && Col + 2 < 9)
                {
                    if (oCo[Row - 2, Col + 2].Phe != Phe)
                        indexArrays.Add(new IndexArray(Row - 2, Col + 2));
                }
            }
            else if (Phe == 2)
            {
                if (Row + 2 < 10 && Col + 2 < 9)
                {
                    if (oCo[Row + 2, Col + 2].Phe != Phe)
                        indexArrays.Add(new IndexArray(Row + 2, Col + 2));
                }
                if (Row + 2 < 10 && Col - 2 >= 0)
                {
                    if (oCo[Row + 2, Col - 2].Phe != Phe)
                        indexArrays.Add(new IndexArray(Row + 2, Col - 2));
                }
                if (Row - 2 >= 5 && Col - 2 >= 0)
                {
                    if (oCo[Row - 2, Col - 2].Phe != Phe)
                        indexArrays.Add(new IndexArray(Row - 2, Col - 2));
                }
                if (Row - 2 >= 5 && Col + 2 < 9)
                {
                    if (oCo[Row - 2, Col + 2].Phe != Phe)
                        indexArrays.Add(new IndexArray(Row - 2, Col + 2));
                }
            }

            return indexArrays;
        }
        #endregion

    }
}
