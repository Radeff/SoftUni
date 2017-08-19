namespace _06.CustomEnumAttribute
{
    [Type("Enumeration", "Rank", "Provides rank constants for a Card class.")]

    public enum CardRank
    {
        
        Two = 2,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace = 14
    }
}