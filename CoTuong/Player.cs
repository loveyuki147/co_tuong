using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoTuong
{
    class Player
    {
        string name;
        int phe;
        List<QuanCo> listChess;
        Tuong tuong;
        public string Name { get => name; set => name = value; }
        public int Phe { get => phe; set => phe = value; }
        internal List<QuanCo> ListChess { get => listChess; set => listChess = value; }
        internal Tuong Tuong { get => tuong; set => tuong = value; }

        public Player(int phe)
        {
            ListChess = new List<QuanCo>();
            Phe = phe;
            Name = "Player " + Phe;
        }
        void LoadChessForPlayer()
        {

        }
    }
}
