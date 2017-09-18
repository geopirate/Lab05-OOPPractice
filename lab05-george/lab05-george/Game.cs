using System;

namespace lab05george
{
    // level 0 of inheritance, this is the base class
    internal abstract class Game
    {
        // this variable is encapsulated and passed down
        private string ThisTitle { get; set; }
        // this constructor sets the title of the object
        internal Game(string title)
        {
            ThisTitle = title;
        }
        // this is inherited by all derived classes in the project
        internal void Project() => Console.Write("These are all video games.");
        // this is inherited by all derived classes in the project
        // however it is implemented at the genre level (1)
        internal abstract void Genre();
        // this is inherited by all derived classes in the project
        // however it is virtual so it can be implemented optionally until the game level (3)
        internal virtual void Title() => Console.Write($"Title: {ThisTitle}  ");
    }
}
