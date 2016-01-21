using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Reflection;

namespace Drive
{
    public class Car
    {
        //initialize direction element
        public enum Directions
        {
            Left,
            Right,
            Up,
            Down
        }
        private Directions direction;
        public Directions Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        //initialize color element
        public int color;

        public int COLOR
        {
            get { return color; }
        }

        //initialize CarBody element
        private List<CarBody> body = new List<CarBody>();
        public List<CarBody> Body
        {
            get { return body; }

        }

        public bool Dead = false;
        private int InitialV = 0;
        //initialize Car
        public Car(int initialValue, int color)
        {
            //PickBrush();
            if (initialValue == 0)
            {
                InitialV = initialValue;
                direction = Directions.Left;
            }
            else if (initialValue == 1)
            {
                InitialV = initialValue;
                direction = Directions.Up;
            }
            else if (initialValue == 2)
            {
                InitialV = initialValue;
                direction = Directions.Right;
            }
            else
            {
                InitialV = initialValue;
                direction = Directions.Down;
            }
            this.color = color;
            AddEnd(); AddEnd();
        }

        /*
        //initialize a random color
        private void PickBrush()
        {

            Random rnd = new Random();

            Type brushesType = typeof(Brushes);

            PropertyInfo[] properties = brushesType.GetProperties();
            while (color == Brushes.White)
            {
                int random = rnd.Next(properties.Length);
                color = (Brush)properties[random].GetValue(null, null);
            }
        }
        */
        //add a CarBody to the end of the player
        public void AddEnd()
        {
            if (Body.Count > 0)
            {
                CarBody lastBlock = Body[Body.Count - 1];
                int x = 0;
                int y = 0;
                int step = CarBody.Size * 2;
                switch (Direction)
                {
                    case Directions.Left:
                        x = lastBlock.Location.X + step;
                        y = lastBlock.Location.Y;
                        break;
                    case Directions.Right:
                        x = lastBlock.Location.X - step;
                        y = lastBlock.Location.Y;
                        break;
                    case Directions.Up:
                        x = lastBlock.Location.X;
                        y = lastBlock.Location.Y + step;
                        break;
                    case Directions.Down:
                        x = lastBlock.Location.X;
                        y = lastBlock.Location.Y - step;
                        break;
                    default:
                        break;
                }
                Body.Add(new CarBody(lastBlock.Location.X, lastBlock.Location.Y, COLOR));
            }
            else
            {
                if (Direction == Directions.Left)
                {
                    Body.Add(new CarBody(500, 350, COLOR));
                }
                else if (Direction == Directions.Up)
                {
                    Body.Add(new CarBody(600, 300, COLOR));
                }
                else if (Direction == Directions.Right)
                {
                    Body.Add(new CarBody(700, 350, COLOR));
                }
                else if (Direction == Directions.Down)
                {
                    Body.Add(new CarBody(600, 400, COLOR));
                }
            }

        }

        //update direction
        public void Update()
        {
            UpdateCar(direction);
        }

        public void UpdateCar(Directions newDirection)
        {
            direction = newDirection;

            for (int i = Body.Count - 1; i > 0; i--)
            {
                CarBody leader = Body[i - 1];
                Body[i].Update(leader.Location.X, leader.Location.Y);
            }

            //head changes direction
            CarBody head = Body[0];
            int x = 0, y = 0;
            int step = CarBody.Size * 2;
            switch (Direction)
            {
                case Directions.Left:
                    x = head.Location.X - step;
                    y = head.Location.Y;
                    break;
                case Directions.Right:
                    x = head.Location.X + step;
                    y = head.Location.Y;
                    break;
                case Directions.Up:
                    x = head.Location.X;
                    y = head.Location.Y - step;
                    break;
                case Directions.Down:
                    x = head.Location.X;
                    y = head.Location.Y + step;
                    break;
                default:
                    break;
            }
            head.Update(x, y);
        }
        public void HitSelf()
        {
            CarBody head = Body[0];
            bool crash = false;
            for (int i = 1; i < Body.Count; i++)
            {
                crash = head.recBody.IntersectsWith(Body[i].recBody);
                if (crash)
                    Dead = true;

            }
        }

        public void HitSelf(Rectangle rect)
        {
            bool crash = false;
            for (int i = 1; i < Body.Count; i++)
            {
                crash = rect.IntersectsWith(Body[i].recBody);
                if (crash)
                    Dead = true;
            }
        }

        public void crashBoundary()
        {
            CarBody head = Body[0];
            int step = CarBody.Size;
            if ((head.Location.X <= 0) || (head.Location.X >= (1200)))
                Dead = true;
            if ((head.Location.Y <= 0) || (head.Location.Y >= (700)))
                Dead = true;
        }

        public bool isDead()
        {
            return Dead;
        }
        public void setDead(bool dead)
        {
            Dead = dead;
        }
        public void reset()
        {
            if (InitialV == 0)
            {
                direction = Directions.Left;
            }
            else if (InitialV == 1)
            {
                direction = Directions.Up;
            }
            else if (InitialV == 2)
            {
                direction = Directions.Right;
            }
            else
            {
                direction = Directions.Down;
            }
            body.Clear();
            AddEnd();
            Dead = false;
        }
        public void Draw(Graphics g)
        {

            for (int i = 0; i < Body.Count; i++)
            {
                Body[i].Draw(g);
            }
        }
    }

}

