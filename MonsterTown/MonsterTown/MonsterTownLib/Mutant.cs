using System;
using System.Collections.Generic;
using System.Text;
//Concrete Class
namespace MonsterTownLib
{
    public class Mutant : Monster
    {
        //Attribute "Radioactive" unique to this sub-class
        public bool IsRadioactive { get; }

         //Constructor
        public Mutant(string monsterName, bool isRadioactive) : base(monsterName)
        {
            IsRadioactive = isRadioactive;
            
        }

        public override string TerrorizeTown(Town targetTown)
        {
            //Monster's current town
            this.CurrentTown = targetTown;


            //How much to destroy
            System.Random randomGenerator = new Random();
            int populationDamage = randomGenerator.Next(10, this.CurrentTown.Population / 8);

            int infrastructureDamage = randomGenerator.Next(1, this.CurrentTown.StopLights / 12);

            

            //Invoke Damage
            this.CurrentTown.ChangePopulation(populationDamage * -1);
            this.CurrentTown.ChangeStoplights(infrastructureDamage * -1);


            //Call DescribeActivity
            return this.DescribeActivity();

        }


    }
}
