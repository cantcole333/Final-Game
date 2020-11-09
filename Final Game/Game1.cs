using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Final_Game
{
    public class Game1 : Game
    {
        
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D playerTexture;
        Rectangle playerRect;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            playerRect = new Rectangle(300, 300, 50, 50);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            playerTexture = Content.Load<Texture2D>("Player still");
            
        }

        protected override void Update(GameTime gameTime)
        {
            KeyboardState state = Keyboard.GetState();


            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            if (state.IsKeyDown(Keys.Left))
            {
                playerRect.X -= 3;
                playerTexture = Content.Load<Texture2D>("Player running");

            }
            if (state.IsKeyDown(Keys.Right))
            {
                playerRect.X += 3;
                playerTexture = Content.Load<Texture2D>("Player running");

            }
            

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(playerTexture, playerRect, Color.White);
            _spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
