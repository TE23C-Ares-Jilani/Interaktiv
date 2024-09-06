Console.WriteLine("You wake up on an island with no memory of who you are or how you got there. You look to your left and see a crashlanded plane. There isnt a person in sight anywhere.");
Console.WriteLine("Option 1. Scavenge the plain for resources Option 2. try to rip the outer metal sheets off the plane. write the corrusponding number to your choice.");
String choice1 = Console.ReadLine();

if (choice1 == "1")
{
    Console.Clear();
    Console.WriteLine("You scavenge the plane but find that it has mostly been ransacked already. after looking thorugh the place you eventually find canned 1. tomato soup, 2. a parachute and 3. Flare gun.");
string choice11 = Console.ReadLine();
    if (choice11 == "1")
    {
        Console.Clear();
        Console.WriteLine("You try to open the tomato soup but realize that you don't have can opner with you.");
        Console.WriteLine("You die from starvation");
        string end2 = Console.ReadLine();
        if (end2 == "skibidi toilet rizz")
        {
            Console.Clear();
            Console.WriteLine("Just kidding");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("You had a Totem of Undying on you and you get revived! :D");
            Thread.Sleep(10000);
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Game Over.");
        }
    } 
    else if (choice11 == "2")
    {
        Console.Clear();
        Console.WriteLine("You walk deeper and get rick rolled :D");
    }
}
else if (choice1 == "2")
{
    Console.Clear();
    Console.WriteLine("You attemt to rip the metal sheets off with your bare hands. while trying to do so you accidently cut yourself on your hand. the wound gets infected and you die shortly after");
    string end1 = Console.ReadLine();
    if (end1 == "FU")
    {
    Console.Clear();
    Console.WriteLine("No u.");
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Game Over.");
    }
}
else
{
    Console.WriteLine("Error, terminating IDF.exe");
    Console.ReadLine();
    return;
}

Console.ReadLine();