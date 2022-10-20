string[] names = { "Tim", "Steve", "Bob", "Sam" };
string[] homeTown = { "Detroit", "Royal Oak", "Troy", "Grand Rapids" };
string[] favoriteFood = { "Pizza", "Burger", "Steak", "Pasta" };


Console.WriteLine("Here is a list of the students");
foreach(string name in names)
{
    Console.WriteLine(name.ToString());
}

while (true)
{
    Console.WriteLine("Please enter a number 1-4 for a student");
    int userSelection = Convert.ToInt32(Console.ReadLine());




    if (userSelection < 4 && userSelection > 0)
    {

        Console.WriteLine(names[userSelection - 1]);
    }
    else
    {
        Console.WriteLine("Please enter a number 1-4");
    }

    Console.WriteLine("Do you want to know This students favoire food or Hometown");
    Console.WriteLine("Press 1 for Favorite Food and 2 for Hometown");
    int choice1 = Convert.ToInt32(Console.ReadLine());
    while (choice1 > 2 || choice1 < 0)    
    {
       
            Console.WriteLine("Enter 1 or 2");
            choice1 = Convert.ToInt32(Console.ReadLine()); 
    }
    if (choice1 == 1)
    {
        Console.WriteLine($"{names[userSelection - 1]}'s Favorite food is {favoriteFood[userSelection - 1]}");
    }

    else 
    {
        Console.WriteLine($"{names[userSelection - 1]}'s Hometown is {homeTown[userSelection - 1]}");
    }

    Console.WriteLine("Would you like to learn about another student? Please answer y or n");
    string finalAnswer = Console.ReadLine();
    finalAnswer.ToLower();

    if (finalAnswer == "y")
    {
        continue;
    }
    else
    {
        break;
    }
}
