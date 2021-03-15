using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoTuong
{
    class Xe : QuanCo
    {
        public Xe(int phe, int hang, int cot) : base(hang, cot)
        {
            Phe = phe;
            LoaiQuan = 6;
            LoadPictureBoxAndDrawChess();

        }
        #region Methods
        public override void LoadPictureBoxAndDrawChess()
        {
            if (Phe == 1)
            {
                BitmapChess = CoTuong.Properties.Resources._1xe;
                BitmapChessMarked = CoTuong.Properties.Resources._1xe_marked;
                BitmapDieChess = CoTuong.Properties.Resources._1xe_bian;

            }
            else if (Phe == 2)
            {
                BitmapChess = CoTuong.Properties.Resources._2xe;
                BitmapChessMarked = CoTuong.Properties.Resources._2xe_marked;
                BitmapDieChess = CoTuong.Properties.Resources._2xe_bian;
            }

            DrawChess();
        }
        public override void OpenCanMove(OCo[,] oCo)
        {
            List<PictureBox> pictureboxs = new List<PictureBox>();
            int row = Row + 1;
            int col = Col;
            // dọc xuống
            while (row < 10)
            {
                int team = oCo[row, col].Phe;
                if (team == Phe)
                    break;
                if (team != Phe && team != 0)
                {
                    pictureboxs.Add(oCo[row, col].CanMove);
                    break;
                }
                pictureboxs.Add(oCo[row++, col].CanMove);
            }

            // dọc lên
            row = Row - 1;
            col = Col;


            while (row >= 0)
            {
                int team = oCo[row, col].Phe;
                if (team == Phe)
                    break;
                if (team != Phe && team != 0)
                {
                    pictureboxs.Add(oCo[row, col].CanMove);
                    break;
                }
                pictureboxs.Add(oCo[row--, col].CanMove);

            }

            // ngang trái
            row = Row;
            col = Col - 1;

            while (col >= 0)
            {
                int team = oCo[row, col].Phe;
                if (team == Phe)
                    break;
                if (team != Phe && team != 0)
                {
                    pictureboxs.Add(oCo[row, col].CanMove);
                    break;
                }
                pictureboxs.Add(oCo[row, col--].CanMove);
            }
            // ngang phai
            row = Row;
            col = Col + 1;

            while (col < 9)
            {
                int team = oCo[row, col].Phe;
                if (team == Phe)
                    break;
                if (team != Phe && team != 0)
                {
                    pictureboxs.Add(oCo[row, col].CanMove);
                    break;
                }
                pictureboxs.Add(oCo[row, col++].CanMove);

            }

            foreach (PictureBox item in pictureboxs)
            {
                item.Visible = true;
            }

        }

        public override bool IsCheckmate(OCo[,] oCo)
        {
            int row = Row + 1;
            int col = Col;

            // dọc xuống
            while (row < 10)
            {
                int team = oCo[row, col].Phe;
                if (team == Phe)
                    break;
                if (team != Phe && team != 0)
                {
                    if (oCo[row, col].LoaiCo == 7)
                        return true;
                    if (oCo[row, col].LoaiCo != 7 && oCo[row, col].LoaiCo != 0)
                        return false;
                }
                row++;
            }

            // dọc lên
            row = Row - 1;
            col = Col;

            while (row >= 0)
            {
                int team = oCo[row, col].Phe;
                if (team == Phe)
                    break;
                if (team != Phe && team != 0)
                {
                    if (oCo[row, col].LoaiCo == 7)
                        return true;
                    if (oCo[row, col].LoaiCo != 7 && oCo[row, col].LoaiCo != 0)
                        return false;
                }
                row--;
            }

            // ngang trái
            row = Row;
            col = Col - 1;

            while (col >= 0)
            {
                int team = oCo[row, col].Phe;
                if (team == Phe)
                    break;
                if (team != Phe && team != 0)
                {
                    if (oCo[row, col].LoaiCo == 7)
                        return true;
                    if (oCo[row, col].LoaiCo != 7 && oCo[row, col].LoaiCo != 0)
                        return false;
                }
                col--;
            }
            // ngang phai
            row = Row;
            col = Col + 1;

            while (col < 9)
            {
                int team = oCo[row, col].Phe;
                if (team == Phe)
                    break;
                if (team != Phe && team != 0)
                {
                    if (oCo[row, col].LoaiCo == 7)
                        return true;
                    if (oCo[row, col].LoaiCo != 7 && oCo[row, col].LoaiCo != 0)
                        return false;
                }
                col++;
            }
            return false;
        }

        public override List<IndexArray> GetListIndexCanMove(OCo[,] oCo)
        {
            List<IndexArray> indexArrays = new List<IndexArray>();
            int row = Row + 1;
            int col = Col;
            // dọc xuống
            while (row < 10)
            {
                int team = oCo[row, col].Phe;
                if (team == Phe)
                    break;
                if (team != Phe && team != 0)
                {
                    indexArrays.Add(new IndexArray(row, col));
                    break;
                }
                indexArrays.Add(new IndexArray(row, col));
                row++;
            }

            // dọc lên
            row = Row - 1;
            col = Col;


            while (row >= 0)
            {
                int team = oCo[row, col].Phe;
                if (team == Phe)
                    break;
                if (team != Phe && team != 0)
                {
                    indexArrays.Add(new IndexArray(row, col));
                    break;
                }
                indexArrays.Add(new IndexArray(row, col));
                row--;
            }

            // ngang trái
            row = Row;
            col = Col - 1;

            while (col >= 0)
            {
                int team = oCo[row, col].Phe;
                if (team == Phe)
                    break;
                if (team != Phe && team != 0)
                {
                    indexArrays.Add(new IndexArray(row, col));
                    break;
                }
                indexArrays.Add(new IndexArray(row, col));
                row--;
            }
            // ngang phai
            row = Row;
            col = Col + 1;

            while (col < 9)
            {
                int team = oCo[row, col].Phe;
                if (team == Phe)
                    break;
                if (team != Phe && team != 0)
                {
                    indexArrays.Add(new IndexArray(row, col));
                    break;
                }
                indexArrays.Add(new IndexArray(row, col));
                col++;

            }
            return indexArrays;
        }

        #endregion
    }
}
