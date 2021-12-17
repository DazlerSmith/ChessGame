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
        public Pawn(Texture2D t, int r, int c, int vo, int ho):base(t,r,c,vo,ho)
        {

        }

        public override void CheckMove()
        {

        }
    }

    class Bishop : Piece
    {
        public Bishop(Texture2D t, int r, int c, int vo, int ho) : base(t, r, c, vo, ho)
        {

        }

        public override void CheckMove()
        {

        }
    }

    class Rook : Piece
    {
        public Rook(Texture2D t, int r, int c, int vo, int ho) : base(t, r, c, vo, ho)
        {

        }

        public override void CheckMove()
        {

        }
    }

    class Knight : Piece
    {
        public Knight(Texture2D t, int r, int c, int vo, int ho) : base(t, r, c, vo, ho)
        {

        }

        public override void CheckMove()
        {

        }
    }

    class Queen : Piece
    {
        public Queen(Texture2D t, int r, int c, int vo, int ho) : base(t, r, c, vo, ho)
        {

        }

        public override void CheckMove()
        {

        }
    }

    class King : Piece
    {
        public King(Texture2D t, int r, int c, int vo, int ho) : base(t, r, c, vo, ho)
        {

        }

        public override void CheckMove()
        {

        }

    }

    abstract class Piece
    {
        int row;
        int column;
        public Texture2D PieceTexture;
        Vector2 Position;
        int width = 50;
        int height = 50;
        int hoffset;
        int voffset;
        Rectangle dest;
        public bool IsSelected;

        public Piece(Texture2D t, int r, int c, int vo, int ho)
        {
            PieceTexture = t;
            row = r;
            column = c;
            hoffset = ho;
            voffset = vo;
            Position = new Vector2((c*width)+ho, (r*height) + vo);
            IsSelected = false;
            
            Console.WriteLine("Piece created " +r+" " + c +" "+dest);
        }

        public abstract void CheckMove();

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
