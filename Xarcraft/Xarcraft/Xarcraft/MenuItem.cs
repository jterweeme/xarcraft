using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Xarcraft
{
    class MenuItem : DrawableGameComponent
    {
        SpriteBatch spriteBatch;
        SpriteFont font;
        string text;
        Vector2 pos;
        bool selected = false;
        Game1 game;
        Screen screen;

        public MenuItem(Game1 game, string text, Vector2 pos)
            : this(game, text, pos, null)
        {
        }

        public MenuItem(Game1 game, string text, Vector2 pos, Screen screen)
            : base(game)
        {
            this.game = game;
            this.text = text;
            this.pos = pos;
            this.screen = screen;
            game.Components.Add(this);
        }

        public void doAction()
        {
            this.game.changeScreen(screen);
        }

        protected override void LoadContent()
        {
            base.LoadContent();
            spriteBatch = new SpriteBatch(GraphicsDevice);
            font = this.Game.Content.Load<SpriteFont>("font");
            
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
            spriteBatch.Begin();

            if (selected)
                spriteBatch.DrawString(font, text, pos, Color.Red);
            else
                spriteBatch.DrawString(font, text, pos, Color.Black);

            spriteBatch.End();
        }

        public void select()
        {
            this.selected = true;
        }

        public void unselect()
        {
            this.selected = false;
        }
    }
}
