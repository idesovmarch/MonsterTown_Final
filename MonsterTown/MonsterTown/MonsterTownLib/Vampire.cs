using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterTownLib
{
    public class Vampire : Monster
    {

        public bool LivesOffBlood { get; }
        

        public Vampire(string monsterName) : base(monsterName)
        {
            
        }

        public override string TerrorizeTown(Town targetTown)
        {
            //Monster's current town
            this.CurrentTown = targetTown;


            //How much to destroy
            
            int populationDamage = CurrentTown.Population - (CurrentTown.Population + 1);            

            
            
            //int infrastructureDamage = randomGenerator.Next();


            //Invoke Damage
            this.CurrentTown.ChangePopulation(populationDamage);
            //this.CurrentTown.ChangeStoplights(infrastructureDamage * -1);


            //Call DescribeActivity
            return this.DescribeActivity();
        }
    }

}
