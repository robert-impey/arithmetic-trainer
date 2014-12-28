namespace ArithmeticTrainer.Lib
{
    public struct QuizTriplet
    {
		private double _firstNumber;
		private double _secondNumber;

		private double _result;

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
