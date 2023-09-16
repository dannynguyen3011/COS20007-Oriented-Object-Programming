using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using _6_3D;
using System.Threading.Tasks;

namespace _6._3D
{
    public class Player:GameObject
    { 
      
        public Sprite player_sp;
        private int _score;
        private int _lives;
        private int _hscore;

        public Player()
        {
            
            SplashKit.LoadBitmap("player", "monster.png");
            Bitmap = SplashKit.BitmapNamed("player");
            player_sp = SplashKit.CreateSprite(Bitmap);
            _score = 0;
            _lives = 3;
            
        }
        public bool CollideBomb(Bomb bomb)
        {
          
            return SplashKit.SpriteCollision(player_sp, bomb.Sprite);
        }
        public bool CollideFood(Food food)
        {

            return SplashKit.SpriteCollision(player_sp, food.Sprite);
        }
        public bool CollideEnergy(Energy energy)
        {
            return SplashKit.SpriteCollision(player_sp, energy.Sprite);
        }
        public bool CollideDonut(Donut donut)
        {
            return SplashKit.SpriteCollision(player_sp, donut.Sprite);
        }
        public int Lives
        {
            get { return _lives; }
        }

        public int Score
        {
            get { return _score; }
        }

        public int Hscore
        {
            get { return _hscore; }
            set { _hscore = value; } 
        }

        public void SaveScore()
        {
            if (_hscore < _score )
            {
                _hscore = _score;
            }
        }

        public void TakeDamage() 
        {
            _lives--;
        }
        public void GainLives()
        {
            _lives++;
        }
        public void IncreaseScore() 
        {
            _score += 10;
        }
        public void BuffScore()
        { 
           _score += 100;
            
        }
        public void Draw()
        {
            player_sp.Draw();
        }
        public void Reset()
        {
            _score = 0;
            _lives = 3;
            player_sp.Draw();
        }
        public void Update(bool gameover)
        {
            if (!gameover) { 
            if (SplashKit.KeyDown(KeyCode.UpKey) && (location_y >= 0))
            {
                location_y -= (float)0.3;
                SplashKit.SpriteSetY(player_sp, location_y);
             
            }
            if (SplashKit.KeyDown(KeyCode.DownKey) && (location_y <= 505))
            {
                location_y += (float)0.3;
                SplashKit.SpriteSetY(player_sp, location_y);
            }
            if (SplashKit.KeyDown(KeyCode.LeftKey) && (location_x >= 0))
            {
                location_x -= (float)0.3;
                SplashKit.SpriteSetX(player_sp, location_x);

            }
            if (SplashKit.KeyDown(KeyCode.RightKey) && (location_x <= 700)) 
            {
                location_x += (float)0.3;
                SplashKit.SpriteSetX(player_sp, location_x);
            }
        }}

        
    }
}
