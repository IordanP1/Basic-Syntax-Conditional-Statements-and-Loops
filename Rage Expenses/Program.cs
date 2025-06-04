int gameLost = int.Parse(Console.ReadLine());
decimal headsetPrice = decimal.Parse(Console.ReadLine());
decimal mousePrice = decimal.Parse(Console.ReadLine());
decimal keyboardPrice = decimal.Parse(Console.ReadLine());
decimal displayPrice = decimal.Parse(Console.ReadLine());

int headsetCount = gameLost / 2;
int mouseCount = gameLost / 3;
int keyboardCount = gameLost / 6;
int displayCount = keyboardCount / 2;

decimal total = (headsetCount * headsetPrice) + (mouseCount * mousePrice)
    + (keyboardCount * keyboardPrice)+ (displayCount * displayPrice);

Console.WriteLine($"Rage expenses: {total:f2} lv.");