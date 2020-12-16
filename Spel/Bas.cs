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
    class Bas
    {
        protected Texture2D pixel;
        protected Vector2 pos;
        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(pixel, new Rectangle(pos.ToPoint(), new Point(10, 10)), Color.White);
        }
    }
}