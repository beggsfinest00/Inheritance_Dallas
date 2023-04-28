using System;

namespace Inheritance_Dallas
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //assigning a value to myFPS and asinging words to values.
            FPS myFPS = new FPS("E", "ZombCube");

            Console.WriteLine(myFPS.Describe());
            myFPS.PlayGame();

            //assigning a value to csGo and asinging words to values.
            FPS csGo = new FPS("M", "CS:GO");
            Console.WriteLine(csGo.Describe());
            csGo.PlayGame();
        }
    }
}
