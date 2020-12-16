using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.IO;

namespace Spel
{
    class Collision
    {
        public static bool Hit(Vector2 pos)
        {
            Vector2 p = Player.Pos+new Vector2(5,5);
            if (p.X > pos.X && p.X < pos.X + 10)
            {
                if (p.Y > pos.Y && p.Y < pos.Y + 10)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
