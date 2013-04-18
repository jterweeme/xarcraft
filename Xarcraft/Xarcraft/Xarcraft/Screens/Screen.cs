using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Xarcraft
{
    public abstract class Screen : DrawableGameComponent
    {
        protected Game1 game;
        protected SpriteBatch spriteBatch;

        public Screen(Game1 game)
            : base(game)
        {
            this.game = game;
        }


        protected override void LoadContent()
        {
            base.LoadContent();
            spriteBatch = new SpriteBatch(this.Game.GraphicsDevice);
        }

       
    }
}
