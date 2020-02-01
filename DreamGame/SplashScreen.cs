using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DreamGame
{
    public class SplashScreen : GameScreen
    {
        public Image Image;

        public override void LoadContent()
        {
            base.LoadContent();
            Image.LoadContent();
            Image.FadeEffect.FadeSpeed = 0.5f;
        }
        public override void UnloadContent()
        {
            base.UnloadContent();
            Image.UnloadContent();
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            Image.Update(gameTime);

            //if (Keyboard.GetState().IsKeyDown(Keys.Enter) && !ScreenManager.Instance.IsTransitioning)
            //  ScreenManager.Instance.ChangeScreens("SplashScreen");

            if (InputManager.Instance.KeyPressed(Keys.Enter, Keys.Z))
                ScreenManager.Instance.ChangeScreens("SplashScreen");
                
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            //base.Draw(spriteBatch);
            Image.Draw(spriteBatch);
        }
    }
}