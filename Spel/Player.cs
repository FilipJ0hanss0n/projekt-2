using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Spel
{
    class Player : Bas
    {
        private static Vector2 p;
        public Player(Texture2D skin, Vector2 coords)
        {
            pixel = skin;
            pos = coords;
        }

        public static Vector2 Pos
        {
            get { return p; }
        }
        public void Update()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                pos.Y -= 2;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                pos.Y += 2;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                pos.X -= 2;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                pos.X += 2;
            }
            p = pos;
        }
    }
}