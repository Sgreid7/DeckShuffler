# DeckShuffler

A console app that creates and shuffles a new deck for you to draw from and keeps track fo your hand.

# Includes:

- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
- Classes and Methods

```JSX
namespace DeckShuffler
{

  public class Card
  {

    public string Rank { get; set; }

    public string Suit { get; set; }

    public string Color { get; set; }


    public string displayCard()
    {
      return $"{Rank} of {Suit}";
    }

    public int getValue()
    {
      if (Rank == "ace")
      {
        return 11;
      }
      else if (Rank == "queen" || Rank == "king" || Rank == "jack")
      {
        return 10;
      }
      else
      {
        return int.Parse(Rank);
      }
    }
  }
}
```
