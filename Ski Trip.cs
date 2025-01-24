int days = int.Parse(Console.ReadLine());
string roomType = Console.ReadLine();
string feedback = Console.ReadLine();

double pricePerNight = 0;

if (roomType == "room for one person") pricePerNight = 18.00;
else if (roomType == "apartment") pricePerNight = 25.00;
else if (roomType == "president apartment") pricePerNight = 35.00;

int nights = days - 1;
double discount = 0;
if (roomType == "apartment"){
    if (nights < 10) discount = 0.30;
    else if (nights >= 10 && nights <= 15) discount = 0.35;
    else discount = 0.50;
}
else if (roomType == "president apartment") {
    if (nights < 10) discount = 0.10;
    else if (nights >= 10 && nights <= 15) discount = 0.15;
    else discount = 0.20;
}
double totalPrice = pricePerNight * nights;
totalPrice -= totalPrice * discount;

if (feedback == "positive") totalPrice += totalPrice * 0.25;
else if (feedback == "negative") totalPrice -= totalPrice * 0.10;

Console.WriteLine($"{totalPrice:F2}");