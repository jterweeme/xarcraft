using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Xarcraft
{
    class MenuScreen : Screen
    {
        SpriteFont font;
        bool keyIsDown = false;
        int selectedButton = 0;
        List<MenuItem> menuItems = new List<MenuItem>();

        public MenuScreen(Game1 game)
            : base(game)
        {
        }

        protected override void LoadContent()
        {
            base.LoadContent();
            font = game.Content.Load<SpriteFont>("Font");
            menuItems.Add(new MenuItem(game, "New Game", new Vector2(20, 60), new GameScreen(game)));
            menuItems.Add(new MenuItem(game, "Credits", new Vector2(20, 80), new CreditScreen(game)));
            menuItems.Add(new MenuItem(game, "Exit", new Vector2(20, 100), new ExitScreen(game)));
            menuItems[0].select();
        }

        public override void Unload()
        {
            foreach (MenuItem menuItem in menuItems)
            {
                menuItem.Unload();
            }
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            KeyboardState kbs = Keyboard.GetState();

            int oldIndex = selectedButton;

            if (kbs.IsKeyDown(Keys.Down) && !keyIsDown)
            {
                if (++selectedButton > menuItems.Count - 1)
                    selectedButton = 0;

                menuItems[selectedButton].select();
                keyIsDown = true;
            }

            if (kbs.IsKeyDown(Keys.Up) && !keyIsDown)
            {
                if (--selectedButton < 0)
                    selectedButton = menuItems.Count - 1;

                menuItems[selectedButton].select();
                keyIsDown = true;
            }

            if (kbs.IsKeyDown(Keys.Enter) && !keyIsDown)
            {
                menuItems[selectedButton].doAction();
            }

            if (kbs.GetPressedKeys().Length == 0)
                keyIsDown = false;

            if (oldIndex != selectedButton)
                menuItems[oldIndex].unselect();
        }
    }
}
