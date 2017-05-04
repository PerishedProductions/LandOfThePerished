using PerishedEngine.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PerishedEngine.GameObjects
{
    public class GameObject
    {
        public Vector2 position { get; set; }
        public Texture2D sprite { get; set; }

        /// <summary>
        /// Base Init for GameObjects
        /// </summary>
        public virtual void Init()
        {
        }

        /// <summary>
        /// Base Update for GameObjects
        /// </summary>
        public virtual void Update(GameTime gameTime)
        {

        }

        /// <summary>
        /// Base Draw for GameObjects
        /// </summary>
        public virtual void Draw()
        {
            if (sprite != null)
            {
                GraphicsManager.Instance.DrawSprite(sprite, position, Color.White);
            }
        }
    }
}
