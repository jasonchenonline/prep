using System;

namespace prep.utility.filtering
{
  public delegate TPropertyValueType IGetTheValueOfAProperty<TItemToGetValueFrom, TPropertyValueType>(
    TItemToGetValueFrom item_to_get_value_from);

  public class Where<TItemToMatch>
  {
    public static MatchFactory<TItemToMatch, TPropertyType> has_a<TPropertyType>(
      IGetTheValueOfAProperty<TItemToMatch, TPropertyType> property_accessor)
    {
      throw new NotImplementedException();
    }
  }

  public class MatchFactory<TItemToMatch, TPropertyType>
  {
    public IMatchA<TItemToMatch> equal_to(TPropertyType value)
    {
      throw new NotImplementedException();
    }
  }
}