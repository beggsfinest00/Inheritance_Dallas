using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Dallas
{
    class FPS : Game
    {
        //adding estbParam and titleParam then calls upon them from another class.
        public FPS(string esrbParam, string titleParam) : base(esrbParam, titleParam)
        {
            Title = titleParam;
            Esrb = esrbParam;
        }

        //overides the abstract string and assigns a return to it to later be called on.
        public override string Describe() 
        {
            return $"{Title} is a fps game rated {Esrb}!";
        }
    }
}
