﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DreamGame
{
    public class ScreenManager
    {
        private static ScreenManager instance;
        public Vector2 Dimensions { private set; get; }
        public ContentManager Content { private set; get; }
        XmlManager<GameScreen> xmlGameScreenManager;

        GameScreen currentScreen;

        public static ScreenManager Instance
        {
            get
            {
            if (instance == null)
                instance = new ScreenManager(); 

             return instance;
            }
        }
        public ScreenManager()
        {
            Dimensions = new Vector2(640, 480);
            currentScreen = new SplashScreen();
            xmlGameScreenManager = new XmlManager<GameScreen>();
            xmlGameScreenManager.Type = currentScreen.Type;
            currentScreen = xmlGameScreenManager.Load("Content/Load/SplashScreen.xml");
        }
        public void LoadContent(ContentManager Content)
        {
            this.Content = new ContentManager(Content.ServiceProvider, "Content");
            currentScreen.LoadContent();
        }
        public void UnloadContent()
        {
            currentScreen.UnloadContent();
        }
        public void Update(GameTime gameTime)
        {
            currentScreen.Update(gameTime);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            currentScreen.Draw(spriteBatch);
        }
    }
}