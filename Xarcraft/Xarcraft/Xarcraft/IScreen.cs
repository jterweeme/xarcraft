using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Xarcraft
{
    public abstract class Screen : DrawableGameComponent
    {
        protected Game game;
        protected SpriteBatch spriteBatch;

        public Screen(Game game)
            : base(game)
        {
            this.game = game;
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            base.LoadContent();
            spriteBatch = new SpriteBatch(this.Game.GraphicsDevice);
        }

       
    }
}
