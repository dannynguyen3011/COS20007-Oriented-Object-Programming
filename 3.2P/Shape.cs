using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Shape
    {
        // Private member variables
        private Color _color;
        private float _x;
        private float _y;
        private float _width;
        private float _height;
        private bool _selected;

        // Constructor with x and y coordinates
        public Shape(int x, int y)
        {
            _color = Color.Green;
            _x = x;
            _y = y;
            _width = 100;
            _height = 100;
        }

        // Default constructor, invokes the constructor with x and y coordinates
        public Shape() : this(0, 0) { }

        // Public property for accessing the shape's color
        public Color Color => _color;

        // Public properties for accessing and modifying the shape's x and y coordinates
        public float X
        {
            get { return _x; }
            set { _x = value; }
        }

        public float Y
        {
            get { return _y; }
            set { _y = value; }
        }

        // Public properties for accessing and modifying the shape's width and height
        public float Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public float Height
        {
            get { return _height; }
            set { _height = value; }
        }

        // Public property for accessing and modifying the shape's selection state
        public bool Selected
        {
            get { return _selected; }
            set { _selected = value; }
        }

        // Method for drawing the shape on the screen
        public void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }
            SplashKit.FillRectangle(_color, _x, _y, _width, _height);
        }

        // Private method for drawing the outline of the shape
        private void DrawOutline()
        {
            SplashKit.DrawRectangle(Color.Black, _x + 2, _y - 2, _width + 2, _height - 2);
        }

        // Method for checking if a point is inside the shape's boundaries
        public bool IsAt(Point2D pt)
        {
            return SplashKit.PointInRectangle(pt, SplashKit.RectangleFrom(X, Y, Width, Height));
        }
    }
}

