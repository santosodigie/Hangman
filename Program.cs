// See https://aka.ms/new-console-template for more information
Random rand = new Random();
Greeting();

string[] randomWords = { "decrease", "accept", "center", "vacuum", "danger", "mess", "similar", "voucher", "admission", "mother", "confrontation", "equinox", "painter", "fortune", "origin", "bother", "father", "goverment", "expose", "christian", "chelsea", "arsenal", "nonremittal", "jewel", "heir", "drum", "dismissal" };
int index = rand.Next(randomWords.Length);
string wordToGuess = randomWords[index];
int maxLives = 7;
int currentLives = maxLives;
bool win = false;

List<char> guessedLetters = new List<char>();

while (currentLives > 0 && !win)
{
    foreach (char c in wordToGuess)
    {
        if (guessedLetters.Contains(c))
        {
            Console.Write(c);
        }
        else
        {
            Console.Write("_ ");
        }
    }
    Console.WriteLine("\nPlease guess a letter!");
    Console.WriteLine(currentLives + "/" + maxLives + " lives remaining");

    char guess = Convert.ToChar(Console.ReadLine());

    if (wordToGuess.Contains(guess) && !guessedLetters.Contains(guess))
    {
        Console.WriteLine("Correct");
    }
    else
    {
        Console.WriteLine("Incorrect");
        currentLives--;
    }
    guessedLetters.Add(guess);

    bool woordComplete = true;

    foreach (char c in wordToGuess)
    {
        if (!guessedLetters.Contains(c))
        {
            woordComplete = false;
        }
        win = woordComplete;
    }

}

if (win)
{
    Console.WriteLine("Congrats, You have won");
}
else
{
    Console.WriteLine($"You lose...\n\n The word was {wordToGuess}");
}



static void Greeting()
{
    Console.WriteLine("Hello welcome to my simple hangman project");
}

