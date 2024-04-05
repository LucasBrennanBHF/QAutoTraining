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
    public class Player1PaddleUnitTests : SharedTests
    {
        Entity _sutPaddle;
        Mock<KeyboardListener> _mockListener;

        public Player1PaddleUnitTests() : base()
        {
            _mockListener = new();
            _sutPaddle = new Paddle(50, 50, true, 1000, 1000, _mockListener.Object);
            _sutPaddle.Initialize(_kernel.Content);
        }

        [Theory]
        [InlineData(Keys.S)]
        [InlineData(Keys.W)]
        public void GivenAValidInput_Paddle_MovesInThatDirection(Keys key) 
        {
            _mockListener.Setup(x => x.IsKeyDown(key)).Returns(true);

            _sutPaddle.Update();

            Assert.True(_sutPaddle.YPos != 50);
        }

        [Fact]
        public void GivenAValidHitBox_Player1_ReturnsARectangle()
        {
            Assert.True(_sutPaddle.GetHitBox() != null);
        }
    }
}
