using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.IO;

namespace Spel
{
    class Timer
    {
        private int time;
        private SpriteFont text;
        private int temp;
        private int highscore;
        public Timer(SpriteFont s) 
        {
            text = s;
            time = 0;
            Init();
        }
        public void Update()
        { 
            temp++;
            time = temp / 60;
            if (time > highscore)
            {
                Write();
            }
        }
        public void Write()
        {
            highscore = time;
            BinaryWriter br = null;
            try
            {
                br= new BinaryWriter(
                    new FileStream("score.data",
                    FileMode.OpenOrCreate,
                    FileAccess.Write));
                br.Write(highscore);
                br.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (br != null)
                {
                    br.Close();
                }
            }
        }
        public void Init()
        {
            BinaryReader br = null;
            try
            {
                br = new BinaryReader(
                    new FileStream("score.data",
                    FileMode.OpenOrCreate,
                    FileAccess.Read));
                highscore = br.ReadInt32();
                br.Close();
            }
            catch
            {
                Write();
            }
            finally
            {
                if (br != null)
                {
                    br.Close();
                }
            }
        }
        public void Draw(SpriteBatch hej)
        {
            hej.DrawString(text, "time: " + time+"  highscore: "+highscore, new Vector2(10, 10), Color.Black);
        }
    }
}
