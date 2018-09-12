using System.Collections.Generic;
using System.Linq;

namespace FlattenArray
{
    public static class ArrayExtensions
    {
        private static IList<int> _resultArray;

        public static int[] ToFlat(this object[] inputArray)
        {
            _resultArray = new List<int>();
            RecursivelyFlat(inputArray);

            return _resultArray.ToArray();
        }

        private static void RecursivelyFlat(object[] myArray)
        {
            foreach (var item in myArray)
            {
                if (item.GetType().IsArray)
                    RecursivelyFlat(item as object[]);
                else
                    _resultArray.Add((int)item);
            }
        }
    }
}
