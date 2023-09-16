using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _6._3D
{
    public class Projectile : GameObject
    {
        public float mspeed = 0.5f;
        public float speed = 0.1f;
        public void Draw()
        {
            Sprite.Draw();
        }
        public virtual void Update(bool gameover)
        {

        }
        public void Reset()
        {
           
        }
    }
}
