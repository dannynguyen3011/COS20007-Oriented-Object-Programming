using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace _6._3D
{
    public class Food : Projectile
    {
        public Food() : base() 
        {
            Bitmap = new Bitmap("Food", "burger.png");
            Sprite = SplashKit.CreateSprite(Bitmap);
            Random random = new Random();
            int x = random.Next(0, 700);
            int y = random.Next(600, 600);
            location_x = x; location_y = y;
            SplashKit.SpriteSetY(Sprite, location_y);
            SplashKit.SpriteSetX(Sprite, location_x);

        }

        public override void Update(bool gameover)
        {   
            if(!gameover)
            {
            location_y -= speed;
            SplashKit.SpriteSetY(Sprite, location_y);

            } 
            

        }



    }
}
