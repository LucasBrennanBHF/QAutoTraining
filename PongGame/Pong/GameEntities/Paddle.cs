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
            // TODO: Movement code goes here
        }
    }
}
