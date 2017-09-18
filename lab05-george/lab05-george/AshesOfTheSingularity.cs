using System;
using System.Collections.Generic;
using System.Text;

namespace lab05george
{
    class AshesOfTheSingularity : Modern
    {
        // this is the constructor from the base class
        // it interacts with the title method also passed from the base class
        public AshesOfTheSingularity(string title) : base(title) { }
        // implements Races and seals it so derived classes can't change this
        internal sealed override void Scale() => Console.WriteLine("a larger epic scale.");
        // just a local method
        internal void Future() => Console.Write(
            "  This game used a futuristic setting and ");
    }
}