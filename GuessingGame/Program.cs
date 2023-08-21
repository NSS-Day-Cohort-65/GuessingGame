int secretNumber = 42;
int maxGuesses = 4;
int attemptedGuesses = 0;
while (attemptedGuesses < maxGuesses)
{
  Console.WriteLine($" Guess ({attemptedGuesses + 1}) - Guess my secret number:");
  int guess = int.Parse(Console.ReadLine());
  if (guess == secretNumber)
  {
    Console.WriteLine("You guessed the secret number!!!");
    break;
  }
  else
  {
    attemptedGuesses ++;
    Console.WriteLine("You guessed wrong LOSER!!!");
  }
}
