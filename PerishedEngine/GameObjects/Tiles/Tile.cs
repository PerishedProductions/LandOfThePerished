using Microsoft.Xna.Framework;
using PerishedEngine.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerishedEngine.GameObjects.Tiles
{
    public class Tile : GameObject
    {
        public int tileID { get; set; } = 0;
        private Rectangle sourceRect;

        /// <summary>
        /// Override Init for GameObjects
        /// </summary>
        public void Init(int id, Rectangle rect)
        {
            this.tileID = id;
            sourceRect = rect;
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
            GraphicsManager.Instance.DrawSprite(sprite, position, sourceRect, Color.White);
        }

    }
}
