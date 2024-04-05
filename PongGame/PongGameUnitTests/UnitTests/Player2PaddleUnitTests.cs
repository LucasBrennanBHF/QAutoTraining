using Microsoft.Xna.Framework.Input;
using Moq;
using Pong;
using Pong.GameEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGameUnitTests.UnitTests
{
    public class Player2PaddleUnitTests : SharedTests
    {
        Entity _sutPaddle;
        Mock<KeyboardListener> _mockListener;

        public Player2PaddleUnitTests() : base()
        {
            _mockListener = new();
            _sutPaddle = new Paddle(50, 50, false, 1000, 1000, _mockListener.Object);
            _sutPaddle.Initialize(_kernel.Content);
        }

        [Theory]
        [InlineData(Keys.Down)]
        [InlineData(Keys.Up)]
        public void GivenAValidInput_Paddle_MovesInThatDirection(Keys key)
        {
            _mockListener.Setup(x => x.IsKeyDown(key)).Returns(true);

            _sutPaddle.Update();

            Assert.True(_sutPaddle.YPos != 50);
        }

        [Fact]
        public void GivenAValidHitBox_Player2_ReturnsARectangle()
        {
            Assert.True(_sutPaddle.GetHitBox() != null);
        }
    }
}
