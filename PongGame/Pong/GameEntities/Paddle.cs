using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Pong.GameEntities
{
    public class Paddle : Entity
    {
        private int _speed = 5;
        private bool _isPlayer1;
        private KeyboardListener _listener;
        public Paddle(int xPos, int yPos, bool isPlayer1, int xBoundary, int yBoundary, KeyboardListener listener) : 
            base(xPos, yPos, xBoundary, yBoundary)
        {
            _isPlayer1 = isPlayer1;
            _listener = listener;
        }

        public override void Initialize(ContentManager content)
        {
            Texture = content.Load<Texture2D>("Paddle");           
        }

        public override void OnCollide()
        {
            //Do Nothing
        }

        public override void Update()
        {
            if (_isPlayer1)
            {
                if (_listener.IsKeyDown(Keys.W))
                {
                    YPos -= _speed;
                    if (YPos <= 0) 
                    {
                        YPos += _speed;
                    }
                }
                else if (_listener.IsKeyDown(Keys.S))
                {
                    YPos += _speed;
                    if (YPos >= _screenBoundaries[(int)ScreenBound.Y] - Texture.Height)
                    {
                        YPos -= _speed;
                    }
                }
            }
            else
            {
                if (_listener.IsKeyDown(Keys.Up))
                {
                    YPos -= _speed;
                    if (YPos <= 0)
                    {
                        YPos += _speed;
                    }
                }
                else if (_listener.IsKeyDown(Keys.Down))
                {
                    YPos += _speed;
                    if (YPos >= _screenBoundaries[(int)ScreenBound.Y] - Texture.Height)
                    {
                        YPos -= _speed;
                    }
                }
            }
        }
    }
}
