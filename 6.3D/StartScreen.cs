using _6._3D;
using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3D
{
    public class StartScreen : GameObject
    {

        private Window _window;
        

        private bool _startClicked; // check if start button was clicked
        Bitmap startbackground = new Bitmap("background", "strtbg.png");
        public StartScreen(Window window)
        {
            
            _window = window;
            _startClicked = false;
        }

        public bool StartClicked
        {
            get
            {
                return _startClicked;
            }
        }

        //draw start screen
        public void Draw()
        {
            // Draw the start screen graphics, including the start button and game instructions
            startbackground.Draw(0, 0);
            SplashKit.DrawText("Welcome to Food Terminator!", Color.Black, "ThaleahFat.ttf", 50, 130, 200);
            SplashKit.DrawText("Instructions:", Color.Beige, "ThaleahFat.ttf", 25, 225, 250);
            SplashKit.DrawText("Use arrow keys to move the player", Color.Beige, "ThaleahFat.ttf", 25, 230, 270);
            SplashKit.DrawText("Click Start button to play", Color.Beige, "ThaleahFat.ttf", 24, 240, 320);

            //make button
            Rectangle startButton = new Rectangle();
            startButton.X = 280;
            startButton.Y = 360;
            startButton.Width = 200;
            startButton.Height = 50;

            SplashKit.FillRectangle(Color.Aqua, startButton);
            SplashKit.DrawText("Start", Color.Black, "ThaleahFat.ttf", 40, 330, 360);

            // Check for mouse click event on the start button
            if (SplashKit.MouseClicked(MouseButton.LeftButton) && SplashKit.PointInRectangle(SplashKit.MousePosition(), startButton))
            {
                _startClicked = true;
            }
        }
    }
}