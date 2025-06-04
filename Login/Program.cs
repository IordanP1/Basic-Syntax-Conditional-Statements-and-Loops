string username = Console.ReadLine();
string realPassword = ""; ;
for (int i = username.Length - 1; i >= 0; i--)
{
    char currentChar = username[i];
    realPassword +=currentChar;
    
}
int count = 0;
while (true)
{
    string password = Console.ReadLine();
    if (password == realPassword)
    {
        Console.WriteLine($"User {username} logged in.");
        break;
    }
    else if (password != realPassword)
    {
        Console.WriteLine("Incorrect password. Try again.");
        count++;
        
    }
     if (count > 3)
    {
        Console.WriteLine($"User {username} blocked!");
        break;
    }
       
}
