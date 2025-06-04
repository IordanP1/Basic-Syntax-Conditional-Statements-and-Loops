int count = int.Parse(Console.ReadLine());
string groupType = Console.ReadLine();
string day = Console.ReadLine();

double price = 0;
double totalPrice = 0;
double totalPriceOfVacation = 0;

if (groupType == "Students")
{

    if (day == "Friday")
    {
        price = 8.45;
    }
    else if (day == "Saturday")
    {
        price =9.80;
    }
    else if (day == "Sunday")
    {
        price = 10.46;
    }
    totalPrice = price * count;
    totalPriceOfVacation = totalPrice;

    if (count >= 30)
    {
        totalPriceOfVacation = totalPrice - (totalPrice * 0.15);
    }
}

else if (groupType == "Business")
{
    if(day == "Friday")
    {
        price = 10.90;
    }
    else if (day == "Saturday")
    {
        price = 15.60;
    }
    else if (day == "Sunday")
    {
        price = 16;
    }
    
    if (count >= 100)
    {
        count -= 10;
    }
    totalPriceOfVacation = price * count;
}
else if (groupType == "Regular")
{
    if (day == "Friday")
    {
        price = 15;
    }
    else if (day == "Saturday")
    {
        price =  20;
    }
    else if (day == "Sunday")
    {
        price =  22.50;
    }
    totalPrice = price * count;
    totalPriceOfVacation = totalPrice;

    if (count >= 10 && count <= 20)
    {
        totalPriceOfVacation = totalPrice - (totalPrice * 0.05);
    }
}
//if (groupType == "Students")
//{
//    if (count >= 30)
//    {
//        totalPriceOfVacation = totalPrice - (totalPrice * 0.15);
//    }
//}
//else if (groupType == "Business")
//{
//    if (count >= 100)
//    {
//        count-=10;
//        totalPrice = totalPrice*count;

//    }
//}
//else if (groupType == "Regular")
//{
//    if (count >= 10 && count <= 20)
//    {
//        totalPriceOfVacation = totalPrice - (totalPrice * 0.05);
//    }
//}



Console.WriteLine($"Total price: {totalPriceOfVacation:f2}");