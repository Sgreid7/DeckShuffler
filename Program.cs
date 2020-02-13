using System;
using System.Collections.Generic;

namespace DeckShuffler
{
  class Program
  {
    static void Main(string[] args)
    {

      // List out the suits and values
      var suit = new string[] { "Clubs", "Diamonds", "Hearts", "Spades" };
      var value = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
      var card = "";
      var deck = new List<string>();
      // Iterate over each index in the suit array 
      // Iterate over each index in the value array
      // Loop through both arrays to assign each value to each suit 
      // This will create a deck of 52 cards for the user
      for (var i = 0; i < suit.Length; i++)
      {
        for (var j = 0; j < value.Length; j++)
        {
          // Generate a single value and assign it to the card variable
          card = $"{value[j]} of {suit[i]}";
          deck.Add(card);
        }
      }

      // Now that deck is complete, use the algorithm to shuffle the deck
      var rnd = new Random();
      // for i from n - 1 down to 1 do:
      for (var i = 52 - 1; i >= 1; i--)
      {
        // j = random integer (where 0 <= j <= i)
        int j = rnd.Next(deck.Count);
        // swap deck[i] with deck[j]
        var temp = deck[i];
        deck[i] = deck[j];
        deck[j] = temp;
      }

      // Print out shuffled deck if necessary
      // for (int i = 0; i < deck.Count; i++)
      // {
      //   Console.WriteLine(deck[i]);
      // }

      // // After deck is shuffled, print out the top card
      // // Print out the first index of the deck list
      Console.WriteLine($"The top card that you drew was {deck[0]}");
      // Remove that top card from the deck
      deck.RemoveAt(0);

      var isPlaying = true;
      while (isPlaying)
      {

        Console.WriteLine("What would you like to do next?");
        Console.WriteLine("(DRAW) the next card");
        Console.WriteLine("(QUIT) the program");
        var answer = Console.ReadLine().ToLower();
        // Keep track of top card - give it the 1st index as the 0 index is already dealt above
        var topCard = deck[0];

        // if answer isn't a valid answer, prompt the question again
        while (answer != "draw" && answer != "quit")
        {
          Console.WriteLine("I'm sorry, that is not a valid option. Please choose again.");
          Console.WriteLine("What would you like to do next?");
          Console.WriteLine("(DRAW) the next card");
          Console.WriteLine("(QUIT) the program");
          answer = Console.ReadLine().ToLower();
        }

        // create solutions for the valid answers
        if (answer == "draw" && deck.Count >= 1)
        {
          // Check if out of cards
          // If there are no more cards, end the game
          // Alert user of next card
          Console.WriteLine($"The next card that you drew was {topCard}");
          // Remove that card from the deck
          deck.RemoveAt(0);
          // the next card in the deck will now equal the first index
          topCard = deck[0];
          // Check if out of cards
          // If there are no more cards, end the game
        }
        else if (answer == "draw" && deck.Count == 0)
        {
          isPlaying = false;
          Console.WriteLine("I'm sorry, there are no more cards left. Thanks for playing. See you next time!");
        }
        else if (answer == "quit")
        {
          isPlaying = false;
          Console.WriteLine("Thank you for playing, I hope you had fun. See you next time!");
        }
      }

    }
  }
}
