using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterTownLib
{
    //Class Monster is Abstract - No instances of "Monster" can be created - Is outline for subclasses
    public abstract class Monster
    {
        //Auto-Implemented Properties

        public string MonsterName { get; }
        public Town CurrentTown { get; set; }

        //Constructor - will be overridden by subclasses

        protected Monster(string monsterName)
        {
            MonsterName = monsterName;
        }

        //Methods
        //1
        public string DescribeActivity()
        {
            string activityDescription = new string("");

            if(this.CurrentTown == null)
            {
                activityDescription = $"{this.MonsterName} is bored.";
            } else
            {
                activityDescription = $"{this.MonsterName} has terrorized {this.CurrentTown.TownName}.  {this.CurrentTown.RetrieveTownDescription()}";
            }
            return activityDescription;
        }

        //2
        public abstract string TerrorizeTown(Town targetTown);

    }
}
