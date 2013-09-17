namespace prep.utility.filtering
{
  public class PropertyMatch<TItemToMatch, TPropertyType> : IMatchA<TItemToMatch>
  {
    IGetTheValueOfAProperty<TItemToMatch, TPropertyType> get_the_value;
    IMatchA<TPropertyType> value_criteria;

    public PropertyMatch(IGetTheValueOfAProperty<TItemToMatch, TPropertyType> get_the_value, IMatchA<TPropertyType> value_criteria)
    {
      this.get_the_value = get_the_value;
      this.value_criteria = value_criteria;
    }

    public bool matches(TItemToMatch item)
    {
      var value = get_the_value(item);
      return value_criteria.matches(value);
    }
  }
}