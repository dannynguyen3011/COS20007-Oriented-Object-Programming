using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3D
{
        public class GameOverScreen
        {
            private Window _window;
            private bool _restartClicked;
            private int _score;

            public GameOverScreen(Window window, int score)
            {
                _window = window;
                _restartClicked = false;
                _score = score;
            }

            public bool RestartClicked
            {
                get
                {
                    return _restartClicked;
                }
            }
                
            public void Draw(int score )
            {
                // Draw the game over screen graphics, including the score and restart option
                SplashKit.DrawText("Game Over!", Color.White, "ThaleahFat.ttf", 36, 210, 200);
                SplashKit.DrawText($"Score: {score}", Color.White, "ThaleahFat.ttf", 24, 230, 230);
                SplashKit.DrawText("Click Restart to play again", Color.White, "ThaleahFat.ttf", 24, 300, 320);

                //make button
                Rectangle restartButton = new Rectangle();
                restartButton.X = 280;
                restartButton.Y = 360;
                restartButton.Width = 200;
                restartButton.Height = 50;

                Console.WriteLine(_score);

                SplashKit.FillRectangle(Color.Green, restartButton);
                SplashKit.DrawText("Restart", Color.White, "ThaleahFat.ttf", 24, 350, 360);

                //Check for mouse click event on the restart button
                if (SplashKit.MouseClicked(MouseButton.LeftButton) && SplashKit.PointInRectangle(SplashKit.MousePosition(), restartButton))
                {
                    _restartClicked = true;
                }
            }

            //reset if player starts again
            public void Reset()
            {
                _restartClicked = false;
                _score = 0;
            }
        }
    }

