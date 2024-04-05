using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    public class KeyboardListener
    {
        public virtual bool IsKeyDown(Keys key)
        {
            return Keyboard.GetState().IsKeyDown(key);
        }
    }
}
