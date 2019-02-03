using MyLibrary;
using Xenko.Engine;

namespace MyGame.Windows
{
    class MyGameApp
    {
        static void Main(string[] args)
        {
            var instance = new Class1();
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
