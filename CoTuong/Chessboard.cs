using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoTuong
{
    class Chessboard
    {
        public static OCo[,] MangOco = new OCo[10, 9];
        public Chessboard()
        {
            //MangOco = new OCo[10, 9];
            LoadOco();
        }

        #region Methods
        public static void LoadOco()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    MangOco[i, j] = new OCo(i, j);
                    MangOco[i, j].CanMove.Tag = MangOco[i, j];
                    MangOco[i, j].Chess = loadCo(i, j);

                }
            }
        }



        public static void ResetCanMove()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    MangOco[i, j].CanMove.Visible = false;
                }
            }
        }

        #endregion

        #region Load cờ
        private static QuanCo loadCo(int i, int j)
        {
            QuanCo quanCo = null;
            loadQuanChot(i, j, ref quanCo);
            if (quanCo == null)
                loadQuanTuongSiMaXe(i, j, ref quanCo);
            if (quanCo == null)
                loadQuanPhao(i, j, ref quanCo);
            if (quanCo == null)
            {
                if (j == 4)
                {
                    if (i == 0)
                        quanCo = new Tuong(1, i, j);
                    else if (i == 9)
                        quanCo = new Tuong(2, i, j);
                }
            }
            return quanCo;
        }
        static void loadQuanChot(int i, int j, ref QuanCo quanCo)
        {
            quanCo = null;
            if (i == 3 && j % 2 == 0)
            {
                quanCo = new Chot(1, i, j);
            }
            if (i == 6 && j % 2 == 0)
            {
                quanCo = new Chot(2, i, j);
            }
        }
        static void loadQuanTuongSiMaXe(int i, int j, ref QuanCo quanCo)
        {
            quanCo = null;
            if (i == 0)
            {
                if (j == 3 || j == 5)
                {
                    quanCo = new Si(1, i, j);
                }
                if (j == 2 || j == 6)
                {
                    quanCo = new Tinh(1, i, j);
                }
                if (j == 1 || j == 7)
                {
                    quanCo = new Ma(1, i, j);
                }
                if (j == 0 || j == 8)
                {
                    quanCo = new Xe(1, i, j);
                }
            }
            if (i == 9)
            {
                if (j == 3 || j == 5)
                {
                    quanCo = new Si(2, i, j);
                }
                if (j == 2 || j == 6)
                {
                    quanCo = new Tinh(2, i, j);
                }
                if (j == 1 || j == 7)
                {
                    quanCo = new Ma(2, i, j);
                }
                if (j == 0 || j == 8)
                {
                    quanCo = new Xe(2, i, j);
                }
            }


        }
        static void loadQuanPhao(int i, int j, ref QuanCo quanCo)
        {
            quanCo = null;
            if (i == 2 && (j == 1 || j == 7))
            {
                quanCo = new Phao(1, i, j);
            }
            if (i == 7 && (j == 1 || j == 7))
            {
                quanCo = new Phao(2, i, j);
            }
        }



        #endregion

    }
}
