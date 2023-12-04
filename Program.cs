/*
Code project 1 - write code that validates integer input

Here are the conditions that your first coding project must implement:
Your solution must include either a do-while or while iteration.
Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.

Inside the iteration block:

Your solution must use a Console.ReadLine() statement to obtain input from the user.
Your solution must ensure that the input is a valid representation of an integer.
If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.
Below (after) the iteration code block: your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.
*/
#nullable disable

Console.WriteLine("Input int value between 5 and 10");
var validInput = false;
string response = "default";

do
{
    string consoleInput = Console.ReadLine();
    if(int.TryParse(consoleInput,out int parsedResult)){
        if (parsedResult>5&&parsedResult<10)
        {
            response = $"Your input ({parsedResult}) has been accepted";
            validInput = true;
        }else{
            Console.WriteLine($"Bad input: ({parsedResult}), enter int between 5 and 10;");
        }
    }else{
        Console.WriteLine("Entered invalid input, try again.");
    }
} while (!validInput);

Console.WriteLine(response);

