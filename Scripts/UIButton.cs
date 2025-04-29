//using System;
//using Tao.Sdl;

//namespace MyGame.Scripts.UI
//{
//    public class UIButton : UIElements
//    {
//        public Image image;
//        public Action onClick;

//        public UIButton(Image image, int posX, int posY, int width, int height, Action onClick)
//        {
//            this.image = image;
//            this.posX = posX;
//            this.posY = posY;
//            this.width = width;
//            this.height = height;
//            this.onClick = onClick;
//        }

//        public override void Update()
//        {
//            int mouseX, mouseY;
//            Sdl.SDL_GetMouseState(out mouseX, out mouseY);
//            bool mousePressed = (Sdl.SDL_GetMouseState(out mouseX, out mouseY) & Sdl.SDL_BUTTON(Sdl.SDL_BUTTON_LEFT)) != 0;
//            Sdl.SDL_PumpEvents();

//            if (mousePressed && mouseX >= posX && mouseX <= posX + width && mouseY >= posY && mouseY <= posY + height)
//            {
//                //Engine.Debug("Botón clickeado");
//                onClick?.Invoke();
//            }
//        }
//        public override void Render()
//        {
//            Engine.DrawImage(image, posX, posY, width, height);
//        }
//    }
//}
