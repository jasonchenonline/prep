namespace prep.utility.filtering
{
  public class NeverMatches<TItemToMatch> : IMatchA<TItemToMatch>
  {
    public bool matches(TItemToMatch item)
    {
      return false;
    }
  }
}