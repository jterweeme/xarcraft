using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Xarcraft
{
    class SplashScreen : Screen
    {
        SpriteFont font;

        public SplashScreen(Game game)
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
    }
}
