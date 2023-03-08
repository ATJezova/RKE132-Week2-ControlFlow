//rakendus küsib kasutajal sisestada tema vanust
//kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
//"You are too young to use Instagram!"
//muul juhul kuvatakse:
//"Welcome to Instagram."

Console.WriteLine("Enter your age:");

//int userAge = Int32.Parse(Console.ReadLine()); //"13" - heap, 13- stack

string userAge = Console.ReadLine();
int userAgeNum = 0;

//boolean - true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

if(isAgeNumber)
{
    if(userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Instagram.");
    }
    else
    {
        Console.WriteLine("You are too young to use Instagram!");
    }
}
else
{
    Console.WriteLine("Could not read your age.");
}