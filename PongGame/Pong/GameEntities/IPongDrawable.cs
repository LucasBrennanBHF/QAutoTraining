using Microsoft.Xna.Framework.Graphics;
using System.Drawing;

namespace Pong.GameEntities
{
    public interface IPongDrawable
    {
        public Texture2D Texture { get; }     
        public Rectangle GetHitBox();
    }
}
