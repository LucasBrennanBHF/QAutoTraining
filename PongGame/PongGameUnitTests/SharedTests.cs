using Microsoft.Xna.Framework;
using Pong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGameUnitTests
{
    public class SharedTests : IDisposable
    {
        protected Game _kernel;
        public SharedTests() 
        {
            _kernel = new Kernel();
            _kernel.RunOneFrame();
        }

        public void Dispose()
        {
            _kernel.Dispose();
        }
    }
}
