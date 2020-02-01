using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Xml.Serialization;

namespace DreamGame
{
    public class ImageEffect
    {
        protected Image image;
        public bool IsActive;

        public ImageEffect()
        {
            IsActive = false;
        }

        public virtual void LoadContent (ref Image Image)
        {
            this.image = Image;
        }

        public virtual void UnloadContent()
        {

        }

        public virtual void Update(GameTime gameTime)
        {

        }
    }
}
