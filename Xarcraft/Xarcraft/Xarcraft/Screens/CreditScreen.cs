using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Xarcraft
{
    public class CreditScreen : Screen
    {
        Texture2D texture;
        int count = 0;
        int maxCount = 200;

        public CreditScreen(Game1 game)
            : base(game)
        {
            this.game = game;
        }

        protected override void LoadContent()
        {
            base.LoadContent();
            
            texture = Game.Content.Load<Texture2D>("credits");
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
            spriteBatch.Begin();
            spriteBatch.Draw(texture, new Rectangle(0, 0, 1280, 800), Color.White);
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
