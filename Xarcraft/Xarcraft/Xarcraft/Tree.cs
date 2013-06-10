using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Xarcraft
{
    public class Tree : NatureObject
    {
        public Tree(Game1 game)
            : this(game, 0, 0)
        {
            
        }

        public Tree(Game1 game, int x, int y)
            : base(game)
        {
            this.x = x;
            this.y = y;
            DrawOrder = 9999;
            Game.Components.Add(this);
        }

        protected override void LoadContent()
        {
            base.LoadContent();
            texture = Game.Content.Load<Texture2D>("tree");
        }

        public override void Draw(Microsoft.Xna.Framework.GameTime gameTime)
        {
            base.Draw(gameTime);
            sb.Begin(SpriteSortMode.BackToFront, null, null, null, null, null, GameScreen.camera.GetMatrix());
            sb.Draw(texture, new Rectangle(x, y, texture.Width, texture.Height), Color.White);
            sb.End();
        }
    }
}
