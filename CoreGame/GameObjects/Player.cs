using PerishedEngine.GameObjects;
using PerishedEngine.Graphics;
using PerishedEngine.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace CoreGame.GameObjects
{
    public class Player : GameObject
    {

        private Animation idle;

        /// <summary>
        /// Override init
        /// </summary>
        public override void Init()
        {
            position = new Vector2(350, 270);
            sprite = ResourceManager.Instance.getSprite("Player");
            idle = new Animation();
            idle.Init(sprite, 16, 32, 0, 4, 200, true);
        }

        public override void Update(GameTime gameTime)
        {
            idle.Update(gameTime, position);
        }

        public override void Draw()
        {
            idle.Draw();
        }

    }
}
