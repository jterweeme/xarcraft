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

        public override void Initialize()
        {
            base.Initialize();
            font = game.Content.Load<SpriteFont>("Font");
        }

        protected override void LoadContent()
        {
            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
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
