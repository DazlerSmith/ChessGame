using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using ChessGame2._0;
using System;

namespace ChessGame2._0
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    ///Max was here.
    
        public class Game1 : Game
        {
            GraphicsDeviceManager graphics;
            SpriteBatch spriteBatch;
            Texture2D pixel;
            Board test;
            Texture2D PieceTexture;

            public Game1()
            {
                graphics = new GraphicsDeviceManager(this);
                Content.RootDirectory = "Content";
            }

            /// <summary>
            /// Allows the game to perform any initialization it needs to before starting to run.
            /// This is where it can query for any required services and load any non-graphic
            /// related content.  Calling base.Initialize will enumerate through any components
            /// and initialize them as well.
            /// </summary>
            protected override void Initialize()
            {
            // TODO: Add your initialization logic here
            IsMouseVisible = true;
                base.Initialize();

            }

            /// <summary>
            /// LoadContent will be called once per game and is the place to load
            /// all of your content.
            /// </summary>
            protected override void LoadContent()
            {
                // Create a new SpriteBatch, which can be used to draw textures.
                spriteBatch = new SpriteBatch(GraphicsDevice);

                pixel = new Texture2D(GraphicsDevice, 1, 1);  //Make a 1x1 texture named pixel
                Color[] colorData =
                {
                Color.White,      // Create a 1D array of color data to fill the pixel texture with. 
                };
                pixel.SetData<Color>(colorData); // Set the texture data with our color information. 

                // TODO: use this.Content to load your game content here
                test = new Board(pixel);


                PieceTexture = Content.Load<Texture2D>("White Pawn Sprite");
            Piece temp;
            for (int i = 0; i < 8; i++)
            {
                //temp = new Piece(PieceTexture, i, 1, 50, 200);
                test.Squares[6, i].OnSquare = new Pawn(PieceTexture, 6, i, 50, 200);  // r , c , offsets
                Console.WriteLine(test.Squares[6, i].OnSquare.ToString());
            }          

            PieceTexture = Content.Load<Texture2D>("White Rook Sprite2.0");
            temp = new Rook(PieceTexture, 7, 0, 50, 200);
            test.Squares[7, 0].OnSquare = temp;
            Console.WriteLine(test.Squares[7 , 0].OnSquare.ToString());

            temp = new Rook(PieceTexture, 7, 7, 50, 200);
            test.Squares[7, 7].OnSquare = temp;
            Console.WriteLine(test.Squares[7, 7].OnSquare.ToString());

            PieceTexture = Content.Load<Texture2D>("White Bishop Sprite");
            temp = new Bishop(PieceTexture, 7, 2, 50, 200);
            test.Squares[7 , 2].OnSquare = temp;
            Console.WriteLine(test.Squares[7 , 2].OnSquare.ToString());

            temp = new Bishop(PieceTexture, 7 , 5, 50, 200);
            test.Squares[7 , 5].OnSquare = temp;
            Console.WriteLine(test.Squares[7 , 5].OnSquare.ToString());

            PieceTexture = Content.Load<Texture2D>("White Knight Sprite");
            temp = new Knight(PieceTexture, 7, 1, 50, 200);
            test.Squares[7, 1].OnSquare = temp;
            Console.WriteLine(test.Squares[7, 1].OnSquare.ToString());

            temp = new Knight(PieceTexture, 7, 6, 50, 200);
            test.Squares[7, 6].OnSquare = temp;
            Console.WriteLine(test.Squares[7, 6].OnSquare.ToString());

            PieceTexture = Content.Load<Texture2D>("White King Sprite");
            temp = new King(PieceTexture, 7, 4, 50, 200);
            test.Squares[7, 4].OnSquare = temp;
            Console.WriteLine(test.Squares[7, 4].OnSquare.ToString());

            PieceTexture = Content.Load<Texture2D>("White Queen Sprite");
            temp = new Queen(PieceTexture, 7, 3, 50, 200);
            test.Squares[7, 3].OnSquare = temp;
            Console.WriteLine(test.Squares[7, 3].OnSquare.ToString());

            PieceTexture = Content.Load<Texture2D>("Black Pawn Sprite");
            for (int i = 0; i < 8; i++)
            {
                temp = new Pawn(PieceTexture, 1, i, 50, 200);
                test.Squares[1, i].OnSquare = temp;
                Console.WriteLine(test.Squares[1, i].OnSquare.ToString());
            }

                PieceTexture = Content.Load<Texture2D>("Black Bishop Sprite");
            temp = new Bishop(PieceTexture, 0, 2, 50, 200);
            test.Squares[0,2].OnSquare = temp;
            Console.WriteLine(test.Squares[0, 2].OnSquare.ToString());

            temp = new Bishop(PieceTexture, 0, 5, 50, 200);
            test.Squares[0, 5].OnSquare = temp;
            Console.WriteLine(test.Squares[0, 5].OnSquare.ToString());

            PieceTexture = Content.Load<Texture2D>("Black Rook Sprite");
            temp = new Rook(PieceTexture, 0, 0, 50, 200);
            test.Squares[0, 0].OnSquare = temp;
            Console.WriteLine(test.Squares[0, 0].OnSquare.ToString());

            temp = new Rook(PieceTexture, 0, 7, 50, 200);
            test.Squares[0, 7].OnSquare = temp;
            Console.WriteLine(test.Squares[0, 7].OnSquare.ToString());

            PieceTexture = Content.Load<Texture2D>("Black Knight Sprite");
            temp = new Knight(PieceTexture, 0, 1, 50, 200);
            test.Squares[0, 1].OnSquare = temp;
            Console.WriteLine(test.Squares[0, 1].OnSquare.ToString());

            temp = new Knight(PieceTexture, 0, 6, 50, 200);
            test.Squares[0, 6].OnSquare = temp;
            Console.WriteLine(test.Squares[0, 6].OnSquare.ToString());

            PieceTexture = Content.Load<Texture2D>("Black King Sprite");
            temp = new King(PieceTexture, 0, 4, 50, 200);
            test.Squares[0, 4].OnSquare = temp;
            Console.WriteLine(test.Squares[0, 4].OnSquare.ToString());

            PieceTexture = Content.Load<Texture2D>("Black Queen Sprite");
            temp = new Queen(PieceTexture, 0, 3, 50, 200);
            test.Squares[0, 3].OnSquare = temp;
            Console.WriteLine(test.Squares[0, 3].OnSquare.ToString());

        }

            /// <summary>
            /// UnloadContent will be called once per game and is the place to unload
            /// game-specific content.
            /// </summary>
            protected override void UnloadContent()
            {
                // TODO: Unload any non ContentManager content here
            }

            /// <summary>
            /// Allows the game to run logic such as updating the world,
            /// checking for collisions, gathering input, and playing audio.
            /// </summary>
            /// <param name="gameTime">Provides a snapshot of timing values.</param>
            protected override void Update(GameTime gameTime)
            {
                if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                    Exit();

            
            if (Mouse.GetState().LeftButton == ButtonState.Pressed)
             {
                test.ClickBoard(Mouse.GetState().X,Mouse.GetState().Y);

             }

                // TODO: Add your update logic here

                base.Update(gameTime);
            }

            /// <summary>
            /// This is called when the game should draw itself.
            /// </summary>
            /// <param name="gameTime">Provides a snapshot of timing values.</param>
            protected override void Draw(GameTime gameTime)
            {
                GraphicsDevice.Clear(Color.CornflowerBlue);

                spriteBatch.Begin();
                // Draw a fancy purple rectangle.  
                test.Draw(spriteBatch);
                //spriteBatch.Draw(PieceTexture, new Rectangle(200,200,50,50), Color.White); TEST
                spriteBatch.End();

                // TODO: Add your drawing code here

                base.Draw(gameTime);



            }
        }
    }

