//using Tao.Sdl;
//using System.Collections.Generic;
//using MyGame.Scripts.UI;
//using MyGame.Scripts.Objects;
//using System.Runtime.CompilerServices;

//namespace MyGame.Scripts.Managers
//{
//    public class UIManager
//    {
//        private static UIManager _instance = new UIManager();
//        public static UIManager instance => _instance;

//        private List<UIElements> activeUIElements = new List<UIElements>();

//        private Image backgroundMenu;
//        private Image playButtonImage;
//        private Image backgroundGame1;
//        private Image switchButtonImage;
//        private Image backgroundResults;
//        private FlagScreenResults screenResults;


//        // UI ELEMENTS RESPONSIVE PARAMETERS
//        private Vector2 _playButtonSize;
//        private Vector2 _playButtonPos;

//        private Vector2 _titleSize;
//        private Vector2 _titlePos;

//        private Vector2 _scoreSize;
//        private Vector2 _scorePos1;
//        private Vector2 _scorePos2;

//        private Vector2 _playerTurnSize;
//        private Vector2 _playerTurnPos;

//        private Vector2 _swictchButtonSize;
//        private Vector2 _swictchButtonPos;



//        ////////////////////////////
//        private Font textFont;
//        private Font titleFont;

//        private float _normalTextSize = (Engine.WIDTH / Engine.HEIGHT) * 20;
//        private float _titleTextSize = (Engine.WIDTH / Engine.HEIGHT) * 50;


//        private Sdl.SDL_Color white = new Sdl.SDL_Color { r = 255, g = 255, b = 255 };


//        ///////////////////////////
//        private UIManager()
//        {
//            LoadAssets();
//        }

//        public void LoadAssets()
//        {
//            backgroundMenu = Engine.LoadImage("assets/UI/Backgrounds/bgMenu.jpg");
//            backgroundGame1 = Engine.LoadImage("assets/UI/Backgrounds/bgGame.jpg");
//            switchButtonImage = Engine.LoadImage("assets/UI/Backgrounds/images.jpg");
//            backgroundResults = Engine.LoadImage("assets/UI/Backgrounds/resultsBackground.jpg");
//            playButtonImage = Engine.LoadImage("assets/UI/Backgrounds/playButton.png");


            

//            textFont = Engine.LoadFont("assets/Fonts/Minecraft.ttf", (short)_normalTextSize);
//            titleFont = Engine.LoadFont("assets/Fonts/Minecraft.ttf", (short)_titleTextSize);

//            screenResults = new FlagScreenResults();

//            //Play Button Pos & Size
//            _playButtonSize = new Vector2(Engine.WIDTH /5 , Engine.HEIGHT / 6);
//            _playButtonPos = new Vector2(Engine.WIDTH / 2 - (_playButtonSize.x /2), Engine.HEIGHT /3);

//            //Game Title Pos & Size
//            _titleSize = new Vector2(Engine.WIDTH/3, Engine.HEIGHT/5);
//            _titlePos = new Vector2(  (Engine.WIDTH /2 - (_titleSize.x /2))  ,  (Engine.HEIGHT / 5)  );

//            //Score Pos & Size
//            _scoreSize = new Vector2(Engine.WIDTH /6 , Engine.HEIGHT /8);
//            _scorePos1 = new Vector2(  (Engine.WIDTH /8 - (_scoreSize.x /2))  ,  (Engine.HEIGHT /16));
//            _scorePos2 = new Vector2(  ((Engine.WIDTH / 8) * 7 ) , (Engine.HEIGHT / 16));

//            //Player Turn Pos & Size
//            _playerTurnSize = new Vector2(Engine.WIDTH / 3, Engine.HEIGHT / 4);
//            _playerTurnPos = new Vector2(  (Engine.WIDTH /2 - _playerTurnSize.x /2 )  , (Engine.HEIGHT /16)  );

//            //Switch Button Pos & Size
//            _swictchButtonSize = new Vector2(Engine.WIDTH /8 , Engine.HEIGHT /3);
//            _swictchButtonPos = new Vector2(  ( (Engine.WIDTH /6) - (_swictchButtonSize.x /2) )  ,  (Engine.HEIGHT /2) - (_swictchButtonSize.y /2));
//        }

//        /// <summary>
//        /// Method to show the main menu UI
//        /// </summary>
//        public void ShowMainMenu()
//        {
//            activeUIElements.Clear();       
            
//            activeUIElements.Add(new UIImage(backgroundMenu, 0, 0, Engine.WIDTH, Engine.HEIGHT));
//            activeUIElements.Add(new UIButton(playButtonImage, (int)_playButtonPos.x, (int)_playButtonPos.y, (int)_playButtonSize.x, (int)_playButtonSize.x, () => { GameController.instance.sceneManager.LoadScene(ProgramState.GAME); }));
//            activeUIElements.Add(new UIText((int)_titlePos.x, (int)_titlePos.y, (int)_titleSize.x, (int)_titleSize.y, "¡Bienvenido a Jenga!", titleFont, white));
//        }
//        /// <summary>
//        /// Method to show the game HUD
//        /// </summary>
//        public void ShowGameHUD()
//        {
//            activeUIElements.Clear();

//            //Background position always 0,0
//            activeUIElements.Add(new UIImage(backgroundGame1, 0, 0, Engine.WIDTH, Engine.HEIGHT));

//            //In-game HUD
//            activeUIElements.Add(new UIText((int)_scorePos1.x, (int)_scorePos1.y, (int)_scoreSize.x, (int)_scoreSize.y, "Puntos P1: " + GameController.instance.gameSystem.scoreManager.GetP1Score().ToString(), textFont, white));
//            activeUIElements.Add(new UIText((int)_scorePos2.x, (int)_scorePos2.y, (int)_scoreSize.x, (int)_scoreSize.y, "Puntos P2: " + GameController.instance.gameSystem.scoreManager.GetP2Score().ToString(), textFont, white));
//            //Switch View Button
//            activeUIElements.Add(new UIButton(switchButtonImage, (int)_swictchButtonPos.x, (int)_swictchButtonPos.y, (int)_swictchButtonSize.x, (int)_swictchButtonSize.y, () => { GameController.instance.gameSystem.CallSwitchView(); }));

//            if (GameController.instance.gameSystem.GetP1TurnState())
//            {
//                activeUIElements.Add(new UIText((int)_playerTurnPos.x, (int)_playerTurnPos.y, (int)_playerTurnSize.x, (int)_playerTurnSize.y, "Es turno del Player 1", titleFont, white));
//            }
//            else if (GameController.instance.gameSystem.GetP2TurnState())
//            {
//                activeUIElements.Add(new UIText((int)_playerTurnPos.x, (int)_playerTurnPos.y, (int)_playerTurnSize.x, (int)_playerTurnSize.y, "Es turno del Player 2", titleFont, white));
//            }
//        }
//        /// <summary>
//        /// Method to show the pause menu UI
//        /// </summary>
//        public void ShowPauseMenu()
//        {
//            activeUIElements.Clear();
//        }
//        /// <summary>
//        /// Method to show the game results UI
//        /// </summary>
//        public void ShowResults()
//        {
//            activeUIElements.Clear();

//            activeUIElements.Add(new UIImage(backgroundResults, 0, 0, Engine.WIDTH, Engine.HEIGHT));

//            if (GameController.instance.gameSystem.scoreManager.P1WinThroughPoints())
//            {
//                activeUIElements.Add(new UIText((int)_playerTurnPos.x, (int)_playerTurnPos.y, (int)_playerTurnSize.x, (int)_playerTurnSize.y, "Ganador es P1", titleFont, white));
//                activeUIElements.Add(new UIText((int)_scorePos1.x, (int)_scorePos1.y, (int)_scoreSize.x, (int)_scoreSize.y, "Puntos P1: " + GameController.instance.gameSystem.scoreManager.GetP1Score().ToString(), textFont, white));
//                activeUIElements.Add(new UIText((int)_scorePos2.x, (int)_scorePos2.y, (int)_scoreSize.x, (int)_scoreSize.y, "Puntos P2: " + GameController.instance.gameSystem.scoreManager.GetP2Score().ToString(), textFont, white));
//            }
//            else if (GameController.instance.gameSystem.scoreManager.P2WinThroughPoints())
//            {
//                activeUIElements.Add(new UIText((int)_playerTurnPos.x, (int)_playerTurnPos.y, (int)_playerTurnSize.x, (int)_playerTurnSize.y, "Ganador es P2", titleFont, white));
//                activeUIElements.Add(new UIText((int)_scorePos1.x, (int)_scorePos1.y, (int)_scoreSize.x, (int)_scoreSize.y, "Puntos P1: " + GameController.instance.gameSystem.scoreManager.GetP1Score().ToString(), textFont, white));
//                activeUIElements.Add(new UIText((int)_scorePos2.x, (int)_scorePos2.y, (int)_scoreSize.x, (int)_scoreSize.y, "Puntos P2: " + GameController.instance.gameSystem.scoreManager.GetP2Score().ToString(), textFont, white));
//            }
//            else if (GameController.instance.gameSystem.scoreManager.Draw())
//            {
//                activeUIElements.Add(new UIText((int)_playerTurnPos.x, (int)_playerTurnPos.y, (int)_playerTurnSize.x, (int)_playerTurnSize.y, "Empate", titleFont, white));
//                activeUIElements.Add(new UIText((int)_scorePos1.x, (int)_scorePos1.y, (int)_scoreSize.x, (int)_scoreSize.y, "Puntos P1: " + GameController.instance.gameSystem.scoreManager.GetP1Score().ToString(), textFont, white));
//                activeUIElements.Add(new UIText((int)_scorePos2.x, (int)_scorePos2.y, (int)_scoreSize.x, (int)_scoreSize.y, "Puntos P2: " + GameController.instance.gameSystem.scoreManager.GetP2Score().ToString(), textFont, white));
//            }
//        }
//        /// <summary>
//        /// Update all the UIElements update method
//        /// </summary>
//        public void Update()
//        {
//            foreach (var element in activeUIElements)
//            {
//                element.Update();
//            }

//            if (GameController.instance.sceneManager.currentProgramState == ProgramState.RESULTS)
//            {
//                screenResults.Update();
//            }
//        }
//        /// <summary>
//        /// Render all the UIElements render method
//        /// </summary>
//        public void Render()
//        {       
//            foreach (var element in activeUIElements)
//            {
//                element.Render();
//            }

//            if (GameController.instance.sceneManager.currentProgramState == ProgramState.RESULTS)
//            {
//                screenResults.Render();
//            }
//        }     
//    }
//}
