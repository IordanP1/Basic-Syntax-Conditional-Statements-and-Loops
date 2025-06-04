using System.Runtime.InteropServices;

double sum = 0;
string input;

while ((input = Console.ReadLine()) != "Start")
{
    double coin = double.Parse(input);
	if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2) 
	{
		sum += coin;
	}
	else
	{
        Console.WriteLine($"Cannot accept {coin}");
	}
}

while ((input = Console.ReadLine()) != "End")
{
	double price = 0;
	bool isValidProduct = true;
	switch (input)
	{
		case "Nuts":
			price = 2.0;
			break;
		case "Water":
			price = 0.7;
			break;
        case "Crisps":
            price = 1.5;
            break;
        case "Soda":
            price = 0.8;
            break;
        case "Coke":
            price = 1;
            break;
		default:
            Console.WriteLine("Invalid product");
			isValidProduct = false;
			break;

    }
	if (!isValidProduct)
	{
		continue;
	}
	if (sum>=price)
	{
		sum -= price;
        Console.WriteLine($"Purchased {input.ToLower()}");
	}
	else
	{
        Console.WriteLine($"Sorry, not enough money");
	}
}
Console.WriteLine($"Change: {sum:f2}");
