using System;

namespace prep.utility.filtering
{
  public static class MatchCreationExtensions
  {
    public static IMatchA<TItemToMatch> equal_to<TItemToMatch,TPropertyType>(this MatchCreationExtensionPoint<TItemToMatch,TPropertyType> extension_point, TPropertyType value)
    {
      return equal_to_any(extension_point, value);
    }

    public static IMatchA<TItemToMatch> equal_to_any<TItemToMatch,TPropertyType>(this MatchCreationExtensionPoint<TItemToMatch,TPropertyType> extension_point, params TPropertyType[] values)
    {
      return create_match(extension_point, new EqualToAny<TPropertyType>(values));
    }

    public static IMatchA<TItemToMatch> not_equal_to<TItemToMatch,TPropertyType>(this MatchCreationExtensionPoint<TItemToMatch,TPropertyType> extension_point, TPropertyType value)
    {
      return equal_to(extension_point, value).not();
    }

    public static IMatchA<TItemToMatch> greater_than<TItemToMatch,TPropertyType>(this MatchCreationExtensionPoint<TItemToMatch,TPropertyType> extension_point, TPropertyType value) where TPropertyType : IComparable<TPropertyType>
    {
      return create_match(extension_point, new GreaterThan<TPropertyType>(value));
    }

    public static IMatchA<TItemToMatch> between<TItemToMatch,TPropertyType>(this MatchCreationExtensionPoint<TItemToMatch,TPropertyType> extension_point, TPropertyType start, TPropertyType end) where TPropertyType : IComparable<TPropertyType>
    {
      return create_match(extension_point, new FallsInRange<TPropertyType>(start, end));
    }

    public static IMatchA<TItemToMatch> create_match<TItemToMatch,TPropertyType>(this MatchCreationExtensionPoint<TItemToMatch,TPropertyType> extension_point, IMatchA<TPropertyType> value_criteria)
    {
      return new PropertyMatch<TItemToMatch, TPropertyType>(extension_point.accessor,
                                                            value_criteria);
    }
  }
}
