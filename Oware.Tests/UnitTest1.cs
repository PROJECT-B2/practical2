using NUnit.Framework;

namespace Oware.Tests
{  /* public class MockScoreHouse :IScoreHouse{
        
        
        public int GetCount() {
            return new System.NotImplementedException();
        }

        public void AddSeed(Seed seed) {
            return new System.NotImplementedException();
        }

        public void Reset() {
            return new System.NotImplementedException();
        }

        }*/

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        
       // public void AddSeedToScoreHouse(){}

        [Test]
        public void Test1()
        {   //arrange
            House h= new House(4,5);
            //act 
            h.ResetHouse();
            //assert
            Assert.AreEqual(4,h.GetCount(),"there will need to be four seeds");
        }


    }
}