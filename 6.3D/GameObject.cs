using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3D
{
    public class GameObject
    {
        public Sprite _sprite;
        public float location_x;
        public float location_y;

        protected Bitmap _bitmap;


        public Sprite Sprite 
        { 
            get { return _sprite; } 
            set { _sprite = value; }

        }
        public Bitmap Bitmap
        {
            get { return _bitmap; }
            set { _bitmap = value; }

        }

        

    }
}
