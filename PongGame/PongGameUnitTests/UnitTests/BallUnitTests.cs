using Moq;
using Pong.GameEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGameUnitTests.UnitTests
{
    public class BallUnitTests : SharedTests
    {
        Entity _sutBall;

        public BallUnitTests() : base()
        {
            _sutBall = new Ball(50, 50, 1000, 1000);
            _sutBall.Initialize(_kernel.Content);
        }

        [Fact]
        public void GivenAValidPosition_Ball_MovesDiagonally()
        {
            _sutBall.Update();

            Assert.True(_sutBall.YPos != 50);
            Assert.True(_sutBall.XPos != 50);
        }

        [Fact]
        public void GivenAValidPositionOnABoundary_Ball_ChangesDirection()
        {
            _sutBall = new Ball(0, 950, 1000, 1000);
            _sutBall.Initialize(_kernel.Content);

            _sutBall.Update();

            Assert.True(_sutBall.YPos == 950);
            Assert.True(_sutBall.XPos == 0);

            _sutBall.Update();

            Assert.True(_sutBall.YPos == 945);
            Assert.True(_sutBall.XPos == 5);
        }

        [Fact]
        public void GivenAValidPaddle_Ball_Collides()
        {
            _sutBall = new Ball(50, 50, 1000, 1000);
            _sutBall.Initialize(_kernel.Content);

            _sutBall.OnCollide();
            _sutBall.Update();

            Assert.True(_sutBall.YPos == 55);
            Assert.True(_sutBall.XPos == 60);
        }

        [Fact]
        public void GivenAValidHitBox_Ball_ReturnsARectangle()
        {
            _sutBall = new Ball(50, 50, 1000, 1000);
            _sutBall.Initialize(_kernel.Content);

            Assert.True(_sutBall.GetHitBox() != null);
        }
    }
}
