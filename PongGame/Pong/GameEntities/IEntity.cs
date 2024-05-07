using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong.GameEntities
{
    public interface IEntity
    {
        public int XPos { get; }
        public int YPos { get; }
        public abstract void Initialize(ContentManager content);
        public abstract void Update();
        public abstract void OnCollide();
        void Reset();
    }
}
