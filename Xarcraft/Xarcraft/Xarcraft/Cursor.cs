using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Xarcraft
{
    class Cursor : DrawableGameComponent
    {
        Texture2D cursor;
        SpriteBatch spriteBatch;
        int posX = 0;
        int posY = 0;

        public Cursor(Game game)
            : base(game)
        {

        }

        public override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            base.LoadContent();
            cursor = this.Game.Content.Load<Texture2D>("cursorTexture");
            spriteBatch = new SpriteBatch(this.Game.GraphicsDevice);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            MouseState mouse = Mouse.GetState();
            posX = mouse.X;
            posY = mouse.Y;
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
            spriteBatch.Begin();
            spriteBatch.Draw(cursor, new Rectangle(posX, posY, cursor.Width, cursor.Height), Color.White);
            spriteBatch.End();
        }

    }
}
