using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerishedEngine.Graphics
{
    public class Animator
    {
        private Animation currentAnimation;

        //TODO: Look into changing this?
        //Inti (Constructor)
        public Animator(Animation startingAnimation)
        {
            currentAnimation = startingAnimation;
        }

        /// <summary>
        /// Changes the current animation
        /// </summary>
        /// <param name="animation">The new Animation</param>
        public void ChangeAnimation(Animation animation)
        {
            if (!currentAnimation.looping && !currentAnimation.active)
            {
                currentAnimation.active = true;
                currentAnimation = animation;
                return;
            }
            else if (currentAnimation.looping)
            {
                currentAnimation = animation;
                return;
            }
        }

        /// <summary>
        /// Updating the current animation
        /// </summary>
        /// <param name="gameTime">...</param>
        /// <param name="position">...</param>
        public void Update(GameTime gameTime, Vector2 position)
        {
            currentAnimation.Update(gameTime, position);
        }

        /// <summary>
        /// Drawing the current animation
        /// </summary>
        public void Draw()
        {

            currentAnimation.Draw();
        }
    }
}
