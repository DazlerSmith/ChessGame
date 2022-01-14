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
    class Square
    {
        Texture2D pixel;
        int width = 50;
        int height = 50;
        int row;
        int column;
        int hoffset;
        int voffset;
        Color Colour;
        Vector2 position;
        public Piece OnSquare;
        public bool IsSelected;


        public Square(int r, int c, Texture2D t, int vo, int ho, Color co)
        {
            row = r;
            column = c;
            pixel = t;
            hoffset = ho;
            voffset = vo;
            Colour = co;
            position.X = (c * width) + ho;
            position.Y = (r * height) + vo;
            OnSquare = null;
            IsSelected = false;
        }

        public void Draw(SpriteBatch sb)
        {
            //sb.Draw(pixel, new Rectangle((int)position.X, (int)position.Y, width, height), Colour);
            if (IsSelected)
                sb.Draw(pixel, new Rectangle((int)position.X, (int)position.Y, width, height), Color.Green);
            else
                sb.Draw(pixel, new Rectangle((int)position.X, (int)position.Y, width, height), Colour);
            if (OnSquare != null)
            {
                OnSquare.Draw(sb);
            }
        }


    }
    class Pawn:Piece
    {
        public Pawn(Texture2D t, int r, int c, int vo, int ho, bool w):base(t,r,c,vo,ho, w)
        {

        }

        public override bool CheckMove(int x, int y, Square[,] s)
        {
            if (!IsWhite)
            {
                if (s[y, x].OnSquare != null)
                {
                    if (s[y, x].OnSquare.IsWhite)  //If piece on selected square is white
                    {
                        if ((row + 1 == x && column == y - 1) || (row + 1 == x && column == y + 1)) 
                            return true; // if the selected piece is 1 in front and either to the left or right then 
                        else
                        {
                            Console.WriteLine("f1 : "+y+" "+x +" : "+ s[y, x].OnSquare.column + " "+ s[y, x].OnSquare.row);  //return true
                            return false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("f2"); 
                        return false;
                    }
                }
                else
                {
                    if (row == 1)
                    {
                        if (row + 1 == x && column == y || row + 2 == x && column == y)
                            return true;
                        else
                        {
                            Console.WriteLine("f3");
                            return false;
                        }
                    }
                    else
                    {
                        if (row + 1 == x && column == y)
                            return true;
                        else
                        {
                            Console.WriteLine("f3");
                            return false;
                        }
                    }
                }
            }
            else
            {
                if (row == 6)
                {
                    if (row - 1 == x && column == y || row - 2 == x && column == y)
                        return true;
                    else
                        return false;
                }
                else
                {
                    if (row - 1 == x && column == y)
                        return true;
                    else
                        return false;
                }
            }
        }
    }

    class Bishop : Piece
    {
        public Bishop(Texture2D t, int r, int c, int vo, int ho, bool w) : base(t, r, c, vo, ho, w)
        {

        }

        public override bool CheckMove(int x, int y ,Square[,] s)
        {
            return true;
        }
    }

    class Rook : Piece
    {
        public Rook(Texture2D t, int r, int c, int vo, int ho, bool w) : base(t, r, c, vo, ho, w)
        {

        }

        public override bool CheckMove(int x, int y, Square[,] s)
        {
            return true;
        }
    }

    class Knight : Piece
    {
        public Knight(Texture2D t, int r, int c, int vo, int ho, bool w) : base(t, r, c, vo, ho, w)
        {

        }

        public override bool CheckMove(int x, int y, Square[,] s)
        {
            return true;
        }
    }

    class Queen : Piece
    {
        public Queen(Texture2D t, int r, int c, int vo, int ho, bool w) : base(t, r, c, vo, ho, w)
        {

        }

        public override bool CheckMove(int x, int y, Square[,] s)
        {
            return true;
        }
    }

    class King : Piece
    {
        public King(Texture2D t, int r, int c, int vo, int ho, bool w) : base(t, r, c, vo, ho, w)
        {

        }

        public override bool CheckMove(int x, int y, Square[,] s)
        {
            return true;
        }

    }

    abstract class Piece
    {
        public int row;
        public int column;
        public Texture2D PieceTexture;
        protected Vector2 Position;
        protected int width = 50;
        protected int height = 50;
        protected int hoffset;
        protected int voffset;
        protected Rectangle dest;
        public bool IsWhite;
        public bool IsSelected;

        public Piece(Texture2D t, int r, int c, int vo, int ho, bool w)
        {
            PieceTexture = t;
            row = r;
            column = c;
            hoffset = ho;
            voffset = vo;
            Position = new Vector2((c*width)+ho, (r*height) + vo);
            IsSelected = false;
            IsWhite = w;
            
            Console.WriteLine("Piece created " + r +" "+ c +" "+ dest);
        }

        public void updateposition(int r, int c)
        {
            row = r;
            column = c;
            Position = new Vector2((c * width) + hoffset, (r * height) + voffset);
            Console.WriteLine(r + " " + c + " : " + Position);
        }

        public abstract bool CheckMove(int x, int y, Square[,] s);

        public void Draw(SpriteBatch spriteBatch)
        {
          
            if (IsSelected)
            {
                MouseState m = Mouse.GetState();
                dest = new Rectangle((int)m.X-(width/2), (int)m.Y-(height/2), width, height);
                spriteBatch.Draw(PieceTexture, dest, Color.Magenta);
            }
            else
            {
                dest = new Rectangle((int)Position.X, (int)Position.Y, width, height);
                spriteBatch.Draw(PieceTexture, dest, Color.White);
            }
            //spriteBatch.Draw(PieceTexture, new Rectangle(300,400, 50, 50), Color.White);



        }

       
    }
}
