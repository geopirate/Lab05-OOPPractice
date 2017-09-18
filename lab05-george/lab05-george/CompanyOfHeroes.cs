using System;
using System.Collections.Generic;
using System.Text;

namespace lab05george
{
    class CompanyOfHeroes : Modern
    {
        // this is the constructor from the base class
        // it interacts with the title method also passed from the base class
        public CompanyOfHeroes(string title) : base(title) { }
        // implements Races and seals it so derived classes can't change this
        internal sealed override void Scale() => Console.WriteLine("a smaller squad based scale.");
        // just a local method
        internal void WW2() => Console.Write(
            "  This game used a World War 2 setting and ");
    }
}