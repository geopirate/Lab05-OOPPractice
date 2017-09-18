using System;

namespace lab05george
{
    /* Game, RTS, RPG, Shooter are abstract as well as the entire next level
     * RTS, RPG and Shooter are the 3 lines of inheritance
     * all of the abstract classes have abstract methods
     * game, x and y have virtual methods
     * there are many overridden methods
     * there are 21 inherited classes
     * almost everything is internal as making things more private would require a more complicated program structure
     * encapsulation is shown in the ThisTitle field which is private
     * every override shows polymorphism
     */
    class Program
    {
        static void Main(string[] args)
        {
            Starcraft starcraft = new Starcraft("Starcraft 2");
            starcraft.Project();
            starcraft.Genre();
            starcraft.Graphics();
            starcraft.Title();
            starcraft.Blizzard();
            starcraft.Races();
            Console.WriteLine();
            CommandAndConquer command = new CommandAndConquer("Command and Conquer");
            command.Project();
            command.Genre();
            command.Graphics();
            command.Title();
            command.Westwood();
            command.Races();
            Console.WriteLine();
            AshesOfTheSingularity ashes = new AshesOfTheSingularity("Ashes of the Singularity");
            ashes.Project();
            ashes.Genre();
            ashes.Graphics();
            ashes.Title();
            ashes.Future();
            ashes.Scale();
            Console.WriteLine();
            CompanyOfHeroes company = new CompanyOfHeroes("Company Of Heroes");
            company.Project();
            company.Genre();
            company.Graphics();
            company.Title();
            company.WW2();
            company.Scale();
            Console.WriteLine();
            Console.Read();
        }
    }
}
// currently I would have 22 CS files, would it be easier for me and whoever has to grade this if I could group the classes into maybe 4 files?