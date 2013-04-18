using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Xarcraft
{
    class SplashScreen : Screen
    {
        SpriteFont font;

        public SplashScreen(Game1 game)
            : base(game)
        {
        }

        protected override void LoadContent()
        {
            base.LoadContent();
            font = game.Content.Load<SpriteFont>("Font");
        }


        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
            spriteBatch.Begin();
            spriteBatch.DrawString(font, "Hello world", new Vector2(20, 20), Color.Black);
            spriteBatch.End();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            KeyboardState keyboard = Keyboard.GetState();

            if (keyboard.IsKeyDown(Keys.A))
            {
                Console.WriteLine("Debug bericht");
                this.game.changeScreen(new MenuScreen(game));
            }
        }
    }
}
