using System;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

namespace ArtillerySharp
{
    class Program
    {
        static void Main()
        {
            GameWindowSettings gameWindowSettings = new GameWindowSettings()
            {
                IsMultiThreaded = false,
                RenderFrequency = 60,
                UpdateFrequency = 60,
            };
            NativeWindowSettings nativeWindowSettings = new NativeWindowSettings()
            {
                API = ContextAPI.OpenGL,
                APIVersion = new Version(3, 3),
                IsFullscreen = false,
                Title = "Artillery#",
                WindowBorder = WindowBorder.Fixed,
                Size = new Vector2i(1280, 720),
            };

            using (Game game = new Game(gameWindowSettings, nativeWindowSettings))
            {
                game.Run();
            }
        }
    }
}
