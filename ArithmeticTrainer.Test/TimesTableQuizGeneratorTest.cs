using ArithmeticTrainer.Lib;
using NUnit.Framework;

namespace ArithmeticTrainer.Test
{
    [TestFixture]
    class TimesTableQuizGeneratorTest
    {
        #region Tests

        [Test]
        public void TtqgGeneratesInRange()
        {
            var max = 10;
            var ttqg = new TimesTableQuizGenerator
            {
                Max = max
            };

            var result = ttqg.NewQuizTriplet();

            Assert.LessOrEqual(result.FirstNumber, max);
        }

        #endregion
    }
}
