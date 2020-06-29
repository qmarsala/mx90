using NUnit.Framework;

namespace mx90.test
{
    public class RuleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(100, new bool [] { false, true, true, false, false, true, false, false })]
        [TestCase(90, new bool [] { false, true, false, true, true, false, true, false })]
        public void Pattern_ShouldMatchExpectedPattern(int patternCode, bool[] expectedPattern)
        {
            var rule = new Rule(patternCode);
            Assert.AreEqual(expectedPattern, rule.Pattern);
        }
    }
}
