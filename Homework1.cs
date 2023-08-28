namespace Homework1;

class Program
{
    static void Main(string[] args)
    {
        // Z = 4X2+3Y, when  X = 2.5, Y=3.3
        float x = 2.5f;
        float y = 3.3f;
        
        // Calculate Z = 4X^2 + 3Y
        float z = (4*x*x+(3*y));

        // Print output
        Console.WriteLine($"X = {x}, Y = {y}");
        Console.WriteLine($"The value of Z is: {z}");
    }
}
