using System;

string tipe = Console.ReadLine();
double pieces = double.Parse(Console.ReadLine());
double budget = double.Parse(Console.ReadLine());

double cost=0.0;
if (tipe == "Roses") cost = pieces * 5;
else if (tipe == "Dahlias") cost = pieces * 3.8;
else if (tipe == "Tulips") cost = pieces * 2.8;
else if (tipe == "Narcissus") cost = pieces * 3;
else if (tipe == "Gladiolus") cost = pieces * 2.5;

if (pieces > 80 && tipe == "Roses") cost *= 0.9;
else if (pieces > 90 && tipe == "Dahlias") cost *= 0.85;
else if (pieces > 80 && tipe == "Tulips") cost *= 0.85;
else if (pieces < 120 && tipe == "Narcissus") cost *= 1.15;
else if (pieces < 80 && tipe == "Gladiolus") cost *= 1.2;

if (cost <= budget)
    Console.WriteLine($"Hey, you have a great garden with {pieces} {tipe} and {(budget-cost):F2} leva left.");
else
    Console.WriteLine($"Not enough money, you need { (cost - budget):F2} leva more.");