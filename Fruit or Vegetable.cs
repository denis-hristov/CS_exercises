string item = Console.ReadLine();

if (item == "banana" || item == "apple"|| item == "kiwi"||
    item == "cherry"|| item == "lemon"|| item == "grapes")
    Console.WriteLine("fruit");
else if (item == "tomato" || item == "cucumber" || item == "pepper"|| item == "carrot")
    Console.WriteLine("vegetable");
else Console.WriteLine("unknown");