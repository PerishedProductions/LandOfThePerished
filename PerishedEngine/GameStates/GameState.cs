using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerishedEngine.GameStates
{
    public class GameState
    {

        public Game game { get; set; }

        public virtual void Init()
        {

        }

        public virtual void Update(GameTime gameTime)
        {
        }

        public virtual void Draw()
        {
        }
    }
}
