using System;

namespace prep.utility.filtering
{
  public class FallsInRange<T> : IMatchA<T> where T : IComparable<T>
  {
    T start;
    T end;

    public FallsInRange(T start, T end)
    {
      this.start = start;
      this.end = end;
    }

    public bool matches(T item)
    {
      return item.CompareTo(start) >= 0 && item.CompareTo(end) <= 0;
    }
  }
}