using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace Xarcraft
{
    public class GameScreen : Screen
    {
        public static Camera camera;
        SpriteFont font;
        Map map;

        public GameScreen(Game1 game)
            : base(game)
        {
            this.game = game;
            
        }

        public override void Initialize()
        {
            base.Initialize();
            camera = new Camera();
            map = new Map(game); 
        }

        protected override void LoadContent()
        {
            base.LoadContent();
            //Game.Components.Add(map);
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

        }
    }
}
