using System;
using static System.Console;

namespace MonsterTownApp
{
    class Program
    {
        static void Main(string[] args)
        {

            

            string createName;
            Console.WriteLine("Please name your town: ");
            createName = Console.ReadLine();
            

            int createPopulation;
            Console.WriteLine("Please enter town population: ");
            createPopulation = int.Parse(Console.ReadLine());
            


            int createStopLights;
            Console.WriteLine("Please enter number of Stoplights in town: ");
            createStopLights = int.Parse(Console.ReadLine());


            Console.WriteLine("Your town is named " + createName + ". It has a population of " + createPopulation + " and " + createStopLights + " stoplights.");

            MonsterTownLib.Town userTown;

            userTown = new MonsterTownLib.Town(createName, createPopulation, createStopLights);

            
           

           

            string monsterChosen;
            Console.WriteLine("Is your monster a Mutant or a Vampire?");
            monsterChosen = Console.ReadLine();

            string finalChoice = monsterChosen.ToUpper();

            if(finalChoice == "VAMPIRE")
            {
                
                
                string vampireNameChoice;
                Console.WriteLine("You have chosen " + finalChoice + ". What would you like to name him/her?");
                vampireNameChoice = Console.ReadLine();


                MonsterTownLib.Vampire vampireName;

                vampireName = new MonsterTownLib.Vampire(vampireNameChoice);

                int destroyAnswer;
                Console.WriteLine("Would you like " + vampireNameChoice + " to:" + Environment.NewLine + "1. destroy your town?" + Environment.NewLine +  "Or" + Environment.NewLine + "2. leave the town in peace?");
                destroyAnswer = int.Parse(Console.ReadLine());

                if(destroyAnswer == 1)
                {
                    try
                    {
                        Console.WriteLine(vampireName.TerrorizeTown(userTown));
                    }
                    catch(ArgumentOutOfRangeException)
                    {
                        Console.WriteLine(vampireNameChoice + "Sorry! This town is abandoned." + vampireNameChoice + "gets bored and leaves.");
                        
                    };
                    


                }
                else
                {

                    Console.WriteLine(vampireNameChoice + " walks peacefully into the sunset... never to be seen again...");

                };



            }else
            {
                string mutantNameChoice;
                Console.WriteLine("You have chosen " + finalChoice + ". What would you like to name him/her?");
                mutantNameChoice = Console.ReadLine();


                MonsterTownLib.Mutant mutantName;

                mutantName = new MonsterTownLib.Mutant(mutantNameChoice, true);

                int destroyAnswer;
                Console.WriteLine("Would you like " + mutantNameChoice + " to:" + Environment.NewLine + "1. destroy your town?" + Environment.NewLine + "Or" + Environment.NewLine + "2. leave the town in peace?");
                destroyAnswer = int.Parse(Console.ReadLine());

                if (destroyAnswer == 1)
                {
                    try
                    {
                        Console.WriteLine(mutantName.TerrorizeTown(userTown));
                    }
                    catch(ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Sorry! This town is abandoned or too small for " + mutantNameChoice + " to care about. They get bored and wander away.");
                       
                    };
                   

                }
                else
                {

                    Console.WriteLine(mutantNameChoice + " walks peacefully into the sunset... never to be seen again...");


                };
            };



        }
    }
}
