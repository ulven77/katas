/*
 * Kata - Dependency Injection / Data injection crossroads
 * 
 * Task to be done
 * - Make all tests pass by
 * - what can we do???
 * 
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class YouShould
    {
        [TestMethod]
        public void HearNoEvil()
        {
            //Setup
            var giveMe = new GiveMe(); //Cant control input

            //Act
            var result = giveMe.Advice();

            //Assert
            Assert.AreEqual("HearNoEvil", result); //Broken test - breaks one time in three

            //Verify
        }

        [TestMethod]
        public void DoNoEvil()
        {
            //Setup
            var giveMe = new GiveMe(); //Cant control input

            //Act
            var result = giveMe.Advice();

            //Assert
            Assert.AreEqual("DoNoEvil", result); //Broken test - breaks one time in three

            //Verify
        }
 
        [TestMethod]
        public void SayNoEvil()
        {
            //Setup
            var giveMe = new GiveMe(); //Cant control input

            //Act
            var result = giveMe.Advice();

            //Assert
            Assert.AreEqual("SayNoEvil", result); //Broken test - breaks one time in three

            //Verify
        }
    }
}
