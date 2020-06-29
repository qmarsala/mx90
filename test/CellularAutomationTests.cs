using NUnit.Framework;
using System.Linq;
using mx90;

namespace mx90.test
{
    public class CellularAutomationTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Initialize_ShouldInitializeGenerations()
        {
            var expectedSize = 8;
            var history = CellularAutomation.Create(expectedSize);

            Assert.AreEqual(expectedSize, history.Size);
        }

        [Test]
        public void Initialize_ShouldInitializeCreateSimpleGenerations()
        {
            var expectedSize = 8;
            var expectedFalseCount = (expectedSize * expectedSize) - 1;
            var history = CellularAutomation.Create(expectedSize);

            Assert.AreEqual(true, history.Generations[0].Cells[0]);
            
            var falseCount = history.Generations
                .Sum(x => x.Cells.Count(x => x == false));
            Assert.AreEqual(expectedFalseCount, falseCount);
        }
    }
}