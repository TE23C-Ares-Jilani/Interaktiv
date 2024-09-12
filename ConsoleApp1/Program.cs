Console.WriteLine("You wake up on an island with no memory of who you are or how you got there. You look to your left and see a crashlanded plane. There isnt a person in sight anywhere.");
Console.WriteLine("Option 1. Scavenge the plain for resources Option 2. try to rip the outer metal sheets off the plane. write the corrusponding number to your choice.");
String choice1 = Console.ReadLine();

if (choice1 == "1")
{
    Console.Clear();
    Console.WriteLine("You scavenge the plane but find that it has mostly been ransacked already. after looking through the place you eventually find 1. canned tomato soup, 2. a parachute 3. Flare gun.");
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
        Console.WriteLine("You put on the parachute and climb to the peak of the mountain on the edge of the island. You stand above the water and take a leap. In the air, you attempt to pull the parachute out, nothing happens. you fall to your death. turns out it was just a regular backpack :D");
        string end3 = Console.ReadLine();
        if (end3 == "thas homophobic")
        {
            Console.Clear();
            Console.WriteLine("my bitch is gay... also game over.");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Game Over.");
        }
        }
        else if (choice11 == "3")
        {
            Console.Clear();
        Console.WriteLine("You flare gun and look at its stats in your inventory. Turns out it has lvl 999 knockback enchantment. you shoot the gun att a 45° towards the ground and get knocked back so far that you land in a resturant in China and eat super good Chinese food :D");
        string goodending = Console.ReadLine();
        if (goodending == "Type shi")
        {
        Console.Clear();
        Console.WriteLine("Wait who's that? It's an asian baddie!");
        Console.WriteLine("You rizz her up and get challenged to a fight with her grandpa in spinjitzu to prove your worthyness");
        Console.WriteLine("You won and now can live happily ever after with your wife :D");
        }
        else
        {
        Console.Clear();
        Console.WriteLine("the end");
        }
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
    Console.WriteLine("Error, terminating FBI spyware.exe");
    Console.ReadLine();
    return;
}

Console.ReadLine();