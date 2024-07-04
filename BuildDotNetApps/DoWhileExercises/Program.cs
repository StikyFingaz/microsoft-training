// Challenge 1
int userInteger = 0;
bool isValidNum = false;

Console.WriteLine($"Enter an integer value between 5 and 10");

do
{
    string? userInput = Console.ReadLine();

    bool isValidInput = int.TryParse(userInput, out int currentInput);

    if (!isValidInput)
        Console.WriteLine($"Sorry, you entered an invalid number, please try again");
    else if (isValidInput && !(currentInput >= 5 && currentInput <= 10))
    {
        Console.WriteLine($"You entered {currentInput}. Please enter a number between 5 and 10.");
    }
    else
    {
        isValidNum = true;
        userInteger = currentInput;
    }
} while (!isValidNum);

Console.WriteLine($"Your input value ({userInteger}) has been accepted.");

// Challenge 2
Console.WriteLine($"Enter your role name (Administrator, Manager, or User) ");

string[] roles = ["administrator", "manager", "user"];
string userRole;

while (true)
{
    userRole = (Console.ReadLine() ?? string.Empty).Trim().ToLower();

    if (!roles.Contains(userRole))
    {
        Console.WriteLine(
            $"The role name that you entered, \"{userRole}\" is not valid. Enter your role name (Administrator, Manager, or User) Administrator"
        );
    }
    else
        break;
}

userRole = userRole.First().ToString().ToUpper() + userRole[1..];
Console.WriteLine($"Your input value {userRole} has been accepted.");

// Challenge 3
string[] myStrings =
[
    "I like pizza. I like roast chicken. I like salad",
    "I like all three of the menu choices"
];
int periodLocation;

foreach (var myString in myStrings)
{
    periodLocation = myString.IndexOf('.');
    if (periodLocation != -1)
    {
        string[] newString = myString.Split('.');
        foreach (var sepStr in newString)
        {
            Console.WriteLine($"{sepStr.TrimStart()}");
        }
    }
    else
    {
        Console.WriteLine($"{myString}");
    }
}
