using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Spel
{
    class Fiende : Bas
    {
        private int timer = 20;
        private Random random = new Random();
        public Fiende(Texture2D bild, Vector2 vector) 
        {
            pixel = bild;
            pos = vector;
        }

        public Vector2 Pos
        {
            get
            {
                return pos;
            }
        }
        
        private enum direction
        {
            Up,
            Down,
            Left,
            Right
        }

        private direction dirren = direction.Down;

        public void Update() 
        {
            if (timer == 0)
            {
                timer = random.Next(20, 50);

                control();
            }
            Movement();
            timer--;
        }

        private void control() 
        {
            int r = random.Next(0, 4);
            if (r == 0)
            {
                dirren = direction.Down;
            }
            else if (r == 1)
            {
                dirren = direction.Up;
            }
            else if (r == 2)
            {
                dirren = direction.Left;
            }
            else if (r == 3)
            {
                dirren = direction.Right;
            }

            if (pos.Y > 460 ) 
            {
                dirren = direction.Up;
            }
            if (pos.Y < 0)
            {
                dirren = direction.Down;
            }
            if (pos.X > 820)
            {
                dirren = direction.Left;
            }
            if (pos.X < 0)
            {
                dirren = direction.Right;
            }
        }

        private void Movement() 
        {
            if (dirren == direction.Down) 
            {
                pos.Y++;
            }
            if (dirren == direction.Up)
            {
                pos.Y--;
            }
            if (dirren == direction.Left)
            {
                pos.X--;
            }
            if (dirren == direction.Right)
            {
                pos.X++;
            }
        }

    }
}
