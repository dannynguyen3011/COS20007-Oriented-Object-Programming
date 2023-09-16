using ShapeDrawer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace _4._2
{
    public class MyLine : Shape
    {
        private int _length;

        public MyLine(int x, int y)
        {
            X = x;
            Y = y;
            Color = Color.Black;
            _length = 100;
        }

        public MyLine() : this(0, 0) 
        { }
        public override void Draw()
        {
            if(Selected)
            {
                DrawOutline();
            }
            SplashKit.DrawLine(Color.Black, X,Y, X + _length, Y);
        }
        public override void DrawOutline()
        {
            SplashKit.FillCircle(Color.Black, X, Y, 5);
            SplashKit.FillCircle(Color.Black, X + _length, Y, 5);
        }

        public override bool IsAt(Point2D pt)
        {
            return SplashKit.PointOnLine(pt, SplashKit.LineFrom(X, Y, X + _length, Y));
        }
    }
}
