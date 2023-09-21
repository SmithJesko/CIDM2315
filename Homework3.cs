namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        // Question 1
        Console.WriteLine("Input number N");
        int N1 = Convert.ToInt16(Console.ReadLine());
        int divisor = 2;

        while (divisor < N1)
        {
            if (N1 % divisor == 0)
            {
                Console.WriteLine($"{N1} is not prime");
                break;
            }
            divisor++;
        }

        if (divisor == N1) // maybe not the best way to check, but it works..
        {
            Console.WriteLine($"{N1} is prime");
        }

        Console.WriteLine(); // for style


        // Question 2
        Console.WriteLine("Input number N");
        int N2 = Convert.ToInt16(Console.ReadLine());
        
        for(int row = 0; row<N2; row++){
            for(int col = 0; col<N2; col++){
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine(); // for style


        // Question 3
        Console.WriteLine("Input number N");
        int N3 = Convert.ToInt16(Console.ReadLine());
        
        for(int row = 0; row<N3; row++){
            for(int col = 0; col<N3; col++){
                if(row>=col){
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }
    }
}
