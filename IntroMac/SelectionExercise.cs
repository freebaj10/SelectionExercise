using System;
using System.Threading;

namespace SelectionExercises
{
    public class SelectionExercises
    {
        public static string FizzBuzz(int num)
        {
            Console.WriteLine("1) ");
            if ((num % 3 == 0) && (num % 5 == 0))
            {
                Console.WriteLine("FizzBuzz\n");
                return "FizzBuzz";
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("Fizz\n");
                return "Fizz";
            }

            else if (num % 5 == 0)
            {
                Console.WriteLine("Buzz\n");
                return "Buzz";
            }
            else
            {
                return Convert.ToString(num);
            }
        }

        public static string VowelConsonant()
        {
            Console.WriteLine("2) ");
            char ch;
            Console.WriteLine("Enter a character below:");
            ch = Console.ReadKey().KeyChar;

            switch (char.ToLower(ch))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("\nTrue\n");
                    return "True";

                default:
                    Console.WriteLine("\nFalse\n");
                    return "False";

            }
        }

        public static string DiceRoller()
        {
            Console.WriteLine("3) ");
            Random random = new();

            int die1 = random.Next(1, 7);
            int die2 = random.Next(1, 7);
            int die3 = random.Next(1, 7);

            Console.WriteLine($"You rolled: {die1},{die2},{die3}");

            if (die1 == die2 && die2 == die3)
            {
                Console.WriteLine("Three of a kind\n");
                return "Three of a kind";
            }

            else if (die1 == die2 || die1 == die3 || die2 == die3)
            {
                Console.WriteLine("You have a pair!\n");
                return "You have a pair";
            }
            else
            {
                Console.WriteLine("Sorry you lose\n");
                return "Sorry you lose";
            }
        }

        public enum AngleType
        {
            Acute,
            Obtuse,
            Reflex,
            Right_angle,
            Straight,
        }

        public static AngleType GetAngleType(double angleIndegrees)
        {
            Console.WriteLine("4) ");
            if (angleIndegrees < 90)
            {
                Console.WriteLine("Acute\n");
                return AngleType.Acute;
            }
            else if (angleIndegrees == 90)
            {
                Console.WriteLine("Right angle\n");
                return AngleType.Right_angle;
            }
            else if (angleIndegrees > 90 && angleIndegrees < 180)
            {
                Console.WriteLine("Obtuse\n");
                return AngleType.Obtuse;
            }
            else if (angleIndegrees == 180)
            {
                Console.WriteLine("Straight\n");
                return AngleType.Straight;
            }
            else if (angleIndegrees > 180)
            {
                Console.WriteLine("Reflex\n");
                return AngleType.Reflex;
            }
            else
            {
                Console.WriteLine("Acute\n");
                return AngleType.Acute;
            }
        }

        public static void RockPaperScissors()
        {
            Console.WriteLine("5) ");
            Console.WriteLine("Enter rock ('r'), paper ('p') or scissors ('s') :");
            string Playerchoice = Console.ReadLine();

            if (Playerchoice != "r" && Playerchoice != "p" && Playerchoice != "s")
            {
                Console.WriteLine("Wrong input");
                Environment.Exit(0);
            }

            Random random = new();
            int Enemychoice = random.Next(0, 3);

            switch (Enemychoice)
            {
                case 0:
                    Console.WriteLine("Enemy chooses rock");
                    break;
                case 1:
                    Console.WriteLine("Enemy chooses paper");
                    break;
                case 2:
                    Console.WriteLine("Enemy chooses scissors");
                    break;
            }
            //0 = rock
            //1 = paper
            //2 = scissors
            switch (Playerchoice)
            {
                case "r":
                    if (Enemychoice == 0)
                        Console.WriteLine("You tied!");
                    if (Enemychoice == 1)
                        Console.WriteLine("You lost.");
                    if (Enemychoice == 2)
                        Console.WriteLine("You won!");
                    break;

                case "p":
                    if (Enemychoice == 0)
                        Console.WriteLine("You won!");
                    if (Enemychoice == 1)
                        Console.WriteLine("You tied.");
                    if (Enemychoice == 2)
                        Console.WriteLine("You lost!");
                    break;

                case "s":
                    if (Enemychoice == 0)
                        Console.WriteLine("You lost!");
                    if (Enemychoice == 1)
                        Console.WriteLine("You won.");
                    if (Enemychoice == 2)
                        Console.WriteLine("You tied!");
                    break;

            }



        }

        public static void TriangleIdentifier(double side1, double side2, double side3)
        {
            Console.WriteLine("6) ");
            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("The triange is equilateral");
            }

            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine("The triange is Isoceles");
            }
            else
            {
                Console.WriteLine("The triange is scalene");
            }
        }

        public static void TryCalculateTotalSales()
        {
            Console.WriteLine("Enter the price of a concert ticket:");
            if (decimal.TryParse(Console.ReadLine(), out decimal price))
            {
                Console.WriteLine("Enter the number of tickets sold:");
                if (int.TryParse(Console.ReadLine(), out int quantity))
                {
                    decimal totalSales = price * quantity;
                    Console.WriteLine($"Total sales amount: {totalSales:C}");
                }
                else
                {
                    Console.WriteLine("Invalid input for the number of tickets sold. Please enter a valid numeric value.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for the ticket price. Please enter a valid numeric value.");
            }
        }
    }

}
