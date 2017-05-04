using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using PerishedEngine.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerishedEngine.Graphics
{
    public class Animation
    {

        private Texture2D sprite;

        private int elapsedTime;
        private int frameTime;
        private int frameCount;
        private int frameRow;
        private int currentFrame;

        private Rectangle sourceRect;
        private Rectangle destinationRect;

        int frameHeight;
        int frameWidth;

        public bool active = true;
        public bool looping;

        /// <summary>
        /// Init for Animation
        /// </summary>
        /// <param name="sprite">The sprites sheet</param>
        /// <param name="frameWidth">the individual frame width</param>
        /// <param name="frameHeight">the individual frame height</param>
        /// <param name="frameRow">what row the fram is in</param>
        /// <param name="frameCount">how many frames there is</param>
        /// <param name="frametime">how long the frames should last</param>
        /// <param name="looping">if the animation will loop</param>
        public void Init(Texture2D sprite, int frameWidth, int frameHeight, int frameRow, int frameCount, int frametime, bool looping)
        {
            this.sprite = sprite;
            this.frameWidth = frameWidth;
            this.frameHeight = frameHeight;
            this.frameCount = frameCount;
            this.frameTime = frametime;
            this.looping = looping;
            this.frameRow = frameRow;
        }

        /// <summary>
        /// Update for Animation
        /// </summary>
        public void Update(GameTime gameTime, Vector2 position)
        {
             if (active == false)
            {
                return;
            }

            elapsedTime += (int)gameTime.ElapsedGameTime.TotalMilliseconds;

            if (elapsedTime > frameTime)
            {
                currentFrame++;

                if (currentFrame == frameCount)
                {
                    currentFrame = 0;

                    if (looping == false)
                    {
                        active = false;
                    }
                }

                elapsedTime = 0;
            }

            sourceRect = new Rectangle(currentFrame * frameWidth, frameRow * frameHeight, frameWidth, frameHeight);

            destinationRect = new Rectangle((int)position.X - frameWidth / 2, (int)position.Y - frameHeight / 2, frameWidth, frameHeight);
        }

        /// <summary>
        /// Draw for Animation
        /// </summary>
        public void Draw()
        {
            GraphicsManager.Instance.DrawSprite(sprite, destinationRect, sourceRect, Color.White);
        }
    }
}
