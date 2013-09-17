using System;

namespace prep.utility.filtering
{
  public class ComparableMatchFactory<TItemToMatch, TPropertyType> where TPropertyType : IComparable<TPropertyType>
  {
    IGetTheValueOfAProperty<TItemToMatch, TPropertyType> property_accessor;

    public ComparableMatchFactory(IGetTheValueOfAProperty<TItemToMatch, TPropertyType> property_accessor)
    {
      this.property_accessor = property_accessor;
    }

    public IMatchA<TItemToMatch> greater_than(TPropertyType value)
    {
      //return new AnonymousMatch<TItemToMatch>(x => property_accessor(x).CompareTo(value) > 0);
        return MyMatchFactory<TItemToMatch>.getMatch(x => property_accessor(x).CompareTo(value) > 0);
    }

    public IMatchA<TItemToMatch> between(TPropertyType start, TPropertyType end)
    {
      //return new AnonymousMatch<TItemToMatch>(x =>
      //{
       // var value = property_accessor(x);
        //return value.CompareTo(start) >= 0 && value.CompareTo(end) <= 0;
      //});

    return MyMatchFactory<TItemToMatch>.getMatch(x =>
      {
        var value = property_accessor(x);
        return value.CompareTo(start) >= 0 && value.CompareTo(end) <= 0;
      });
    
    }
  }
}