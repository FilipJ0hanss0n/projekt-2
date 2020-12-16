using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Spel
{
    class Fiendehanterar
    {
        private static int antal = 100;
        private Fiende[] fiende = new Fiende[antal];
        private Random random = new Random();
        private bool quit = false;
        public Fiendehanterar(Texture2D bild) 
        {
            for (int i = 0; i < antal; i++) 
            {
                fiende[i] = new Fiende(bild, new Vector2(random.Next(20,820),random.Next(20,460)));
            }

        }
        public bool Quit
        {
            get
            {
                return quit;
            }
        }
        public void Update() 
        {
            for (int i = 0; i < antal; i++) 
            {
                fiende[i].Update();

                if (Collision.Hit(fiende[i].Pos))
                {
                    quit = true;
                }
            }
        }
        public void Draw(SpriteBatch spriteBatch) 
        {
            for (int i = 0; i < antal; i++)
            {
                fiende[i].Draw(spriteBatch);
            }
        }

    }
}
