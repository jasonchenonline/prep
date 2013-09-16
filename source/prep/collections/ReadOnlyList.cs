using System.Collections;
using System.Collections.Generic;

namespace prep.collections
{
  public class ReadOnlyList<T> : IEnumerable<T>
  {
    IEnumerable<T> list;

    public ReadOnlyList(IEnumerable<T> list)
    {
      this.list = list;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }

    public IEnumerator<T> GetEnumerator()
    {
      return list.GetEnumerator();
    }
  }
}