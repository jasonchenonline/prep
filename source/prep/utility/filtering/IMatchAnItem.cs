namespace prep.utility.filtering
{
  public interface IMatchA<ItemToMatch>
  {
    bool matches(ItemToMatch item);
  }
}