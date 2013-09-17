using System;

namespace prep.utility.filtering
{
  public static class DateMatchCreationExtensions
  {
    public static IMatchA<TItemToMatch> greater_than<TItemToMatch>(
      this MatchCreationExtensionPoint<TItemToMatch, DateTime> extension_point, int value)
    {
      return extension_point.create_match(Where<DateTime>.has_a(x => x.Year).greater_than(value));
    }
  }
}