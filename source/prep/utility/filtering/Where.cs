using System.Collections.Generic;
using prep.collections;

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
  }

  /// <summary>
  /// Factory pattern implementation - Creates specifications
  /// </summary>
  /// <typeparam name="TItemToMatch"></typeparam>
  /// <typeparam name="TPropertyType"></typeparam>
  public class MatchFactory<TItemToMatch, TPropertyType>
  {
    IGetTheValueOfAProperty<TItemToMatch, TPropertyType> property_accessor;

    public MatchFactory(IGetTheValueOfAProperty<TItemToMatch, TPropertyType> property_accessor)
    {
      this.property_accessor = property_accessor;
    }

    public IMatchA<TItemToMatch> equal_to(TPropertyType value)
    {
      return equal_to_any(value);
    }

    public IMatchA<TItemToMatch> equal_to_any(params TPropertyType[] values)
    {
      return new AnonymousMatch<TItemToMatch>(x =>
      {
        var property_value = property_accessor(x);
        var all_possible_values = new List<TPropertyType>(values);
        return all_possible_values.Contains(property_value);
      });
    }

    public IMatchA<TItemToMatch> not_equal_to(TPropertyType value)
    {
      throw new System.NotImplementedException();
    }
  }
}