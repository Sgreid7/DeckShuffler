namespace DeckShuffler
{

  public class Card
  {
    // PROPERTIES
    // rank
    public string Rank { get; set; }
    // suit
    public string Suit { get; set; }
    // color
    public string Color { get; set; }

    // Method
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