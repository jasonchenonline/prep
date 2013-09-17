namespace prep.utility.filtering
{
  public static class MatchExtensions
  {
    public static IMatchA<ItemToMatch> or<ItemToMatch>(this IMatchA<ItemToMatch> left_side,
                                                       IMatchA<ItemToMatch> right_side)
    {
      return new OrMatch<ItemToMatch>(left_side, right_side);
    }

    public static IMatchA<ItemToMatch> not<ItemToMatch>(this IMatchA<ItemToMatch> to_negate)
                                                       
    {
      return new NegatingMatch<ItemToMatch>(to_negate);
    }
    public static IMatchA<ItemToMatch> greater_than<ItemToMatch>(this IMatchA<ItemToMatch> value)
                                                       
    {
      return new NegatingMatch<ItemToMatch>(to_negate);
    }

  }
}