namespace midterm_bonus;

public class HumanPlayer
{
    private int points;

    public HumanPlayer(int initial)
    {
        points = initial;
    }

    public int GetPoints()
    {
        return points;
    }

    public void WinRound()
    {
        points += 5;
    }

    public void LoseRound()
    {
        points -= 5;
    }

    public string HumanDecision()
    {
        Console.WriteLine("Please input your choice: rock, paper or scissors.");
        return Console.ReadLine();
    }
}

public class ComputerPlayer
{
    public string ComputerDecision()
    {
        Random rnd = new Random();
        int rndNum = rnd.Next(0, 3);
        if (rndNum == 0)
            return "rock";
        else if (rndNum == 1)
            return "paper";
        else
            return "scissors";
    }
}

public class RockPaperScissors
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n****Rock, Paper, Scissors, Start!!****");

        HumanPlayer human = new HumanPlayer(5);
        ComputerPlayer computer = new ComputerPlayer();

        while (human.GetPoints() > 0)
        {
            Console.WriteLine($"You have {human.GetPoints()} points\n");

            string humanChoice = human.HumanDecision();
            string computerChoice = computer.ComputerDecision();

            Console.WriteLine($"--> Your Decision: {humanChoice}");
            Console.WriteLine($"--> Computer Decision: {computerChoice}");

            if (humanChoice == computerChoice)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((humanChoice == "rock" && computerChoice == "scissors") ||
                    (humanChoice == "paper" && computerChoice == "rock") ||
                    (humanChoice == "scissors" && computerChoice == "paper"))
            {
                Console.WriteLine("You win!");
                human.WinRound();
            }
            else
            {
                Console.WriteLine("You lose!");
                human.LoseRound();
            }

            if (human.GetPoints() <= 0)
            {
                Console.WriteLine("You ran out of points!");
                break;
            }

            Console.WriteLine("--> Play again? Input y to continue, or n to exit");
            if (Console.ReadLine() == "n")
            {
                break;
            }
        }

        Console.WriteLine("Game over!");
    }
}
