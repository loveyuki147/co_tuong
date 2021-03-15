using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoTuong
{
    class Ma : QuanCo
    {
        public Ma(int phe, int hang, int cot) : base(hang, cot)
        {
            Phe = phe;
            LoaiQuan = 4;
            LoadPictureBoxAndDrawChess();

        }

        public override bool CheckCanMoveTest(int i, int j)
        {
            return base.CheckCanMoveTest(i, j);
        }

        #region Methods
        public override void LoadPictureBoxAndDrawChess()
        {
            if (Phe == 1)
            {
                BitmapChess = CoTuong.Properties.Resources._1ma;
                BitmapChessMarked = CoTuong.Properties.Resources._1ma_marked;
                BitmapDieChess = CoTuong.Properties.Resources._1ma_bian;
            }
            else if (Phe == 2)
            {
                BitmapChess = CoTuong.Properties.Resources._2ma;
                BitmapChessMarked = CoTuong.Properties.Resources._2ma_marked;
                BitmapDieChess = CoTuong.Properties.Resources._2ma_bian;
            }

            DrawChess();
        }

        public override void OpenCanMove(OCo[,] oCo)
        {
            List<PictureBox> pictureboxs = new List<PictureBox>();
            int row = Row + 2;
            int col = Col + 1;
            // góc 1
            if (row < 10 && col < 9)
            {
                if (oCo[row, col].Phe != Phe && oCo[Row + 1, Col].Phe == 0)
                    pictureboxs.Add(oCo[row, col].CanMove);
            }

            // góc 2
            col = Col - 1;
            row = Row + 2;
            if (row < 10 && col >= 0)
            {
                if (oCo[row, col].Phe != Phe && oCo[Row + 1, Col].Phe == 0)
                    pictureboxs.Add(oCo[row, col].CanMove);
            }

            // góc 3
            row = Row - 2;
            col = Col + 1;
            if (row >= 0 && col < 9)
            {
                if (oCo[row, col].Phe != Phe && oCo[Row - 1, Col].Phe == 0)
                    pictureboxs.Add(oCo[row, col].CanMove);

            }

            // góc 4
            row = Row - 2;
            col = Col - 1;
            if (row >= 0 && col >= 0)
            {
                if (oCo[row, col].Phe != Phe && oCo[Row - 1, Col].Phe == 0)
                    pictureboxs.Add(oCo[row, col].CanMove);
            }

            // góc 5
            row = Row + 1;
            col = Col + 2;
            if (row < 10 && col < 9)
            {
                if (oCo[row, col].Phe != Phe && oCo[Row, Col + 1].Phe == 0)
                    pictureboxs.Add(oCo[row, col].CanMove);
            }

            // góc 6
            row = Row - 1;
            col = Col + 2;
            if (row >= 0 && col < 9)
            {
                if (oCo[row, col].Phe != Phe && oCo[Row, Col + 1].Phe == 0)
                    pictureboxs.Add(oCo[row, col].CanMove);
            }

            // góc 7
            row = Row + 1;
            col = Col - 2;
            if (row < 10 && col >= 0)
            {
                if (oCo[row, col].Phe != Phe && oCo[Row, Col - 1].Phe == 0)
                    pictureboxs.Add(oCo[row, col].CanMove);
            }

            // góc 8
            row = Row - 1;
            col = Col - 2;
            if (row >= 0 && col >= 0)
            {
                if (oCo[row, col].Phe != Phe && oCo[Row, Col - 1].Phe == 0)
                    pictureboxs.Add(oCo[row, col].CanMove);
            }

            foreach (PictureBox item in pictureboxs)
            {
                item.Visible = true;
            }
        }

        public override bool IsCheckmate(OCo[,] oCo)
        {
            if (Phe == 1 && Row <= 4)
            {
                return false;
            }
            else if (Phe == 2 && Row > 4)
                return false;
            int row = Row + 2;
            int col = Col + 1;
            // góc 1
            if (row < 10 && col < 9)
            {
                if (oCo[row, col].Phe != Phe && oCo[Row + 1, Col].Phe == 0)
                    if (oCo[row, col].LoaiCo == 7)
                        return true;
            }

            // góc 2
            col = Col - 1;
            row = Row + 2;
            if (row < 10 && col >= 0)
            {
                if (oCo[row, col].Phe != Phe && oCo[Row + 1, Col].Phe == 0)
                    if (oCo[row, col].LoaiCo == 7)
                        return true;
            }

            // góc 3
            row = Row - 2;
            col = Col + 1;
            if (row >= 0 && col < 9)
            {
                if (oCo[row, col].Phe != Phe && oCo[Row - 1, Col].Phe == 0)
                    if (oCo[row, col].LoaiCo == 7)
                        return true;

            }

            // góc 4
            row = Row - 2;
            col = Col - 1;
            if (row >= 0 && col >= 0)
            {
                if (oCo[row, col].Phe != Phe && oCo[Row - 1, Col].Phe == 0)
                    if (oCo[row, col].LoaiCo == 7)
                        return true;
            }

            // góc 5
            row = Row + 1;
            col = Col + 2;
            if (row < 10 && col < 9)
            {
                if (oCo[row, col].Phe != Phe && oCo[Row, Col + 1].Phe == 0)
                    if (oCo[row, col].LoaiCo == 7)
                        return true;
            }

            // góc 6
            row = Row - 1;
            col = Col + 2;
            if (row >= 0 && col < 9)
            {
                if (oCo[row, col].Phe != Phe && oCo[Row, Col + 1].Phe == 0)
                    if (oCo[row, col].LoaiCo == 7)
                        return true;
            }

            // góc 7
            row = Row + 1;
            col = Col - 2;
            if (row < 10 && col >= 0)
            {
                if (oCo[row, col].Phe != Phe && oCo[Row, Col - 1].Phe == 0)
                    if (oCo[row, col].LoaiCo == 7)
                        return true;
            }

            // góc 8
            row = Row - 1;
            col = Col - 2;
            if (row >= 0 && col >= 0)
            {
                if (oCo[row, col].Phe != Phe && oCo[Row, Col - 1].Phe == 0)
                    if (oCo[row, col].LoaiCo == 7)
                        return true;
            }

            return false;
        }

        public override List<IndexArray> GetListIndexCanMove(OCo[,] oCo)
        {
            List<IndexArray> indexArrays = new List<IndexArray>();
            int row = Row + 2;
            int col = Col + 1;
            // góc 1
            if (row < 10 && col < 9)
            {
                if (oCo[row, col].Phe != Phe && oCo[Row + 1, Col].Phe == 0)
                    indexArrays.Add(new IndexArray(row, col));
            }

            // góc 2
            col = Col - 1;
            row = Row + 2;
            if (row < 10 && col >= 0)
            {
                if (oCo[row, col].Phe != Phe && oCo[Row + 1, Col].Phe == 0)
                    indexArrays.Add(new IndexArray(row, col));
            }

            // góc 3
            row = Row - 2;
            col = Col + 1;
            if (row >= 0 && col < 9)
            {
                if (oCo[row, col].Phe != Phe && oCo[Row - 1, Col].Phe == 0)
                    indexArrays.Add(new IndexArray(row, col));

            }

            // góc 4
            row = Row - 2;
            col = Col - 1;
            if (row >= 0 && col >= 0)
            {
                if (oCo[row, col].Phe != Phe && oCo[Row - 1, Col].Phe == 0)
                    indexArrays.Add(new IndexArray(row, col));
            }

            // góc 5
            row = Row + 1;
            col = Col + 2;
            if (row < 10 && col < 9)
            {
                if (oCo[row, col].Phe != Phe && oCo[Row, Col + 1].Phe == 0)
                    indexArrays.Add(new IndexArray(row, col));
            }

            // góc 6
            row = Row - 1;
            col = Col + 2;
            if (row >= 0 && col < 9)
            {
                if (oCo[row, col].Phe != Phe && oCo[Row, Col + 1].Phe == 0)
                    indexArrays.Add(new IndexArray(row, col));
            }

            // góc 7
            row = Row + 1;
            col = Col - 2;
            if (row < 10 && col >= 0)
            {
                if (oCo[row, col].Phe != Phe && oCo[Row, Col - 1].Phe == 0)
                    indexArrays.Add(new IndexArray(row, col));
            }

            // góc 8
            row = Row - 1;
            col = Col - 2;
            if (row >= 0 && col >= 0)
            {
                if (oCo[row, col].Phe != Phe && oCo[Row, Col - 1].Phe == 0)
                    indexArrays.Add(new IndexArray(row, col));
            }


            return indexArrays;
        }
        #endregion
    }
}
