//using Tao.Sdl;

//namespace MyGame.Scripts.UI
//{
//    public class UIText : UIElements
//    {
//        private string _text;
//        private Font font;
//        private Sdl.SDL_Color textColor;

//        public string text
//        {
//            get { return _text; }
//            set { _text = value; }
//        }

//        public UIText(int posX, int posY, int width, int height, string text, Font font, Sdl.SDL_Color color)
//        {
//            this.posX = posX;
//            this.posY = posY;
//            this.width = width;
//            this.height = height;
//            this.text = text;
//            this.font = font;
//            this.textColor = color;
//        }

//        public override void Update() { }

//        public override void Render()
//        {
//            Engine.DrawText(text, posX, posY, textColor, font);
//        }
//    }
//}