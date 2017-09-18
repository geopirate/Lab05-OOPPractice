using System;

namespace lab05george
{
    class CommandAndConquer : Classic
    {
        // this is the constructor from the base class
        // it interacts with the title method also passed from the base class
        internal CommandAndConquer(string title) : base(title) { }
        // implements Races and seals it so derived classes can't change this
        internal sealed override void Races() => Console.WriteLine("2 races.");
        // just a local method
        internal void Westwood() => Console.Write(
            "  This game was a competitor to Starcraft with only ");
    }
}

