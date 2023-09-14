namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        // Question 1
        Console.WriteLine("Input number a:");
        int a = Convert.ToInt16(Console.ReadLine());
        
        Console.WriteLine("Input number b:");
        int b = Convert.ToInt16(Console.ReadLine());

        int largest = QuestionOne(a,b);
        Console.WriteLine($"The largest number of {a} and {b} is: {largest}");
        Console.WriteLine(); // add blank line for style

        // Question 2
        Console.WriteLine("Input number N:");
        int N = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(); // add blank line for style
        QuestionTwo(N);


        // Question 3
        QuestionThree(N);
    }

    // Question 1
    static int QuestionOne(int a, int b)
    {
        if(a>b){
            return a;
        }
        else { //a<=b
            return b;
        }
    }


    // Question 2
    static void QuestionTwo(int N)
    {
        for(int row = 0; row<N; row++){
            for(int col = 0; col<N; col++){
                Console.Write("#");
            }
            Console.WriteLine(); // add blank line for style
        }
    }


    // Question 3
    static void QuestionThree(int N)
    {
        for(int row = 0; row<=N; row++){
            for(int col = 0; col<N; col++){
                if(row>col){
                    Console.Write("#");
                }
            }
            Console.WriteLine(); // add blank line for style
        }
    }
}
