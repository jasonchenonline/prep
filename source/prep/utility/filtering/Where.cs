namespace prep.utility.filtering
{
  public delegate TPropertyValueType IGetTheValueOfAProperty<TItemToGetValueFrom, TPropertyValueType>(
    TItemToGetValueFrom item_to_get_value_from);

  public class Where<TItemToMatch>
  {
    public static MatchCreationExtensionPoint<TItemToMatch, TPropertyType> has_a<TPropertyType>(
      IGetTheValueOfAProperty<TItemToMatch, TPropertyType> property_accessor)
    {
      return new MatchCreationExtensionPoint<TItemToMatch, TPropertyType>(property_accessor);
    }

  }
}