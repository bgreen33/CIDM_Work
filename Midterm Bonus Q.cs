using System;

class HumanPlayer
{
    private int points;

    public HumanPlayer(int intitial)
    {
        points = intitial;
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

    public string HumanChoice()
    {
        Console.WriteLine("Please input your choice: rock, paper, or scissors?");
        string choice = Console.ReadLine().Trim().ToLower();
        if (choice == "rock" || choice "paper" || choice == "scissors")
        {
            return choice;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please input rock, paper, or scissors.");
            return HumanChoice();
        }
    }
}

class  ComputerPlayer
{
    private Random random = new Random();

    public string ComputerChoice()
    {
        string[] shapes = {"rock", "paper", "scissors" };
        int  randomIndex = random.Next(0, 3);
        return shapes[randomIndex];
    }
}

class RockPaperScissors
{
    static void Main(string[] args)
    {
        HumanPlayer humanPlayer = new HumanPlayer(5);
        ComputerPlayer computerPlayer = new ComputerPlayer();
        bool gameOver = false;
        
        while (!gameOver)
        {
            Console.WriteLine($"Your points: {humanPlayer.GetPoints()}");
            string HumanChoice = humanPlayer.HumanChoice();
            string  ComputerChoice = computerPlayer.ComputerChoice();

            Console.WriteLine($"Your choice: {HumanChoice}");
            Console.WriteLine($"Computer Choice: {ComputerChoice}");

            if (HumanChoice == ComputerChoice)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((HumanChoice == "rock" && ComputerChoice == "scissors")) ||
                     (HumanChoice == "scissors" && ComputerChoice == "paper") ||
                     (HumanChoice == "paper" && ComputerChoice == "rock"))
            {
                Console.WriteLine("Human wins this round!");
                humanPlayer.Winround()
            }
            else
            {
                Console.WriteLine("Computer winsthis round!");
                humanPlayer.LoseRound();
            }
            if (humanPlayer.GetPoints() <= 0)
            {
                Console.WriteLine("Game over! Human player is out of points.");
                gameOver = true;
            }
            else
            {
                Console.WriteLine("Do you want to play another round? (y/n): ");
                string playAgain = Console.ReadLine().Trim().ToLower();
                if (playAgain 1= "y")
                {
                    gameOver= true;
                }
            }
        }
    }
}