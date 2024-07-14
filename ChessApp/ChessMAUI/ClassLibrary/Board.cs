using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Board
    {

        private int sizex;
        private int sizey;
        private Pawn[,] pawns;

        public Pawn[,] Pawns{ get { return pawns; } set { pawns = value; }}
        public int sizeX { get { return sizex; } set { sizex = value; } }
        public int sizeY { get { return sizey; } set { sizey = value; } }
        private void insertPawn(int x, int y, Pawn pawn)
        {
            pawns[x,y] = pawn;
        }


        public void movePawn(int x, int y) { 
        
        }  
        
        public Board() {
            int y = 0;

            sizex = 7;
            sizex = 7;

            pawns = new Pawn[sizeX, sizeY];


            for (int x = 0; x < 7; x++)
            {
                insertPawn(int x, int y, );
            }
        }








    }
}
