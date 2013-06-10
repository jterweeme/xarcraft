using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Xarcraft
{
    public abstract class NatureObject : DrawableGameComponent
    {
        protected int x = 0;
        protected int y = 0;
        protected Texture2D texture;
        protected SpriteBatch sb;

        public NatureObject(Game1 game) : base(game)
        {
        }

        protected override void LoadContent()
        {
            base.LoadContent();
            sb = new SpriteBatch(GraphicsDevice);
        }
    }
}
