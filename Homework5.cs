namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        // Question 1
        Console.WriteLine("Question 1");
        int Q1 = Question1();
        Console.WriteLine($"The largest number is {Q1}");

        // Question 2
        Console.WriteLine("\n\nQuestion 2");
        int Q2 = Question2();
        Console.WriteLine($"The largest number is {Q2}");

        // Question 3
        Console.WriteLine("\n\nQuestion 3");
        createAccount();
    }

    // Question 1
    static int Question1()
    {
        Console.WriteLine("Input number A");
        int numA = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Input number B");
        int numB = Convert.ToInt16(Console.ReadLine());

        if(numA > numB)
        {
            return numA;
        }
        else
        {
            return numB;
        }
    }

    // Question 2
    static int Question2()
    {
        Console.WriteLine("Input number 1");
        int num1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Input number 2");
        int num2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Input number 3");
        int num3 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Input number 4");
        int num4 = Convert.ToInt16(Console.ReadLine());

        int largest = num1;
        if (num2 > largest) largest = num2;
        if (num3 > largest) largest = num3;
        if (num4 > largest) largest = num4;

        return largest;
    }

    // Question 3
    static bool checkAge(int birth_year)
    {
        int age = 2023 - birth_year;
        return age >= 18;
    }

    static void createAccount()
    {
        Console.WriteLine("Enter your username: ");
        string input_user = Console.ReadLine();
        Console.WriteLine("Enter your password: ");
        string input_pass = Console.ReadLine();
        Console.WriteLine("Enter your password again: ");
        string input_pass2 = Console.ReadLine();
        Console.WriteLine("Enter your birthyear: ");
        int birth_year = Convert.ToInt16(Console.ReadLine());

        if (checkAge(birth_year))
        {
            if (input_pass == input_pass2)
            {
                Console.WriteLine("Account is created successfully");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account");
        }
    }
}
