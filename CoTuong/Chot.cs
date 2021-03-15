using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoTuong
{
    class Chot : QuanCo
    {
        public Chot(int phe, int hang, int cot) : base(hang, cot)
        {
            Phe = phe;
            LoaiQuan = 1;
            LoadPictureBoxAndDrawChess();

        }
        #region Methods
        public override void LoadPictureBoxAndDrawChess()
        {
            if (Phe == 1)
            {
                BitmapChess = CoTuong.Properties.Resources._1chot;
                BitmapChessMarked = CoTuong.Properties.Resources._1chot_marked;
                BitmapDieChess = CoTuong.Properties.Resources._1chot_bian;
            }
            else if (Phe == 2)
            {
                BitmapChess = CoTuong.Properties.Resources._2chot;
                BitmapChessMarked = CoTuong.Properties.Resources._2chot_marked;
                BitmapDieChess = CoTuong.Properties.Resources._2chot_bian;
            }
            DrawChess();
        }

        public override bool CheckCanMoveTest(int i, int j)
        {
            if (Phe == 1)
            {
                if (i <= 3)
                    return false;
                if (Row <= 4)
                {
                    if (j != Col)
                        return false;
                    if (i != Row + 1 || Row + 1 > 9)
                        return false;
                }
                else if (Row > 4)
                {
                    if (Row == i)
                    {
                        if ((j != Col + 1 || Col + 1 > 8) && (j != Col - 1 || Col - 1 < 0))
                            return false;
                    }
                    else if ((i != Row + 1 || Row + 1 > 9) || j != Col)
                        return false;
                }
                if (Chessboard.MangOco[i, j].Phe == Phe)
                {
                    return false;
                }
            }
            else if (Phe == 2)
            {
                if (i >= 6)
                    return false;
                if (Row >= 5)
                {
                    if (j != Col)
                        return false;
                    if (i != Row - 1 || Row - 1 < 0)
                        return false;
                }
                else if (Row < 5)
                {
                    if (Row == i)
                    {
                        if ((j != Col - 1 || Col - 1 < 0) && (j != Col + 1 || Col + 1 > 8))
                            return false;
                    }
                    else if ((i != Row - 1 || Row - 1 < 0) || j != Col)
                        return false;

                }
                if (Chessboard.MangOco[i, j].Phe == Phe)
                {
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
                if (Row <= 4)
                {
                    if (Row + 1 < 10 && oCo[Row + 1, Col].Phe != Phe)
                        pictureboxs.Add(oCo[Row + 1, Col].CanMove);
                }
                else if (Row > 4)
                {
                    if (Row + 1 < 10 && oCo[Row + 1, Col].Phe != Phe)
                        pictureboxs.Add(oCo[Row + 1, Col].CanMove);

                    if (Col + 1 < 9 && oCo[Row, Col + 1].Phe != Phe)
                        pictureboxs.Add(oCo[Row, Col + 1].CanMove);

                    if (Col - 1 >= 0 && oCo[Row, Col - 1].Phe != Phe)
                        pictureboxs.Add(oCo[Row, Col - 1].CanMove);
                }
            }
            if (Phe == 2)
            {
                if (Row > 4)
                {
                    if (Row - 1 >= 0 && oCo[Row - 1, Col].Phe != Phe)
                        pictureboxs.Add(oCo[Row - 1, Col].CanMove);
                }
                else if (Row <= 4)
                {
                    if (Row - 1 >= 0 && oCo[Row - 1, Col].Phe != Phe)
                        pictureboxs.Add(oCo[Row - 1, Col].CanMove);

                    if (Col + 1 < 9 && oCo[Row, Col + 1].Phe != Phe)
                        pictureboxs.Add(oCo[Row, Col + 1].CanMove);

                    if (Col - 1 >= 0 && oCo[Row, Col - 1].Phe != Phe)
                        pictureboxs.Add(oCo[Row, Col - 1].CanMove);
                }

            }

            foreach (PictureBox item in pictureboxs)
            {
                item.Visible = true;
            }

        }

        public override bool IsCheckmate(OCo[,] oCo)
        {
            if (Phe == 1)
            {
                if (Row < 7)
                    return false;
                if (Row <= 4)
                {
                    if (Row + 1 < 10 && oCo[Row + 1, Col].Phe != Phe)
                        if (oCo[Row + 1, Col].LoaiCo == 7)
                            return true;
                }
                else if (Row > 4)
                {
                    if (Row + 1 < 10 && oCo[Row + 1, Col].Phe != Phe)
                        if (oCo[Row + 1, Col].LoaiCo == 7)
                            return true;

                    if (Col + 1 < 9 && oCo[Row, Col + 1].Phe != Phe)
                        if (oCo[Row, Col + 1].LoaiCo == 7)
                            return true;

                    if (Col - 1 >= 0 && oCo[Row, Col - 1].Phe != Phe)
                        if (oCo[Row, Col - 1].LoaiCo == 7)
                            return true;
                }
            }
            if (Phe == 2)
            {
                if (Row > 2)
                    return false;
                if (Row > 4)
                {
                    if (Row - 1 >= 0 && oCo[Row - 1, Col].Phe != Phe)
                        if (oCo[Row - 1, Col].LoaiCo == 7)
                            return true;
                }
                else if (Row <= 4)
                {
                    if (Row - 1 >= 0 && oCo[Row - 1, Col].Phe != Phe)
                        if (oCo[Row - 1, Col].LoaiCo == 7)
                            return true;

                    if (Col + 1 < 9 && oCo[Row, Col + 1].Phe != Phe)
                        if (oCo[Row, Col + 1].LoaiCo == 7)
                            return true;

                    if (Col - 1 >= 0 && oCo[Row, Col - 1].Phe != Phe)
                        if (oCo[Row, Col - 1].LoaiCo == 7)
                            return true;
                }

            }

            return false;
        }

        public override List<IndexArray> GetListIndexCanMove(OCo[,] oCo)
        {
            List<IndexArray> indexArrays = new List<IndexArray>();
            if (Phe == 1)
            {
                if (Row <= 4)
                {
                    if (Row + 1 < 10 && oCo[Row + 1, Col].Phe != Phe)
                        indexArrays.Add(new IndexArray(Row + 1, Col));
                }
                else if (Row > 4)
                {
                    if (Row + 1 < 10 && oCo[Row + 1, Col].Phe != Phe)
                        indexArrays.Add(new IndexArray(Row + 1, Col));

                    if (Col + 1 < 9 && oCo[Row, Col + 1].Phe != Phe)
                        indexArrays.Add(new IndexArray(Row, Col + 1)); ;

                    if (Col - 1 >= 0 && oCo[Row, Col - 1].Phe != Phe)
                        indexArrays.Add(new IndexArray(Row, Col - 1));
                }
            }
            if (Phe == 2)
            {
                if (Row > 4)
                {
                    if (Row - 1 >= 0 && oCo[Row - 1, Col].Phe != Phe)
                        indexArrays.Add(new IndexArray(Row - 1, Col));
                }
                else if (Row <= 4)
                {
                    if (Row - 1 >= 0 && oCo[Row - 1, Col].Phe != Phe)
                        indexArrays.Add(new IndexArray(Row - 1, Col));

                    if (Col + 1 < 9 && oCo[Row, Col + 1].Phe != Phe)
                        indexArrays.Add(new IndexArray(Row, Col + 1));

                    if (Col - 1 >= 0 && oCo[Row, Col - 1].Phe != Phe)
                        indexArrays.Add(new IndexArray(Row, Col - 1));
                }

            }


            return indexArrays;
        }
        #endregion
    }
}
