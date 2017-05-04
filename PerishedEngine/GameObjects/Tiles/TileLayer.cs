using LitJson;
using Microsoft.Xna.Framework;
using PerishedEngine.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerishedEngine.GameObjects.Tiles
{
    public class TileLayer
    {
        public int[,] tileIds;
        public List<Tile> tiles = new List<Tile>();

        public void Init(int tileWidth, int tileHeight, int layerWidth, int layerHeight, JsonData layerIds, Tileset tileset)
        {
            int[,] mapIds = new int[layerWidth, layerHeight];

            for (int y = 0; y < layerHeight; y++)
            {
                for (int x = 0; x < layerWidth; x++)
                {
                    mapIds[x, y] = (int)layerIds[y * layerWidth + x];
                }
            }

            for (int x = 0; x < layerWidth; x++)
            {
                for (int y = 0; y < layerHeight; y++)
                {
                    int id = mapIds[x, y];

                    if (id != 0)
                    {
                        Tile newTile = new Tile();
                        newTile.position = new Vector2(x * tileWidth, y * tileHeight);
                        newTile.sprite = tileset.sprite;

                        newTile.Init(id, tileset.rects[id - 1]);
                        tiles.Add(newTile);
                    }
                }
            }
        }

        public void Draw()
        {
            for (int i = 0; i < tiles.Count; i++)
            {
                tiles[i].Draw();
            }
        }

    }
}
