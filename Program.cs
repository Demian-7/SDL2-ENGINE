// Proyecto basado en el tutorial de https://jsayers.dev/c-sharp-sdl-tutorial-part-1-setup/
using MyGame;
using ProyectoSDL2.Engine;
using SDL2;
using System;
using System.Data;
using System.Media;



namespace ProyectoSDL2.Engine
{
    class Program
    {

        static Image image = Engine.LoadImage("assets/fondo.png");

        static void Main(string[] args)
        {
            Engine.Initialize();
            Time.Init();

            while (true)
            {

                CheckInputs();
                Update();
                Render();
                //SDL.SDL_Delay(20);
            }
        }

        static void CheckInputs()
        {
            if (Engine.GetKey(SDL.SDL_Scancode.SDL_SCANCODE_A))
            {
                Console.WriteLine("Se presiono la tecla A");
            }

            if (Engine.GetKeyDown(SDL.SDL_Scancode.SDL_SCANCODE_A))
            {
                Console.WriteLine("Se mantiene presionada la tecla A");
            }

            if (Engine.GetKeyUp(SDL.SDL_Scancode.SDL_SCANCODE_A))
            {
                Console.WriteLine("Se levanto la tecla A");
            }

            if (Engine.KeyPress(Engine.KEY_LEFT))
            {

            }

            if (Engine.KeyPress(Engine.KEY_LEFT))
            {

            }

            if (Engine.KeyPress(Engine.KEY_LEFT))
            {

            }

            if (Engine.KeyPress(Engine.KEY_ESC))
            {
                Environment.Exit(0);
            }
        }


        static void Update()
        {

        }

        static void Render()
        {
            Engine.Clear();
            Engine.Draw(image, 0, 0);
            Engine.Show();
        }
    }

}

