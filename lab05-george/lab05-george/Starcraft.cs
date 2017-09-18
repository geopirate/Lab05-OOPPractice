using System;

namespace lab05george
{
    internal class Starcraft : Classic
    {
        // this is the constructor from the base class
        // it interacts with the title method also passed from the base class
        internal Starcraft(string title) : base(title){}
        // implements Races and seals it so derived classes can't change this
        internal sealed override void Races() => Console.WriteLine("3 races.");
        // just a local method
        internal void Blizzard() => Console.Write(
            "  This game uses Blizzard's unique style of strategy with "); 
    }
}
