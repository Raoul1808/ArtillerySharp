using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

namespace ArtillerySharp
{
    class Program
    {
        static void Main()
        {
            NativeWindowSettings nativeWindowSettings = new NativeWindowSettings()
            {
                Title = "Artillery#",
                Size = new Vector2i(1280, 720),
                WindowBorder = WindowBorder.Fixed,
                Flags = ContextFlags.ForwardCompatible,
            };

            using (Window window = new Window(GameWindowSettings.Default, nativeWindowSettings))
            {
                window.Run();
            }
        }
    }
}
