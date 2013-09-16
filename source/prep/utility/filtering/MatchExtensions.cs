namespace prep.utility.filtering
{
  public static class MatchExtensions
  {
    public static IMatchA<ItemToMatch> or<ItemToMatch>(this IMatchA<ItemToMatch> left_side,
                                                       IMatchA<ItemToMatch> right_side)
    {
      return new OrMatch<ItemToMatch>(left_side, right_side);
    }
  }
}