

Random random = new Random();
bool playAgain = true;
String player;
String computer;
String response;


while (playAgain)
{
    player = "";
    computer = "";
    response = "";

    while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
    {
        Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
        player = Console.ReadLine();
        player = player.ToUpper();
    }

    switch (random.Next(1, 4))
    {
        case 1:
            computer = "ROCK";
            break;
        case 2:
            computer = "PAPER";
            break;
        case 3:
            computer = "SCISSORS";
            break;
    }

    Console.WriteLine("Player: " + player);
    Console.WriteLine("Computer: " + computer);

    switch (player)
    {
        case "ROCK":
            if (computer == "ROCK")
            {
                Console.WriteLine("Its a draw");
            }
            else if (computer == "PAPER")
            {
                Console.WriteLine("You lose");
            }
            else
            {
                Console.WriteLine("You Win");
            }
            break;

        case "PAPER":
            if (computer == "PAPER")
            {
                Console.WriteLine("Its a draw");
            }
            else if (computer == "SCISSORS")
            {
                Console.WriteLine("You lose");
            }
            else
            {
                Console.WriteLine("You Win");
            }
            break;

        case "SCISSORS":
            if (computer == "SCISSORS")
            {
                Console.WriteLine("Its a draw");
            }
            else if (computer == "ROCK")
            {
                Console.WriteLine("You lose");
            }
            else
            {
                Console.WriteLine("You Win");
            }
            break;
    }

    Console.Write("Do you want to play again? (Y/N): ");
    response = Console.ReadLine();
    response = response.ToUpper();

    if (response == "Y")
    {
        playAgain = true;
    }
    else
    {
        playAgain = false;
    }

}

Console.WriteLine("Thanks for playing!");


Console.ReadKey();