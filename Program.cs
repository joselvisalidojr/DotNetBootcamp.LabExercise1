using System;

namespace CSharp.LabExercise1
{
    internal class Program
    {

        static void Number1()
        {
            Console.WriteLine("Welcome to the Area and Perimeter Calculator");
            string continueLoop;
            do
            {
                Console.Write("\nEnter length: ");
                decimal length = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Enter width: ");
                decimal width = Convert.ToDecimal(Console.ReadLine());

                decimal area = width * length;
                Console.WriteLine("Area: {0}", area);

                decimal perimeter = (2 * width) + (2 * length);
                Console.WriteLine("Perimeter: {0}", perimeter);

                Console.Write("\nContinue? (y/n): ");
                continueLoop = Console.ReadLine();
            } while (continueLoop == "y" || continueLoop == "Y");

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();
            Main();
        }
        static void Number2()
        {
            Console.WriteLine("Welcome to the Letter Grade Calculator");
            string continueLoop;
            do
            {
                Console.Write("\nEnter numerical Grade: ");
                int grade = Convert.ToInt32(Console.ReadLine());
                if (grade >= 88 && grade <= 100)
                {
                    Console.WriteLine("Letter grade: A");
                }
                else if (grade >= 80 && grade <= 87)
                {
                    Console.WriteLine("Letter grade: B");
                }
                else if (grade >= 67 && grade <= 79)
                {
                    Console.WriteLine("Letter grade: C");
                }
                else if (grade >= 60 && grade <= 66)
                {
                    Console.WriteLine("Letter grade: D");
                }
                else
                {
                    Console.WriteLine("Letter grade: F");
                }

                Console.Write("\nContinue? (y/n): ");
                continueLoop = Console.ReadLine();
            } while(continueLoop == "y" || continueLoop == "Y");

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();
            Main();
        }
        static void Number3()
        {
            Console.WriteLine("Welcome to the Download Time Estimator");
            Console.WriteLine("\nThis program calculates how long it will take to download a file with a 56k analog modem.");
            string continueLoop;
            do
            {
                Console.Write("\nEnter a file size (MB): ");
                decimal fileSizeInMB = Convert.ToDecimal(Console.ReadLine());
                decimal fileSizeInKB = 1024 * fileSizeInMB;
                decimal inHr = fileSizeInKB / (5.2M * 3600);
                decimal inMin = (fileSizeInKB / (5.2M * 60)) % 60;
                decimal inSec = (fileSizeInKB / 5.2M) % 60;

                Console.WriteLine("A \"56k\" modem will take {0} hours {1} minutes {2} seconds", Math.Floor(inHr), Math.Floor(inMin), Math.Floor(inSec));

                Console.Write("\nContinue? (y/n): ");
                continueLoop = Console.ReadLine();
            } while (continueLoop == "y" || continueLoop == "Y");

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();
            Main();
        }
        static void Number4()
        {
            Console.WriteLine("Welcome to the Square Generator");
            string continueLoop;
            do
            {
                Console.Write("\nEnter square size: ");
                int squareSize = Convert.ToInt32(Console.ReadLine());

                for (int row = 0; row < squareSize; row++)
                {
                    for (int col = 0; col < squareSize; col++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                Console.Write("\nContinue? (y/n): ");
                continueLoop = Console.ReadLine();
            } while (continueLoop == "y" || continueLoop == "Y");

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();
            Main();
        }
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome To My Lab Exercise Application!");
                Console.WriteLine("\nPlease Select Exercise:");
                Console.WriteLine("[1] - Area and Perimeter Calculator");
                Console.WriteLine("[2] - Letter Grade Calculator");
                Console.WriteLine("[3] - Download Time Estimator");
                Console.WriteLine("[4] - Square Generator");
                Console.WriteLine("[5] - Exit Application");
                Console.Write("Enter Selection: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        Number1();
                        break;
                    case "2":
                        Console.Clear();
                        Number2();
                        break;
                    case "3":
                        Console.Clear();
                        Number3();
                        break;
                    case "4":
                        Console.Clear();
                        Number4();
                        break;
                    case "5":
                        Console.WriteLine("\nApplication Terminated!");
                        Environment.Exit(-1);
                        break;
                    default:
                        Console.Write("\nInvalid Selection! Press Any Key To Try Again! . . . ");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
