int secretNumber = 42;
Console.WriteLine("Guess my secret number:");
int guess = int.Parse(Console.ReadLine());
if (guess == secretNumber)
{
    Console.WriteLine("You guess the secret number!!!");
}
else
{
    Console.WriteLine("Try again, LOSER!!!");
}

