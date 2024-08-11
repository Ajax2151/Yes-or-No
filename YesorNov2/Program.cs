Random samBot = new Random();

string samAnswer = " ";
string playerGuess = " ";
string playerAnswer = " ";
string rightAnswer = "That is correct!";
string wrongAnswer = "Oooh, sorry. That's incorrect.";

Console.WriteLine("Players, your question is: Yes, or No.");
playerGuess = Console.ReadLine().ToLower().Trim();

if ((playerGuess != "y") && (playerGuess != "yes") && (playerGuess != "n") && (playerGuess != "no"))
{
    Console.WriteLine("Oooh, sorry, player. That's not a valid answer.");
}
else
{
    int samRandom = samBot.Next(2);

    if (samRandom == 1)
        samAnswer = "Yes";
    else
        samAnswer = "No";

    switch (playerGuess)
    {
        case "yes":
            playerAnswer = "Yes";
            break;
        case "y":
            playerAnswer = "Yes";
            break;
        case "no":
            playerAnswer = "No";
            break;
        case "n":
            playerAnswer = "No";
            break;
    }

    if (samAnswer == playerAnswer)
        Console.WriteLine(rightAnswer);
    else
        Console.WriteLine(wrongAnswer);

    Console.WriteLine($"The answer in this particular case is '{samAnswer}'.");
}