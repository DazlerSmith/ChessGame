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
        Piece Selected = null;

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

        public void Unselect()
        {
            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    if (Squares[r, c].OnSquare != null)
                    {
                        Squares[r, c].OnSquare.IsSelected = false;
                        Squares[r, c].IsSelected = false;
                    }


                }
            }
            Selected = null;
        }

        //Mouse Input
        public void ClickBoard(int X, int Y)
        {
            Y = Y - 50;
            X = X - 200;   

            X = X / 50;
            Y = Y / 50;
            if (X >= 0 && X <= 7 && Y >= 0 && Y <= 7)
            {
                if (Selected != null)
                {

                }
                else
                {
                    Unselect();
                    if (Squares[Y, X].OnSquare != null)
                    {
                        Squares[Y, X].IsSelected = true;
                        Squares[Y, X].OnSquare.IsSelected = true;
                        Selected = Squares[Y, X].OnSquare;
                        Console.WriteLine("Piece Selected " + X + Y);
                    }
                }
                Console.WriteLine(X + " " + Y + " ");
            }
            else
                Unselect();
           
        }

        /*public bool LeftButtonReleased()
        {
            if (Mouse.GetState().LeftButton == ButtonState.Released && Mouse.GetState().LeftButton != ButtonState.Pressed)
                return true;
            else
                return false;
        }

        public bool LeftButtonPressed()
        {
            if (Mouse.GetState().LeftButton == ButtonState.Pressed && Mouse.GetState().LeftButton != ButtonState.Released)   
                return true;
            else
                return false;
        }
        */


        public void Draw(SpriteBatch sb)
        {
            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {

                    Squares[r, c].Draw(sb);
                    


                }
            }
            if (Selected != null)
                Selected.Draw(sb);
        }






    }
}
