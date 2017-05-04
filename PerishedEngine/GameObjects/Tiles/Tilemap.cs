using LitJson;
using Microsoft.Xna.Framework;
using PerishedEngine.Graphics;
using PerishedEngine.Managers;
using System.Collections.Generic;

namespace PerishedEngine.GameObjects.Tiles
{
    public class Tilemap : GameObject
    {
        private List<TileLayer> layers;
        private JsonData mapData;

        private int mapWidth;
        private int mapHeight;

        private int tileWidth;
        private int tileHeight;
        
        private Tileset tileset;

        /// <summary>
        /// Overload function Init. This loads the map
        /// </summary>
        /// <param name="mapData">Json data for loading the mao</param>
        public void Init(JsonData mapData)
        {
            this.mapData = mapData;

            mapWidth = (int)mapData["layers"][0]["width"];
            mapHeight = (int)mapData["layers"][0]["height"];

            tileWidth = (int)mapData["tilewidth"];
            tileHeight = (int)mapData["tileheight"];

            tileset = new Tileset();
            tileset.sprite = ResourceManager.Instance.getSprite("Overworld");
            tileset.Init((int)mapData["tilesets"][0]["imagewidth"] / tileWidth, (int)mapData["tilesets"][0]["imageheight"] / tileHeight, tileWidth, tileHeight);

            layers = new List<TileLayer>();

            for (int i = 0; i < mapData["layers"].Count; i++)
            {
                layers.Add(new TileLayer());
            }

            for (int i = 0; i < layers.Count; i++)
            {
                layers[i].Init(tileWidth, tileHeight, mapWidth, mapHeight, mapData["layers"][i]["data"], tileset);
            }
        }

        /// <summary>
        /// Base Update for GameObjects
        /// </summary>
        public override void Update(GameTime gameTime)
        {

        }

        /// <summary>
        /// Override Draw for GameObjects
        /// </summary>
        public override void Draw()
        {
            for (int i = 0; i < layers.Count; i++)
            {
                layers[i].Draw();
            }
        }
    }
}
