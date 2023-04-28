using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Dallas
{
    abstract class Game
    {
        /// <summary>
        /// makes a backing feild for Esrb and Title
        /// </summary>
        public string Esrb { get; set; }

        public string Title { get; set; }
        
        //initlizes Esrb and Title with a value.
        public Game(string esrbParam, string titleParam) 
        {
            Esrb = esrbParam;
            Title = titleParam;
        }
        
        /// <summary>
        /// prints the title and says it is starting.
        /// </summary>
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is Starting!");
        }

        //makes a abstract string.
        public abstract string Describe();
    }
}
