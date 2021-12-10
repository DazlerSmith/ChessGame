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
        }

        public void Draw(SpriteBatch sb)
        {
            sb.Draw(pixel, new Rectangle((int)position.X, (int)position.Y, width, height), Colour);
            if (OnSquare != null)
            {
                OnSquare.Draw(sb);
            }
        }


    }

    class Piece
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

        public Piece(Texture2D t, int r, int c, int vo, int ho)
        {
            PieceTexture = t;
            row = r;
            column = c;
            hoffset = ho;
            voffset = vo;
            Position = new Vector2((c*width)+ho, (r*height) + vo);
            
            Console.WriteLine("Piece created " +r+" " + c +" "+dest);
        }


        public void Draw(SpriteBatch spriteBatch)
        {
            dest = new Rectangle((int)Position.X, (int)Position.Y, width, height);
            spriteBatch.Draw(PieceTexture, dest, Color.White);
            //spriteBatch.Draw(PieceTexture, new Rectangle(300,400, 50, 50), Color.White);



        }

       
    }
}
