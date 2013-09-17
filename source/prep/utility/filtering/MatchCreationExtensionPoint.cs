namespace prep.utility.filtering
{
  public class MatchCreationExtensionPoint<TItemToMatch, TPropertyType>
  {
    public IGetTheValueOfAProperty<TItemToMatch, TPropertyType> accessor { get; set; }

    public MatchCreationExtensionPoint(IGetTheValueOfAProperty<TItemToMatch, TPropertyType> property_accessor)
    {
      this.accessor = property_accessor;
    }
  }
}