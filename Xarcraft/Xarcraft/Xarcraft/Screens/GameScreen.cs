using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace Xarcraft
{
    public class GameScreen : Screen
    {
        Camera camera;
        SpriteFont font;

        public GameScreen(Game1 game)
            : base(game)
        {
            this.game = game;
        }

        public override void Initialize()
        {
            base.Initialize();
            camera = new Camera();
        }

        protected override void LoadContent()
        {
            base.LoadContent();
            
            font = game.Content.Load<SpriteFont>("Font");
        }

        public override void Update(Microsoft.Xna.Framework.GameTime gameTime)
        {
            base.Update(gameTime);
            camera.Update(gameTime);
        }

        public override void Draw(Microsoft.Xna.Framework.GameTime gameTime)
        {
            base.Draw(gameTime);
            spriteBatch.Begin(SpriteSortMode.BackToFront, null, null, null, null, null, camera.GetMatrix());
            spriteBatch.DrawString(font, "Bladiebla", new Vector2(100, 100), Color.Black);
            spriteBatch.End();
        }
    }
}
