using System;

namespace lab05george
{
    class Arma : Realistic
    {
        // this is the constructor from the base class
        // it interacts with the title method also passed from the base class
        internal Arma(string title) : base(title) { }
        // this overrides TimeFrame, inherited from Realistic as a virtual class
        // This instance uses the past tense while Battlefield uses present tense
        internal override void TimeFrame() => Console.WriteLine("This occured in a historic time frame.");
    }
}
