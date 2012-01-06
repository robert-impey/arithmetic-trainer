using System;

namespace ArithmeticTrainer.Lib
{
    public class TimesTableQuizGenerator
    {
        #region Properties

        public int Min { get; set; }
        public int Max { get; set; }

        #endregion

        #region Methods

        public QuizTriplet NewQuizTriplet()
        {
            var random = new Random();

            var firstNumber = random.Next(Max - Min + 1) + Min;
            var secondNumber = random.Next(Max - Min + 1) + Min;
            return new QuizTriplet
            {
                FirstNumber = firstNumber,
                Secondumber = secondNumber,
                Result = firstNumber * secondNumber
            };
        }

        #endregion
    }
}
