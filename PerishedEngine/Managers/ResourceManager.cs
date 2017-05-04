using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace PerishedEngine.Managers
{
    public class ResourceManager
    {
        private static ResourceManager instance;

        private ResourceManager() { }

        public static ResourceManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ResourceManager();
                }
                return instance;
            }
        }

        public Dictionary<string, Texture2D> Sprites = new Dictionary<string, Texture2D>();
        public Dictionary<string, SpriteFont> Fonts = new Dictionary<string, SpriteFont>();

        public ContentManager Content { get; set; }

        public void Init(ContentManager content)
        {
            this.Content = content;
        }

        public void AddSprite(string name, string path)
        {
            if (Content != null)
            {
                Sprites.Add(name, Content.Load<Texture2D>(path));
            }
        }

        public Texture2D getSprite(string name)
        {
            Texture2D tex;
            Sprites.TryGetValue(name ,out tex);
            if (tex != null)
            {
                return tex;
            }
            else
            {
                return null;
            }
        }

    }
}
