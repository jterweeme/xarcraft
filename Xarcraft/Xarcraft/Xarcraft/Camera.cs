using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Xarcraft
{
    public class Camera
    {

        private Vector2 position;
        private float step = 20.0f;

        private void moveHorizontal(float speed)
        {
            if ((position.X < 1100.0f && speed > 0.0f) || (position.X > -100.0f && speed < 0.0f))
            {
                position.X += speed;
            }
        }

        private void moveVertical(float speed)
        {
            if ((position.Y < 800.0f && speed > 0.0f) || (position.Y > -100.0f && speed < 0.0f))
            {
                position.Y += speed;
            }
        }

        public void Update(GameTime gameTime)
        {
            KeyboardState kbs = Keyboard.GetState();

            if (kbs.IsKeyDown(Keys.Up))
            {
                moveVertical(step);
            }

            if (kbs.IsKeyDown(Keys.Left))
            {
                moveHorizontal(step);
            }

            if (kbs.IsKeyDown(Keys.Right))
            {
                moveHorizontal(step * -1);
            }

            if (kbs.IsKeyDown(Keys.Down))
            {
                moveVertical(step * -1);
            }
        }

        public Matrix GetMatrix()
        {
            return Matrix.CreateTranslation(new Vector3(position, 0));
        }
    }
}
