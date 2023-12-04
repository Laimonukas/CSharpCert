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
*/


/*
Code project 2 - write code that validates string input
Here are the conditions that your second coding project must implement:

Your solution must include either a do-while or while iteration.

Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for one of three role names: Administrator, Manager, or User.

Inside the iteration block:

Your solution must use a Console.ReadLine() statement to obtain input from the user.
Your solution must ensure that the value entered matches one of the three role options.
Your solution should use the Trim() method on the input value to ignore leading and training space characters.
Your solution should use the ToLower() method on the input value to ignore case.
If the value entered isn't a match for one of the role options, your code must use a Console.WriteLine() statement to prompt the user for a valid entry.
Below (after) the iteration code block: Your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.


#nullable disable
string[] roles = ["administrator","manager","user"];
var validInput = false;
string consoleInput = "Default";
Console.WriteLine("Enter role name, (Administrator, Manager, User)");

do
{
    consoleInput = Console.ReadLine().Trim().ToLower();
    if (roles.Contains(consoleInput))
    {
        validInput = true;
        break;
    }

    Console.WriteLine($"The role name that you entered, {consoleInput} is not valid. Enter your role name (Administrator, Manager, or User)");
} while (!validInput);

Console.WriteLine($"Your input value ({consoleInput}) has been accepted.");

*/

/*
Code project 3 - Write code that processes the contents of a string array
Here are the conditions that your third coding project must implement:

your solution must use the following string array to represent the input to your coding logic:
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

Your solution must declare an integer variable named periodLocation that can be used to hold the location of the period character within a string.

Your solution must include an outer foreach or for loop that can be used to process each string element in the array. The string variable that you'll process inside the loops should be named myString.

In the outer loop, your solution must use the IndexOf() method of the String class to get the location of the first period character in the myString variable. The method call should be similar to: myString.IndexOf("."). If there's no period character in the string, a value of -1 will be returned.

Your solution must include an inner do-while or while loop that can be used to process the myString variable.

In the inner loop, your solution must extract and display (write to the console) each sentence that is contained in each of the strings that are processed.

In the inner loop, your solution must not display the period character.

In the inner loop, your solution must use the Remove(), Substring(), and TrimStart() methods to process the string information.
*/
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation = 0;
string myString;

foreach (var element in myStrings)
{   
    myString = element;
    periodLocation = myString.IndexOf('.');

    while (periodLocation >= 0){
        Console.WriteLine(myString.Substring(0,periodLocation));
        myString = myString.Remove(0,periodLocation).TrimStart('.').TrimStart();
        periodLocation = myString.IndexOf('.');
    }
    Console.WriteLine(myString);
}