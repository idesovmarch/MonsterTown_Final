using System;
using Xunit;
using Xunit.Abstractions;

namespace MonsterTownLib_UnitTests
{
    public class MonsterTownUnitTests
    {
        //-----------------------------------------------------------------------
        private readonly ITestOutputHelper output;

        //Overload default constructor to include our 'Output'
        public MonsterTownUnitTests(ITestOutputHelper output)
        {
            this.output = output;
        }
        //Shows output during unit testing
        //------------------------------------------------------------------------

        [Fact]
        public void TestCreateTownObjectWithValues()
        {
            //Arrange - setup          

            int expectedPopulation = 10000;



            //Act - execute
            //Create an instance of the town class given our provided values

            var myTestTown = CreateTestTown();

            output.WriteLine($"Original: {myTestTown.Population}, Expected: {expectedPopulation}");

            //Assert - evaluate

            Assert.Equal(expectedPopulation, myTestTown.Population);
        }//End Unit Test 1


        [Fact]
        public void TestChangeTownPopulationPositive()
        {
            //Arrange - setup
            int changeAmount = 34;

            int expectedPopulation = 10034;

            //Act - execute

            var myTestTown = CreateTestTown();

            myTestTown.ChangePopulation(changeAmount);

            //Assert - evaluate

            Assert.Equal(expectedPopulation, myTestTown.Population);
        }


        [Fact]
        public void TestChangeTownPopulationNegative()
        {
            //Arrange - setup
            int changeAmount = -150;

            int expectedPopulation = 9850;

            //Act - execute

            var myTestTown = CreateTestTown();

            myTestTown.ChangePopulation(changeAmount);

            //Assert - evaluate

            Assert.Equal(expectedPopulation, myTestTown.Population);
        }


        public MonsterTownLib.Town CreateTestTown()
        {

            string testTownName = "funkytown";
            int testTownPopulation = 10000;
            int testTownStopLights = 150;

            var myTestTown = new MonsterTownLib.Town(testTownName, testTownPopulation, testTownStopLights);

            return myTestTown;

        }


        [Fact]
        public void TheMutantTest_NoTownAssigned()
        {
            //Arrange - setup
            string mutantCurrentTown = "funkytown";


            //Act - execute
            var myTestMutant = CreateTestMutant();
            var myTestTown = CreateTestTown();
            

            myTestMutant.TerrorizeTown(myTestTown);

            string testCurrentTown = myTestMutant.CurrentTown.TownName;

            //Assert - evaluate

            Assert.Equal(mutantCurrentTown, testCurrentTown);
        }


        [Fact]
        public void TheMutantDestroyTest()
        {
                                  
            var myTestMutant = CreateTestMutant();
            var myTestTown = CreateTestTown();


            myTestMutant.TerrorizeTown(myTestTown);

            

            Assert.True(myTestTown.Population > 10);
            Assert.True(myTestTown.StopLights > 1);

        }



        [Fact]
        public void TheVampireDestroyTest()
        {
            
            

            var myTestVampire = CreateTestVampire();
            var myTestTown = CreateTestTown();

           // int expectedPopulationDamage = testTownPopulation - (testTownPopulation - 1);

            myTestVampire.TerrorizeTown(myTestTown);
            int testTownPopulation = myTestVampire.CurrentTown.Population;

          

            Assert.Equal(myTestTown.Population, testTownPopulation);
            


        }


        //HELPER METHODS

        
        public MonsterTownLib.Mutant CreateTestMutant()
        {

            string testMutantName = "The Toxic Avenger";

            var myTestMutant = new MonsterTownLib.Mutant(testMutantName, true);

            return myTestMutant;
        }


        public MonsterTownLib.Vampire CreateTestVampire()
        {

            string testVampireName = "Frank the Creep";
            

            var myTestVampire = new MonsterTownLib.Vampire(testVampireName);
            
            return myTestVampire;
            
        }


    }//End Class
}//End Namespace
