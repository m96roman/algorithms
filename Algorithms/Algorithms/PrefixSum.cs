using System;
using System.Linq;

namespace Algorithms
{
    public class PrefixSum<T>
    {
        private readonly T[] _originalArray;
        private readonly Lazy<T[]> _prefixSumArray;
        private readonly Func<T, T, T> _sumFunc;
        private readonly Func<T, T, T> _diffFunc;

        public PrefixSum(T[] arr, Func<T, T, T> sumFunc, Func<T, T, T> diffFunc)
        {
            _originalArray = arr.ToArray();
            _sumFunc = sumFunc;
            _diffFunc = diffFunc;
            _prefixSumArray = new Lazy<T[]>(BuildPrefixSumArray);
        }

        public T GetSumOnRange(int startIndex, int endIndex)
        {
            var array = _prefixSumArray.Value;

            if (startIndex == 0)
            {
                return array[endIndex];
            }

            return _diffFunc(array[endIndex], array[startIndex - 1]);
        }

        public T[] GetSumArray()
        {
            return _prefixSumArray.Value.ToArray();
        }

        private T[] BuildPrefixSumArray()
        {
            var length = _originalArray.Length;
            var array = new T[length];

            if (length == 0)
            {
                return array;
            }

            array[0] = _originalArray[0];

            for (var i = 1; i < length; ++i)
            {
                array[i] = _sumFunc(array[i - 1], _originalArray[i]);
            }

            return array;
        }
    }
}
