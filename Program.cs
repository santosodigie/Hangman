﻿// See https://aka.ms/new-console-template for more information
Greeting();

string wordToGuess = "chelsea";
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

}



static void Greeting()
{
    Console.WriteLine("Hello welcome to my simple hangman project");
}

