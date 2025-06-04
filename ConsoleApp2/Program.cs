int number = int.Parse(Console.ReadLine());
int origNumber = number;
int sum = 0;

while (number>0)
{
    int fact = 1;
    int lastDigit = number % 10;
    number /= 10;
    for (int i = 1; i <= lastDigit; i++)
    {
        fact *= i;
    }
    sum += fact;

    
}
if (sum == origNumber)
{
    Console.WriteLine("yes");
}
else if (sum != origNumber)
{
    Console.WriteLine("no");
}