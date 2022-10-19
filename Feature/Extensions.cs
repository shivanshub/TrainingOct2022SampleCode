

using System.ComponentModel.DataAnnotations.Schema;

namespace Feature
{
    internal static class ProjectExtensions
    {

        public static string ClientSpecificDateFormat(this DateTime time)
        {
            return $"Exact time is {time.ToLongTimeString()}";
        }


        public static int[] ConvertToArray(this IList<int> list)
        {
            var intArray = new int[list.Count];

            var i = 0;
            foreach (var number in list)
            {
                intArray[i] = number;
                i++;

            }

            return intArray;
        }
    }
}
