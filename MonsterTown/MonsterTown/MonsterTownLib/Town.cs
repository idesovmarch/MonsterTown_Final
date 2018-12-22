using System;

namespace MonsterTownLib
{
    /* Class is immutable. After an object is created
     * it cannot be modified from outside the class.
     * It utilizes a constructor to initialize its properties. 
    */ 
    public class Town
    {
        //Attributes
        //Auto-Implemented Properties for Getters and Setters
        public string TownName { get; }
        public int Population { get; private set; }
        public int StopLights { get; private set; }

        //Constructor
        public Town(string townName, int population, int stoplights)
        {
            TownName = townName;
            Population = population;
            StopLights = stoplights;
        }

        //Methods
        public string RetrieveTownDescription()
        {
            string townDescription = new string($"{this.TownName} has a population of {this.Population} remaining, with {this.StopLights} stoplightes still standing...");
            return townDescription;
        }

        public void ChangePopulation(int changeAmount)
        {
            //this.Population = this.Population + changeAmount;
            this.Population += changeAmount;
        }

        public void ChangeStoplights(int changeAmount)
        {
            this.StopLights += changeAmount;
        }
    }
}
