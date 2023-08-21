Random r = new Random();
int secretNumber = r.Next(1,100);
int maxGuesses = 0;
int attemptedGuesses = 0;

Console.WriteLine(@"Please choose your difficulty: 
Easy
Medium
Hard");
string difficulty = "null";
while (difficulty == "null")
{
    string response = Console.ReadLine().Trim().ToLower();
    switch (response)
    {
        case "easy":
        difficulty = "Easy";
        maxGuesses = 8;
        break;

        case "medium":
        difficulty = "Medium";
        maxGuesses = 6;
        break;

        case "hard":
        difficulty = "Hard";
        maxGuesses = 4;
        break;

        default:
        Console.WriteLine("Please choose an actual difficulty, stupid.");
        break;
    }
}


while (attemptedGuesses < maxGuesses)
{
  Console.WriteLine($"Guess my secret number. ");
  int guess = int.Parse(Console.ReadLine());
  if (guess == secretNumber)
  {
    Console.WriteLine("You guessed the secret number!!!");
    break;
  }
  else
  {
    if (guess < secretNumber)
      {
        Console.WriteLine("Too Low!");
      }
    else if (guess > secretNumber)
    {
      Console.WriteLine("Too High!");
    }
          attemptedGuesses ++;

    Console.WriteLine($"You guessed wrong LOSER!!! You have left ({maxGuesses - attemptedGuesses})");
  }
}
