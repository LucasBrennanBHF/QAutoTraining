using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Pong.GameEntities
{
    public class Ball : Entity
    {
        private int _speed = 5;

        public Ball(int xPos, int yPos, int xBoundary, int yBoundary) : base (xPos, yPos, xBoundary, yBoundary) { }

        public override void Initialize(ContentManager content)
        {
            Texture = content.Load<Texture2D>("Ball");
        }

        public override void OnCollide()
        {
            _xDirection *= -1;
            XPos += _xDirection * _speed;
        }

        public override void Update()
        {
            // TODO: Movement code goes here
        }

        public void Reset()
        {
            XPos = (_screenBoundaries[(int)ScreenBound.X] / 2) + Texture.Height; 
            YPos = (_screenBoundaries[(int)ScreenBound.Y] / 2);
            _xDirection *= -1;
        }
    }
}
