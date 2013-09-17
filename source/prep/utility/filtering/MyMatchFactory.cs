using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prep.utility.filtering
{
    class  MyMatchFactory <ItemToMatch> 
    {
        //public delegate bool Condition<T>(T item);
        public static AnonymousMatch<ItemToMatch> getMatch(Condition<ItemToMatch> condition)
        {
            return new AnonymousMatch<ItemToMatch>(condition);
        }
        
    }
}
