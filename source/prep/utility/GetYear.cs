using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using prep.utility.filtering;

namespace prep.utility
{
    class GetYear
    {
        public static int Year(DateTime dateTime)
        {
            return dateTime.Year;
        }

        public static IMatchA<TItemToMatch> greater_than<TItemToMatch>(this MatchCreationExtensionPoint<TItemToMatch, DateTime> extension_point, DateTime value) where TPropertyType : IComparable<TPropertyType>
        {
            return create_match(extension_point, new GreaterThan<DateTime>(value));
        }


    }
}   
