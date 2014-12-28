namespace ArithmeticTrainer.Lib
{
    public struct QuizTriplet
    {
		private readonly double _firstNumber;
		private readonly double _secondNumber;

		private readonly double _result;

		public QuizTriplet(double firstNumber, double secondNumber, double result)
		{
			_firstNumber = firstNumber;
			_secondNumber = secondNumber;

			_result = result;
		}

        public double FirstNumber { get { return _firstNumber; } }
        public double Secondumber { get { return _secondNumber; } }

        public double Result { get { return _result; } }
    }
}
