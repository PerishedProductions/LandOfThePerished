using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerishedEngine.Graphics
{
    public class Tileset
    {
        public Texture2D sprite { get; set; }
        public Rectangle[] rects { get; set; }

        public void Init(int tilesetWidth, int tilesetHeight, int tileWidth, int tileHeight)
        {
            rects = new Rectangle[tilesetHeight * tilesetWidth];

            int count = 0;
            for (int y = 0; y < tilesetHeight; y++)
            {
                for (int x = 0; x < tilesetWidth; x++)
                {
                    if (count == 1)
                    {
                        rects[count] = new Rectangle(0, 0, tileWidth, tileHeight);
                    }

                    if (count != 1)
                    {
                        rects[count] = new Rectangle(x * tileWidth, y * tileHeight, tileWidth, tileHeight);
                    }
                    count++;
                }
            }
        }

    }
}
