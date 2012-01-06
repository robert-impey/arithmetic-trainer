using ArithmeticTrainer.Lib;
using NUnit.Framework;

namespace ArithmeticTrainer.Test
{
    [TestFixture]
    class TimesTableQuizGeneratorTest
    {
        #region Tests

        [Test]
        public void TtqgGeneratesLoeMax()
        {
            var ttqg = NewTimesTableGenerator();
            var result = ttqg.NewQuizTriplet();

            Assert.LessOrEqual(result.FirstNumber, MAX);
        }

        [Test]
        public void TtqgGeneratesGoeMin()
        {
            var ttqg = NewTimesTableGenerator();
            var result = ttqg.NewQuizTriplet();

            Assert.GreaterOrEqual(result.FirstNumber, MIN);
        }

        #endregion

        #region Fixtures

        private const int MIN = 5;
        private const int MAX = 10;

        private static TimesTableQuizGenerator NewTimesTableGenerator()
        {
            return new TimesTableQuizGenerator
            {
                Min = MIN,
                Max = MAX
            };
        }

        #endregion
    }
}
