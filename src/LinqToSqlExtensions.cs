using System;
using System.Collections.Generic;
using System.Text;

#if NET6_0
namespace System.Data.Linq
{
    public static class LinqToSqlExtensions
    {
        // These extension methods make it easier for users to compare dates with datetimes.

        public static DateOnly DateOnly (this DateTime dateTime) => System.DateOnly.FromDateTime (dateTime);
        public static DateOnly? DateOnly (this DateTime? dateTime) => dateTime == null ? null : System.DateOnly.FromDateTime (dateTime.Value);

        public static TimeOnly TimeOnly (this DateTime dateTime) => System.TimeOnly.FromDateTime (dateTime);
        public static TimeOnly? TimeOnly (this DateTime? dateTime) => dateTime == null ? null : System.TimeOnly.FromDateTime (dateTime.Value);
    }
}
#endif
