﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Xarcraft
{
    class SplashScreen : Screen
    {
        SpriteFont font;
        Texture2D splash;
        int count = 0;
        int maxCount = 20;

        public SplashScreen(Game1 game)
            : base(game)
        {
        }

        protected override void LoadContent()
        {
            base.LoadContent();
            font = game.Content.Load<SpriteFont>("Font");
            splash = this.Game.Content.Load<Texture2D>("splashscreen");
        }


        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
            spriteBatch.Begin();
            spriteBatch.DrawString(font, "Hello world", new Vector2(20, 20), Color.Black);
            spriteBatch.Draw(splash, new Rectangle(0, 0, 1280, 800), Color.White);
            spriteBatch.End();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            if (count++ > maxCount)
                this.game.changeScreen(new MenuScreen(game));
        }
    }
}
