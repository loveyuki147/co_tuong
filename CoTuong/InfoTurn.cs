using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoTuong
{
    class InfoTurn
    {
        QuanCo chess;
        QuanCo chessBeenEating;
        OCo oCo;
        int turn;

        internal QuanCo Chess { get => chess; set => chess = value; }
        internal OCo OCo { get => oCo; set => oCo = value; }
        internal QuanCo ChessBeenEating { get => chessBeenEating; set => chessBeenEating = value; }
        public int Turn { get => turn; set => turn = value; }

        public InfoTurn(QuanCo chess, OCo oCo, QuanCo chessEat)
        {
            Chess = chess;
            ChessBeenEating = chessEat;
            OCo = oCo;
            if (Chess != null)
                Turn = Chess.Phe;
        }
    }
}
