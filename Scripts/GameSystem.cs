//using MyGame.Scripts.Managers;
//using MyGame.Scripts.Objects;
//using System.Diagnostics;
//using Tao.Sdl;

//namespace MyGame.Scripts.Systems
//{
//    public class GameSystem
//    {
//        private readonly static GameSystem _instance = new GameSystem();
//        public static GameSystem instance => _instance;

//        public ScoreManager scoreManager;
//        private Player player1;
//        private Player player2;

//        //JENGA STRUCTURE
//        private JengaStructure jenga;

//        //Block Refs
//        public Block block = null;
//        private int _blockIndex;
//        private int _blockBatchIndex;
//        private int _batchIndex;
//        private int _blockCount;

//        //Block Data ///////////////////
//        public int BlockIndex
//        {
//            get { return _blockIndex; }
//            set { _blockIndex = value; }
//        }
//        public int BlockBatchIndex
//        {
//            get { return _blockBatchIndex; }
//            set { _blockBatchIndex = value; }
//        }
//        public int BatchIndex
//        {
//            get { return _batchIndex; }
//            set { _batchIndex = value; }
//        }
//        public int BlockCount
//        {
//            get { return _blockCount; }
//            set { _blockCount = value; }
//        }

//        //////////////////////////////

//        //Minigame
//        public Minigame miniGame;

//        private bool p1Turn = true;
//        private bool p2Turn = false;

//        private float _pointsToWin = 5f;
//        private float _points = 1f;


//        private GameSystem()
//        {
//            Initialize();
//        }

//        public void Initialize()
//        {
//            player1 = new Player(p1Turn);
//            player2 = new Player(p2Turn);
//            scoreManager = new ScoreManager(_pointsToWin);

//            jenga = new JengaStructure(8);
//            miniGame = new Minigame(2.0f, 2.0f);
//        }


//        /// <summary>
//        /// Update game elements
//        /// </summary>
//        public void UpdateGame()
//        {
//            jenga.UpdateMouseInteraction(new Vector2(Engine.GetMousePosition().x, Engine.GetMousePosition().y));

//            CallMiniGame();
//            ActiveMiniGame();
//            miniGame.Update();
//            scoreManager.CheckWinnerThroughPoints();
//        }

//        /// <summary>
//        /// Render game elements
//        /// </summary>
//        public void RenderGame()
//        {
//            jenga.Render();
//            miniGame.Render();
//        }

//        /// <summary>
//        /// Call to change the player turns
//        /// </summary>
//        public void SwapPlayerTurn()
//        {
//            if (player1.GetTurn() && !player2.GetTurn())
//            {
//                p1Turn = false;
//                player1.SetTurn(p1Turn);
//                p2Turn = true;
//                player2.SetTurn(p2Turn);
//                Engine.Debug("El turno de P1: " + player1.myTurn + " termino. Es el turno de P2: " + player2.myTurn);
//            }
//            else if (!player1.GetTurn() && player2.GetTurn())
//            {
//                p2Turn = false;
//                player2.SetTurn(p2Turn);
//                p1Turn = true;
//                player1.SetTurn(p1Turn);
//                Engine.Debug("El turno de P2: " + player2.myTurn + " termino. Es el turno de P1: " + player1.myTurn);
//            }
//        }

//        /// <summary>
//        /// Check if there's a block reference stored. If its not null it will call his method CallMinigame().
//        /// </summary>
//        public void CallMiniGame()
//        {
//            if (block == null)
//            {
//                return;
//            }
//            else
//            {
//                if (!miniGame.Running)
//                {
//                    miniGame.Running = true;
//                }
//            }
//        }

//        /// <summary>
//        /// If Minigame is active, this allows interaction with the minigame
//        /// </summary>
//        public void ActiveMiniGame()
//        {
//            if (!miniGame.Running) return;

//            //Interaction with Minigame
//            if (block != null)
//            {
//                Vector2 mousePos = Engine.GetMousePosition();
//                int mouseX = (int)mousePos.x;
//                int mouseY = (int)mousePos.y;
//                if (Engine.GetMouseButtonDown(Engine.MOUSE_RIGHT))
//                {
//                    miniGame.Running = false;
//                    miniGame.StopSlider();
//                    block = null;
//                }
//            }
//        }

//        /// <summary>
//        /// Check if any player miss the success box.
//        /// </summary>
//        public void CheckWinnerThroughMinigame()
//        {
//            if (GetP1TurnState() && !GetP2TurnState())
//            {
//                // P1 Lost
//                scoreManager.P1LostThroughMinigame();
//                GameController.instance.sceneManager.LoadScene(ProgramState.RESULTS);
//            }
//            else if (GetP2TurnState() && !GetP1TurnState())
//            {
//                // P2 Lost
//                scoreManager.P2LostThroughMinigame();
//                GameController.instance.sceneManager.LoadScene(ProgramState.RESULTS);
//            }
//        }

//        public void MinigameSuccess()
//        {
//            jenga.DeleteBlock(BlockIndex);
//        }

//        public void CallSwitchView()
//        {
//            jenga.SwitchView();
//        }

//        // Methods to get data
//        public bool GetP1TurnState() => player1.GetTurn();
//        public bool GetP2TurnState() => player2.GetTurn();
//        public float GetPoints() => _points;
//    }
//}