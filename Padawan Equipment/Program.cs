double money = double.Parse(Console.ReadLine());

int students = int.Parse(Console.ReadLine());
double priceOflightsabers = double.Parse(Console.ReadLine());
double priceOfRobes = double.Parse(Console.ReadLine());
double priceOfBelts = double.Parse(Console.ReadLine());
double freeBelt = students / 6;
double total = priceOflightsabers * (Math.Ceiling(students + students * 0.1)) + 
    priceOfRobes * students + priceOfBelts * students-freeBelt*priceOfBelts;

if (total <= money)
{
    Console.WriteLine($"The money is enough - it would cost {Math.Ceiling(total):f2}lv.");
}
else
{
    Console.WriteLine($"John will need {total-money:F2}lv more.");  
}
