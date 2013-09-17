namespace prep.utility.filtering
{
  public class NegatingMatch<TItemToMatch> : IMatchA<TItemToMatch>
  {
    IMatchA<TItemToMatch> to_negate;

    public NegatingMatch(IMatchA<TItemToMatch> to_negate)
    {
      this.to_negate = to_negate;
    }

    public bool matches(TItemToMatch item)
    {
      return ! to_negate.matches(item);
    }
  }
}