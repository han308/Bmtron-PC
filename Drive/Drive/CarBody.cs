using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Reflection;

namespace Drive
{
    public class CarBody
    {
        protected static int size = 5;
        public static int Size
        {
            get
            {
                return size;
            }
        }

        public Rectangle recBody = Rectangle.Empty;
        public int color;

        private Point location = Point.Empty;

        public Point Location
        {
            get { return location; }
            set
            {
                location = value;
                // create a rectangle body
                recBody = new Rectangle(location.X - size, location.Y - size, 10, 10);
            }
        }
        //initialize CarBody object
        public CarBody(int x, int y, int color)
        {
            Location = new Point(x, y);
            this.color = color;
        }

        public void Update(int x, int y)
        {
            Location = new Point(x, y);
        }


        public void Draw(Graphics g)
        {
            Brush b;
            if (color == 0)
            {
                b = Brushes.Black;
            }
            else if (color == 1)
            {
                b = Brushes.Green;
            }
            else if (color == 2)
            {
                b = Brushes.Blue;
            }
            else
            {
                b = Brushes.Orange;
            }

            g.FillRectangle(b, recBody);
        }

    }
}