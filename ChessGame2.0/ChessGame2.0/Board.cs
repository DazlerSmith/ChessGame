using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace ChessGame2._0
{
    class Board
    {
        int size = 8;
        int hoffset = 200;
        int voffset = 50;

        public Square[,] Squares = new Square[8,8];

        public Board(Texture2D t)
        {
            Color colour = Color.AliceBlue;
            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    // determine colour
                    //Square temp = new Square(r, c, t, voffset, hoffset, colour);
                    Squares[r,c]= new Square(r, c, t, voffset, hoffset, colour);
                    if (colour == Color.AliceBlue && c < 7)
                        colour = Color.Silver;
                    else if (colour == Color.Silver && c < 7)
                        colour = Color.AliceBlue;


                }
            }
            //SetupBoard();
        }

        public void SetupBoard()
        {

        }

        public void Draw(SpriteBatch sb)
        {
            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {

                    Squares[r, c].Draw(sb);
                    


                }
            }
        }






    }
}
