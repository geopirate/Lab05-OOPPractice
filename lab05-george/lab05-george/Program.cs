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
            // this order follows the diagram from right to left, the text is printed in a nice human readable format
            // RTS Classic
            CommandAndConquer command = new CommandAndConquer("Command and Conquer 3");
            command.Project();
            command.Genre();
            command.Graphics();
            command.Title();
            command.Westwood();
            command.Races();
            Console.WriteLine();
            Starcraft starcraft = new Starcraft("Starcraft 2");
            starcraft.Project();
            starcraft.Genre();
            starcraft.Graphics();
            starcraft.Title();
            starcraft.Blizzard();
            starcraft.Races();
            Console.WriteLine();
            // RTS Modern
            CompanyOfHeroes company = new CompanyOfHeroes("Company Of Heroes 2");
            company.Project();
            company.Genre();
            company.Graphics();
            company.Title();
            company.WW2();
            company.Scale();
            Console.WriteLine();
            AshesOfTheSingularity ashes = new AshesOfTheSingularity("Ashes of the Singularity");
            ashes.Project();
            ashes.Genre();
            ashes.Graphics();
            ashes.Title();
            ashes.Future();
            ashes.Scale();
            Console.WriteLine();
            // Shooter Realistic
            Arma arma = new Arma("Arma 4");
            arma.Project();
            arma.Genre();
            arma.Ammo();
            arma.Title();
            arma.TimeFrame();
            Console.WriteLine();
            Battlefield battlefield = new Battlefield("Battlefield 3");
            battlefield.Project();
            battlefield.Genre();
            battlefield.Ammo();
            battlefield.Title();
            battlefield.TimeFrame();
            Console.WriteLine();
            // Shooter ScienceFiction
            Console.WriteLine();
            Destiny destiny = new Destiny("Destiny 2");
            destiny.Project();
            destiny.Genre();
            destiny.Ammo();
            destiny.Title();
            destiny.Location();
            Console.WriteLine();
           Overwatch overwatch = new Overwatch("OVerwatch");
            overwatch.Project();
            overwatch.Genre();
            overwatch.Ammo();
            overwatch.Title();
            overwatch.Location();
            Console.WriteLine();
            Console.Read();
        }
    }
}
/* Using a problem domain from your background, create your own object class model using all 4 OOPs principles.
 * Be sure to include a drawn out diagram showing the relationship between your classes
 * Comment within your code where each OOPs principle is being used
 * Create methods in each class, No logic code is required other than Console.WriteLine when nececsary.
 * Clearly label each use of each OOP principle
 * Have at least:   3 abstract classes  3 lines of inheritance  3 abstract methods
 *      3 virtual methods   3 override methods (label what they are overriding and why)
 * Reason behind each access modifier - document what & why in code within comments */
