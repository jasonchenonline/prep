namespace prep.utility.filtering
{
    public class GreaterMatch<TItemToMatch> : IMatchA<TItemToMatch>
    {
        IMatchA<TItemToMatch> greater_to;

        public GreaterMatch(IMatchA<TItemToMatch> greater_to)
        {
            this.greater_to = greater_to;
        }

        public bool matches(TItemToMatch item)
        {
            return item > greater_to;
        }
    }
}
