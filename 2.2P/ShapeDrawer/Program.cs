using SplashKitSDK;
namespace ShapeDrawer
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window(“Shape Drawer”, 800,
            600);
            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();
                SplashKit.RefreshScreen();
            } while (!window.CloseRequested);
        }
    }
}
Page of2 5
