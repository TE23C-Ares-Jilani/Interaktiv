Console.WriteLine("You wake up in a dark forest with no memory of how you got there. A glint of metal catches your eye. You notice a small key lies half-buried in the dirt beside you.");
Console.WriteLine("option 1. Pick up the key. Option 2. Ignore the key and walk deeper into the forest. Write the Corusponding number to the choice you make.");
String choice1 = Console.ReadLine();

if (choice1 == "1")
{
    Console.Clear();
    Console.WriteLine("As you hold the key, a distant whisper fills the air. The trees sway unnaturally, and a hidden path opens before you.");

string choice2 = Console.ReadLine();
    if (choice2 == "1")
    {
        Console.Clear();
        Console.WriteLine("You step onto the path, the whisper growing louder with each step. The trees bend toward you, their branches almost guiding your way. Soon, you arrive at a stone archway, overgrown with vines. Beyond it, you see a glowing chest resting in the center of a small clearing.");
        Console.WriteLine("1. Follow the path. 2. Drop the key and stay where you are.");
    }
    else if (choice2 == "2")
    {
        Console.Clear();
        Console.WriteLine("You walk deeper and get rick rolled :D");
    }
}
else if (choice1 == "2")
{
    Console.Clear();
    Console.WriteLine("You leave the key behind and venture into the thick trees. After walking for hours, you stumble upon a small cabin with a locked door.");
}
else
{
    Console.WriteLine("Error, terminating IDF.exe");
    Console.ReadLine();
    return;
}

Console.ReadLine();