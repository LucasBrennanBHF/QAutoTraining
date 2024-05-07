using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Pong.GameEntities
{
    public class Score : Entity
    {
        ContentManager _content;
        public int PlayerScore { get; private set; }

        public Score(int xPos, int yPos) : base(xPos, yPos)
        {
            PlayerScore = 0;
        }

        public override void Initialize(ContentManager content)
        {
            _content = content;
            Texture = _content.Load<Texture2D>("Number0");
        }

        public override void OnCollide()
        {
            //Do Nothing
        }

        public override void Update()
        {
            PlayerScore++;
            if (PlayerScore <= 5) Texture = _content.Load<Texture2D>("Number" + PlayerScore);
            else if (PlayerScore > 5) Environment.Exit(0);
        }

        public override void Reset()
        {
            PlayerScore = 0;
            Texture = _content.Load<Texture2D>("Number0");
        }
    }
}
