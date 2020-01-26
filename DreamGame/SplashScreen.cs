using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DreamGame
{
    public class SplashScreen : GameScreen
    {
        //Texture2D devImage1;
        //Texture2D devImage2;
        Texture2D splashImage;
        public string Path;

        public override void LoadContent()
        {
            base.LoadContent();
            //devImage1 = content.Load<Texture2D>("ball");
            //devImage2 = content.Load<Texture2D>("quick");
            splashImage = content.Load<Texture2D>(Path);
        }
        public override void UnloadContent()
        {
            base.UnloadContent();
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
            spriteBatch.Begin();
            //spriteBatch.DrawString(Sp,"Brought to you by ReckTek Games");
            //spriteBatch.Draw(devImage1, Vector2.Zero, Color.White);
            //spriteBatch.Draw(devImage2, Vector2.One, Color.White);
            spriteBatch.Draw(splashImage, Vector2.Zero, Color.White);
            spriteBatch.End();
        }
    }
}