using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Pong.GameEntities;
using System;

namespace Pong
{
    public class Kernel : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Ball _ball;
        private Paddle _player1;
        private Paddle _player2;

        private Score _player1Score;
        private Score _player2Score;

        private readonly int _xBound = 1600;
        private readonly int _yBound = 900;

        private KeyboardListener _keyboardListener;
        public Kernel()
        {
            // Nothing here needs to be changed
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            _graphics.PreferredBackBufferHeight = _yBound;
            _graphics.PreferredBackBufferWidth = _xBound;
        }

        protected override void Initialize()
        {
            // Nothing here needs to be changed

            _keyboardListener = new KeyboardListener();

            _ball = new Ball(800, 450, _xBound, _yBound);
            _player1 = new Paddle(0, 400, true, _xBound, _yBound, _keyboardListener);
            _player2 = new Paddle(1550, 400, false, _xBound, _yBound, _keyboardListener);

            _player1Score = new Score(483, 50);
            _player2Score = new Score(1066, 50);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // Nothing here needs to be changed
            _ball.Initialize(Content);
            _player1.Initialize(Content);
            _player2.Initialize(Content);
            _player1Score.Initialize(Content);
            _player2Score.Initialize(Content);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // Nothing here needs to be changed
            _ball.Update();
            _player1.Update();
            _player2.Update();

            if (_ball.GetHitBox().IntersectsWith(_player1.GetHitBox()) 
                || _ball.GetHitBox().IntersectsWith(_player2.GetHitBox())) 
            {
                _ball.OnCollide();
            }
            if (_ball.XPos <= 0 + 10) 
            {
                _ball.Reset();
                _player2Score.UpdateScore(Content);

                if (_player2Score.PlayerScore >= 5) 
                {
                    Environment.Exit(0);
                }
            }
            else if (_ball.XPos >= _xBound - _ball.Texture.Width - 10) 
            {
                _ball.Reset();
                _player1Score.UpdateScore(Content);

                if (_player1Score.PlayerScore >= 5)
                {
                    Environment.Exit(0);
                }
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // Nothing here needs to be changed
            _spriteBatch.Begin();

            _spriteBatch.Draw(_ball.Texture, new Vector2(_ball.XPos, _ball.YPos), Color.White);
            _spriteBatch.Draw(_player1.Texture, new Vector2(_player1.XPos, _player1.YPos), Color.Black);
            _spriteBatch.Draw(_player2.Texture, new Vector2(_player2.XPos, _player2.YPos), Color.Black);
            _spriteBatch.Draw(_player1Score.Texture, new Vector2(_player1Score.XPos, _player1Score.YPos), Color.Black);
            _spriteBatch.Draw(_player2Score.Texture, new Vector2(_player2Score.XPos, _player2Score.YPos), Color.Black);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
