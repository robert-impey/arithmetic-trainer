using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

            var firstNumber = random.Next(Max);
            var secondNumber = random.Next(Max);
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
