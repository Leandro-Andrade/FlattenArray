using System.Collections.Generic;
using System.Linq;

namespace FlattenArray
{
    public class ArrayHelper
    {
        private static IList<int> _resultArray;

        public ArrayHelper()
        {
            _resultArray = new List<int>();
        }

        public int[] ToFlat(object[] inputArray)
        {
            RecursivelyFlat(inputArray);

            return _resultArray.ToArray();
        }

        private void RecursivelyFlat(object[] myArray)
        {
            for (var idx = 0; idx < myArray.Length; idx++)
            {
                if (myArray[idx].GetType().IsArray)
                    RecursivelyFlat(myArray[idx] as object[]);
                else
                    _resultArray.Add((int)myArray[idx]);
            }
        }
    }
}
