using System.Drawing;

namespace Pong.GameEntities
{
    public interface IDrawable
    {
        public int XPos { get; }
        public int YPos { get; }
        public Rectangle GetHitBox();
    }
}
