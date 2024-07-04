var rand = new Random();

for (var i = 0; i < 100; i++)
{
    int coinSide = rand.Next(2);

    Console.WriteLine($"{(coinSide == 0 ? "heads" : "tails")}");
}
