using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Xarcraft
{
    class MenuScreen : Screen
    {
        SpriteFont font;

        public MenuScreen(Game1 game)
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
            spriteBatch.DrawString(font, "New Game", new Vector2(20, 60), Color.Black);
            spriteBatch.DrawString(font, "Exit", new Vector2(20, 80), Color.Black);
            spriteBatch.End();
        }
    }
}
