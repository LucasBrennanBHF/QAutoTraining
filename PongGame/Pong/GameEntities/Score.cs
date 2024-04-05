using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Pong.GameEntities
{
    public class Score : Entity
    {
        public int PlayerScore { get; private set; }

        public Score(int xPos, int yPos) : base(xPos, yPos)
        {
            PlayerScore = 0;
        }

        public override void Initialize(ContentManager content)
        {
            Texture = content.Load<Texture2D>("Number0");
        }

        public override void OnCollide()
        {
            //Do Nothing
        }

        public override void Update()
        {
            //Do Nothing
        }
        public void UpdateScore(ContentManager content) 
        {
            PlayerScore++;
            if (PlayerScore <= 5) Texture = content.Load<Texture2D>("Number" + PlayerScore);
        }
    }
}
