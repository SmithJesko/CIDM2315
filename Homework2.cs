namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        /*
            Q1
        */

        Console.Write("Please input a letter grade: ");
        string grade = Console.ReadLine();

        int gpaPoints;

        // convert grade letter to grade point
        switch (grade)
        {
            case "A":
                gpaPoints = 4;
                break;
            case "B":
                gpaPoints = 3;
                break;
            case "C":
                gpaPoints = 2;
                break;
            case "D":
                gpaPoints = 1;
                break;
            case "F":
                gpaPoints = 0;
                break;
            default:
                Console.WriteLine("Wrong Letter Grade!");
                return;
        }

        Console.WriteLine($"GPA point: {gpaPoints}");


        /*
            Q2
        */

        // get numbers
        Console.WriteLine("Please enter the first number:");
        string input1 = Console.ReadLine();
        Console.WriteLine("Please enter the second number:");
        string input2 = Console.ReadLine();
        Console.WriteLine("Please enter the third number:");
        string input3 = Console.ReadLine();

        // convert string to int
        int number1 = Convert.ToInt16(input1);
        int number2 = Convert.ToInt16(input2);
        int number3 = Convert.ToInt16(input3);

        // find the smallest value among the three numbers
        int smallest;

        if (number1 <= number2)
        {
            if (number1 <= number3)
            {
                smallest = number1;
            }
            else
            {
                smallest = number3;
            }
        }
        else
        {
            if (number2 <= number3)
            {
                smallest = number2;
            }
            else
            {
                smallest = number3;
            }
        }

        Console.WriteLine($"The smallest value is: {smallest}");


        /*
            BONUS
        */

        Console.Write("Please input a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        // Check if it's a leap year
        if (year % 4 == 0)
        {
            if (year % 100 != 0 || (year % 100 == 0 && year % 400 == 0))
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year.");
        }
    }
}
