using System;

namespace prep.utility.filtering
{
  public delegate TPropertyValueType IGetTheValueOfAProperty<TItemToGetValueFrom, TPropertyValueType>(
    TItemToGetValueFrom item_to_get_value_from);

  /// <summary>
  /// Where class is a gateway to a specification factory
  /// </summary>
  /// <typeparam name="TItemToMatch"></typeparam>
  public class Where<TItemToMatch>
  {
    public static MatchFactory<TItemToMatch, TPropertyType> has_a<TPropertyType>(
      IGetTheValueOfAProperty<TItemToMatch, TPropertyType> property_accessor)
    {
      return new MatchFactory<TItemToMatch, TPropertyType>(property_accessor);
    }

    public static ComparableMatchFactory<TItemToMatch, TPropertyType> has_an<TPropertyType>(
      IGetTheValueOfAProperty<TItemToMatch, TPropertyType> property_accessor) where TPropertyType : IComparable<TPropertyType>
    {
      return new ComparableMatchFactory<TItemToMatch, TPropertyType>(property_accessor);
    }
  }
}