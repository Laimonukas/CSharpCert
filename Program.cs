//Dice mini-game challenge

Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

void PlayGame() 
{
    var play = true;

    while (play) 
    {
        var target = randomRoll(6);
        var roll = randomRoll(7);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll,target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay(){
    var result = Console.ReadLine().Trim().ToLower();
    switch(result){
        case "y":
            return true;
        default:
            return false;
    }
}

int randomRoll(int maxBounds){
    return random.Next(1,maxBounds);
}

string WinOrLose(int rolled, int target){
    return rolled > target ? "You have won!":"You have lost.";
}