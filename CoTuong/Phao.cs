using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoTuong
{
    class Phao : QuanCo
    {
        public Phao(int phe, int hang, int cot) : base(hang, cot)
        {
            Phe = phe;
            LoaiQuan = 5;
            LoadPictureBoxAndDrawChess();

        }
        #region Methods
        public override void LoadPictureBoxAndDrawChess()
        {
            if (Phe == 1)
            {
                BitmapChess = CoTuong.Properties.Resources._1phao;
                BitmapChessMarked = CoTuong.Properties.Resources._1phao_marked;
                BitmapDieChess = CoTuong.Properties.Resources._1phao_bian;
            }
            else if (Phe == 2)
            {
                BitmapChess = CoTuong.Properties.Resources._2phao;
                BitmapChessMarked = CoTuong.Properties.Resources._2phao_marked;
                BitmapDieChess = CoTuong.Properties.Resources._2phao_bian;
            }

            DrawChess();
        }

        public override void OpenCanMove(OCo[,] oCo)
        {
            List<PictureBox> pictureboxs = new List<PictureBox>();
            int row = Row + 1;
            int col = Col;
            bool open = true;
            int count = 0;
            // dọc xuống
            while (row < 10)
            {
                if (oCo[row, col].Phe != 0)
                {
                    open = !open;
                    count++;
                }
                if (open && oCo[row, col].Phe != Phe)
                {
                    pictureboxs.Add(oCo[row, col].CanMove);
                }
                if (count == 2)
                    break;
                row++;
            }

            // dọc lên
            row = Row - 1;
            col = Col;
            open = true;
            count = 0;
            while (row >= 0)
            {
                if (oCo[row, col].Phe != 0)//&& oCo[row, col].Phe != Phe)
                {
                    open = !open;
                    count++;
                }
                if (open && oCo[row, col].Phe != Phe)
                {
                    pictureboxs.Add(oCo[row, col].CanMove);
                }
                if (count == 2)
                    break;
                row--;
            }

            // ngang trái
            row = Row;
            col = Col - 1;
            open = true;
            count = 0;
            while (col >= 0)
            {
                if (oCo[row, col].Phe != 0)//&& oCo[row, col].Phe != Phe)
                {
                    open = !open;
                    count++;
                }
                if (open && oCo[row, col].Phe != Phe)
                {
                    pictureboxs.Add(oCo[row, col].CanMove);
                }
                if (count == 2)
                    break;
                col--;
            }
            // ngang phải
            row = Row;
            col = Col + 1;
            open = true;
            count = 0;
            while (col < 9)
            {
                if (oCo[row, col].Phe != 0)//&& oCo[row, col].Phe != Phe)
                {
                    open = !open;
                    count++;
                }
                if (open && oCo[row, col].Phe != Phe)
                {
                    pictureboxs.Add(oCo[row, col].CanMove);
                }
                if (count == 2)
                    break;
                col++;
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
            bool open = true;
            int count = 0;
            // dọc xuống
            while (row < 10)
            {
                if (oCo[row, col].Phe != 0)
                {
                    open = !open;
                    count++;
                }
                if (open && oCo[row, col].Phe != Phe)
                {
                    if (oCo[row, col].LoaiCo == 7)
                        return true;
                }
                if (count == 2)
                    break;
                row++;
            }

            // dọc lên
            row = Row - 1;
            col = Col;
            open = true;
            count = 0;
            while (row >= 0)
            {
                if (oCo[row, col].Phe != 0)//&& oCo[row, col].Phe != Phe)
                {
                    open = !open;
                    count++;
                }
                if (open && oCo[row, col].Phe != Phe)
                {
                    if (oCo[row, col].LoaiCo == 7)
                        return true;
                }
                if (count == 2)
                    break;
                row--;
            }

            // ngang trái
            row = Row;
            col = Col - 1;
            open = true;
            count = 0;
            while (col >= 0)
            {
                if (oCo[row, col].Phe != 0)//&& oCo[row, col].Phe != Phe)
                {
                    open = !open;
                    count++;
                }
                if (open && oCo[row, col].Phe != Phe)
                {
                    if (oCo[row, col].LoaiCo == 7)
                        return true;
                }
                if (count == 2)
                    break;
                col--;
            }
            // ngang phải
            row = Row;
            col = Col + 1;
            open = true;
            count = 0;
            while (col < 9)
            {
                if (oCo[row, col].Phe != 0)//&& oCo[row, col].Phe != Phe)
                {
                    open = !open;
                    count++;
                }
                if (open && oCo[row, col].Phe != Phe)
                {
                    if (oCo[row, col].LoaiCo == 7)
                        return true;
                }
                if (count == 2)
                    break;
                col++;
            }

            return false;
        }
        public override List<IndexArray> GetListIndexCanMove(OCo[,] oCo)
        {
            List<IndexArray> indexArrays = new List<IndexArray>();
            int row = Row + 1;
            int col = Col;
            bool open = true;
            int count = 0;
            // dọc xuống
            while (row < 10)
            {
                if (oCo[row, col].Phe != 0)
                {
                    open = !open;
                    count++;
                }
                if (open && oCo[row, col].Phe != Phe)
                {
                    indexArrays.Add(new IndexArray(row, col));
                }
                if (count == 2)
                    break;
                row++;
            }

            // dọc lên
            row = Row - 1;
            col = Col;
            open = true;
            count = 0;
            while (row >= 0)
            {
                if (oCo[row, col].Phe != 0)//&& oCo[row, col].Phe != Phe)
                {
                    open = !open;
                    count++;
                }
                if (open && oCo[row, col].Phe != Phe)
                {
                    indexArrays.Add(new IndexArray(row, col));
                }
                if (count == 2)
                    break;
                row--;
            }

            // ngang trái
            row = Row;
            col = Col - 1;
            open = true;
            count = 0;
            while (col >= 0)
            {
                if (oCo[row, col].Phe != 0)//&& oCo[row, col].Phe != Phe)
                {
                    open = !open;
                    count++;
                }
                if (open && oCo[row, col].Phe != Phe)
                {
                    indexArrays.Add(new IndexArray(row, col));
                }
                if (count == 2)
                    break;
                col--;
            }
            // ngang phải
            row = Row;
            col = Col + 1;
            open = true;
            count = 0;
            while (col < 9)
            {
                if (oCo[row, col].Phe != 0)//&& oCo[row, col].Phe != Phe)
                {
                    open = !open;
                    count++;
                }
                if (open && oCo[row, col].Phe != Phe)
                {
                    indexArrays.Add(new IndexArray(row, col));
                }
                if (count == 2)
                    break;
                col++;
            }

            return indexArrays;
        }
        #endregion
    }
}
