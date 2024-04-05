using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Drawing;

namespace Pong.GameEntities
{
    public abstract class Entity
    {
        protected int _xDirection, _yDirection;

        public int XPos {get; protected set;}
        public int YPos { get; protected set; }

        public Texture2D Texture { get; protected set; }

        protected int[] _screenBoundaries;
        public Entity() { }
        public Entity(int xPos, int yPos) 
        {
            XPos = xPos;
            YPos = yPos;

            _xDirection = -1;
            _yDirection = 1;
        }
        public Entity(int xPos, int yPos, int xBoundary, int yBoundary) : this(xPos, yPos)
        {
            _screenBoundaries = new int[] {xBoundary, yBoundary};
        }

        public Rectangle GetHitBox() 
        {
             return new Rectangle(XPos, YPos, Texture.Width, Texture.Height);
        }
        public abstract void Initialize(ContentManager content);
        public abstract void Update();
        public abstract void OnCollide();
    }
}
