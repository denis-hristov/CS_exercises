double age = double.Parse(Console.ReadLine());
string jender = Console.ReadLine();

if (jender == "m")
    if (age >= 16) Console.WriteLine("Mr.");
    else Console.WriteLine("Master");
else if (jender == "f")
    if (age >= 16) Console.WriteLine("Ms.");
    else Console.WriteLine("Miss");