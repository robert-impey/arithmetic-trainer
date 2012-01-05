using System;
using ArithmeticTrainer.Lib;

namespace ArithmeticTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Please tell me what to do!");
            }
            else
            {
                var operation = args[0];

                switch (operation)
                {
                    case "TimesTable":
                        if (args.Length == 2)
                        {
                            int max;
                            if (int.TryParse(args[1], out max))
                            {
                                var ttqg = new TimesTableQuizGenerator{
                                    Max = max
                                };

                                var quizTriplet = ttqg.NewQuizTriplet();

                                Console.WriteLine(string.Format("{0} x {1} = ", quizTriplet.FirstNumber, quizTriplet.Secondumber));
                                double usersAnswer;
                                if (double.TryParse(Console.ReadLine(), out usersAnswer))
                                {
                                    Console.WriteLine(string.Format("Your answer is {0}", usersAnswer));
                                    Console.WriteLine(string.Format("The correct answer is {0}", quizTriplet.Result));

                                    Console.WriteLine(string.Format("The difference is {0}", Math.Abs(usersAnswer - quizTriplet.Result)));
                                }
                                else
                                {
                                    Console.WriteLine("Unable to parse your answer!");
                                }
                            }
                            else
                            {
                                Console.WriteLine(string.Format("Unable to parse {0}", args[1]));
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong number of args!");
                        }
                        break;
                    default:
                        Console.WriteLine("Unrecognised operation!");
                        break;
                }
            }
        }
    }
}
