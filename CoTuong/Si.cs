using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoTuong
{
    class Si : QuanCo
    {
        public Si(int phe, int hang, int cot) : base(hang, cot)
        {
            Phe = phe;
            LoaiQuan = 2;
            LoadPictureBoxAndDrawChess();

        }
        #region Methods
        public override void LoadPictureBoxAndDrawChess()
        {
            if (Phe == 1)
            {
                BitmapChess = CoTuong.Properties.Resources._1sy;
                BitmapChessMarked = CoTuong.Properties.Resources._1sy_marked;
                BitmapDieChess = CoTuong.Properties.Resources._1sy_bian;
            }
            else if (Phe == 2)
            {
                BitmapChess = CoTuong.Properties.Resources._2sy;
                BitmapChessMarked = CoTuong.Properties.Resources._2sy_marked;
                BitmapDieChess = CoTuong.Properties.Resources._2sy_bian;
            }

            DrawChess();
        }

        public override bool CheckCanMoveTest(int i, int j)
        {

            if (Phe == 1)
            {
                if (j > 5 || j < 3 || i > 2)
                    return false;
                if (Row == 0)
                {
                    if (j != 4 || i != 1)
                        return false;
                }
                else if (Row == 1)
                {
                    if ((i != 0 && i != 2) || j == 4)
                        return false;
                }
                else if (Row == 2)
                {
                    if (i != 1 || j != 4)
                        return false;
                }
            }
            else if (Phe == 2)
            {
                if (j > 5 || j < 3 || i < 7)
                    return false;
                if (Row == 9)
                {
                    if (j != 4 || i != 8)
                        return false;
                }
                else if (Row == 8)
                {
                    if ((i != 9 && i != 7) || j == 4)
                        return false;
                }
                else if (Row == 7)
                {
                    if (i != 8 || j != 4)
                        return false;

                }
            }
            if (Chessboard.MangOco[i, j].Phe == Phe)
                return false;

            return true;
        }
        public override void OpenCanMove(OCo[,] oCo)
        {
            List<PictureBox> pictureboxs = new List<PictureBox>();
            if (Phe == 1)
            {
                if (Row + 1 < 3 && Col + 1 <= 5)
                {
                    if (oCo[Row + 1, Col + 1].Phe != Phe)
                        pictureboxs.Add(oCo[Row + 1, Col + 1].CanMove);
                }
                if (Row + 1 < 3 && Col - 1 >= 3)
                {
                    if (oCo[Row + 1, Col - 1].Phe != Phe)
                        pictureboxs.Add(oCo[Row + 1, Col - 1].CanMove);
                }
                if (Row - 1 >= 0 && Col - 1 >= 3)
                {
                    if (oCo[Row - 1, Col - 1].Phe != Phe)
                        pictureboxs.Add(oCo[Row - 1, Col - 1].CanMove);
                }
                if (Row - 1 >= 0 && Col + 1 <= 5)
                {
                    if (oCo[Row - 1, Col + 1].Phe != Phe)
                        pictureboxs.Add(oCo[Row - 1, Col + 1].CanMove);
                }
            }
            //--------------------------
            else if (Phe == 2)
            {
                if (Row + 1 < 10 && Col + 1 <= 5)
                {
                    if (oCo[Row + 1, Col + 1].Phe != Phe)
                        pictureboxs.Add(oCo[Row + 1, Col + 1].CanMove);
                }
                if (Row + 1 < 10 && Col - 1 >= 3)
                {
                    if (oCo[Row + 1, Col - 1].Phe != Phe)
                        pictureboxs.Add(oCo[Row + 1, Col - 1].CanMove);
                }
                if (Row - 1 >= 7 && Col - 1 >= 3)
                {
                    if (oCo[Row - 1, Col - 1].Phe != Phe)
                        pictureboxs.Add(oCo[Row - 1, Col - 1].CanMove);
                }
                if (Row - 1 >= 7 && Col + 1 <= 5)
                {
                    if (oCo[Row - 1, Col + 1].Phe != Phe)
                        pictureboxs.Add(oCo[Row - 1, Col + 1].CanMove);
                }
            }
            foreach (PictureBox item in pictureboxs)
            {
                item.Visible = true;
            }

        }
        #endregion
        public override List<IndexArray> GetListIndexCanMove(OCo[,] oCo)
        {
            List<IndexArray> indexArrays = new List<IndexArray>();
            if (Phe == 1)
            {
                if (Row + 1 < 3 && Col + 1 <= 5)
                {
                    if (oCo[Row + 1, Col + 1].Phe != Phe)
                        indexArrays.Add(new IndexArray(Row + 1, Col + 1));
                }
                if (Row + 1 < 3 && Col - 1 >= 3)
                {
                    if (oCo[Row + 1, Col - 1].Phe != Phe)
                        indexArrays.Add(new IndexArray(Row + 1, Col - 1));
                }
                if (Row - 1 >= 0 && Col - 1 >= 3)
                {
                    if (oCo[Row - 1, Col - 1].Phe != Phe)
                        indexArrays.Add(new IndexArray(Row - 1, Col - 1));
                }
                if (Row - 1 >= 0 && Col + 1 <= 5)
                {
                    if (oCo[Row - 1, Col + 1].Phe != Phe)
                        indexArrays.Add(new IndexArray(Row - 1, Col + 1));
                }
            }
            //--------------------------
            else if (Phe == 2)
            {
                if (Row + 1 < 10 && Col + 1 <= 5)
                {
                    if (oCo[Row + 1, Col + 1].Phe != Phe)
                        indexArrays.Add(new IndexArray(Row + 1, Col + 1));
                }
                if (Row + 1 < 10 && Col - 1 >= 3)
                {
                    if (oCo[Row + 1, Col - 1].Phe != Phe)
                        indexArrays.Add(new IndexArray(Row + 1, Col - 1));
                }
                if (Row - 1 >= 7 && Col - 1 >= 3)
                {
                    if (oCo[Row - 1, Col - 1].Phe != Phe)
                        indexArrays.Add(new IndexArray(Row - 1, Col - 1));
                }
                if (Row - 1 >= 7 && Col + 1 <= 5)
                {
                    if (oCo[Row - 1, Col + 1].Phe != Phe)
                        indexArrays.Add(new IndexArray(Row - 1, Col + 1));
                }
            }

            return indexArrays;
        }
    }
}
