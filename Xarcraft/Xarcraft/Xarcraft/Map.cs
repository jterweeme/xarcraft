using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Xarcraft
{
    public class Map : DrawableGameComponent
    {
        List<NatureObject> nature;
        SpriteBatch spriteBatch;
        SpriteFont font;
        Game1 game;
        Texture2D bg;
        int width = 10;
        int height = 10;

        public Map(Game1 game)
            : base(game)
        {
            this.game = game;
            nature = new List<NatureObject>();
            Game.Components.Add(this);
        }

        protected override void LoadContent()
        {
            base.LoadContent();
            bg = Game.Content.Load<Texture2D>("background");
            nature.Add(new Tree(game));
            nature.Add(new Tree(game, 100, 100));
            font = Game.Content.Load<SpriteFont>("Font");
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
            spriteBatch.Begin(SpriteSortMode.BackToFront, null, null, null, null, null, GameScreen.camera.GetMatrix());
            
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    spriteBatch.Draw(bg, new Rectangle(x * bg.Width, y * bg.Height, bg.Width, bg.Height), Color.White);
                }
            }

            spriteBatch.End();
        }
    }
}
