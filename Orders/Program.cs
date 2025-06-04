int orders = int.Parse(Console.ReadLine());
decimal total = 0;
for (int i = 0; i < orders; i++)
{
    decimal price = decimal.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int capsules = int.Parse(Console.ReadLine());
    decimal orderPrice = ((days * capsules) * price);
    total += orderPrice;

    Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
}

Console.WriteLine($"Total: ${total:f2}");