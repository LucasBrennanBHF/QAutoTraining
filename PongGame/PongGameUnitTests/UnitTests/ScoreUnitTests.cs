using Moq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Pong.GameEntities;
using Microsoft.Xna.Framework.Content;
using Pong;

namespace PongGameUnitTests.UnitTests
{
    public class ScoreUnitTests : SharedTests
    {
        Score _sutScore;

        public ScoreUnitTests() : base()
        {
            _sutScore = new(0, 0);
        }

        [Fact]
        public void GivenAValidScore_Score_UpdatesThePlayerScore()
        {
            _sutScore.UpdateScore(_kernel.Content);

            Assert.Equal(1, _sutScore.PlayerScore);
        }
    }
}
