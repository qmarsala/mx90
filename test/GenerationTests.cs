using NUnit.Framework;
using System.Linq;
using mx90;

namespace mx90.test
{
    public class GenerationTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Next_ShouldReturnGeneration()
        {
            var geneartion = Generation.Create(2);
            
            var nextGeneration = geneartion.Next(null);

            Assert.IsNotNull(nextGeneration);
            Assert.AreEqual(2, nextGeneration.Size);
        }
    }
}