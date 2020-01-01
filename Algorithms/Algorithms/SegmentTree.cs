using System;
using System.Linq;

namespace Algorithms
{
    public class SegmentTree<T>
    {
        private readonly T[] _originalArray;
        private readonly T[] _segmentArray;
        private readonly Func<T, T, T> _agrFunc;
        private readonly T _defaultValue;

        public SegmentTree(T[] arr, Func<T, T, T> agrFunc, T defaultValue)
        {
            _originalArray = arr.ToArray();
            _agrFunc = agrFunc;
            _defaultValue = defaultValue;
            _segmentArray = InitializeSegmentArray();

            BuildArray();
        }

        private T[] InitializeSegmentArray()
        {
            var segmentArrayLength = GetSegmentArrayLength(_originalArray.Length);
            return new T[segmentArrayLength];
        }

        private void BuildArray()
        {
            BuildArrayRecursive(0, 0, _originalArray.Length - 1);
        }

        private T BuildArrayRecursive(int index, int start, int end)
        {
            if (start == end)
            {
                _segmentArray[index] = _originalArray[start];
                return _originalArray[start];
            }

            var leftIndex = 2 * index + 1;
            var rightIndex = 2 * index + 2;

            var middle = GetRangeMiddle(start, end);

            var leftAgr = BuildArrayRecursive(leftIndex, start, middle);
            var rightAgr = BuildArrayRecursive(rightIndex, middle + 1, end);

            _segmentArray[index] = _agrFunc(leftAgr, rightAgr);
            return _segmentArray[index];
        }

        public T CalculateOnRange(int start, int end)
        {
            return CalculateOnRangeRecursive(start, end, 0, 0, _originalArray.Length - 1);
        }

        private T CalculateOnRangeRecursive(int start, int end, int nodeIndex, int nodeStart, int nodeEnd)
        {
            if (nodeStart >= start && nodeEnd <= end)
            {
                return _segmentArray[nodeIndex];
            }

            if (end < nodeStart || nodeEnd < start)
            {
                return _defaultValue;
            }

            var leftIndex = 2 * nodeIndex + 1;
            var rightIndex = 2 * nodeIndex + 2;

            var mid = GetRangeMiddle(nodeStart, nodeEnd);

            var leftAgr = CalculateOnRangeRecursive(start, end, leftIndex, nodeStart, mid);
            var rightAgr = CalculateOnRangeRecursive(start, end, rightIndex, mid + 1, nodeEnd);

            return _agrFunc(leftAgr, rightAgr);
        }

        private int GetRangeMiddle(int start, int end)
        {
            return (start + end) / 2;
        }

        private int GetSegmentArrayLength(int originalArrayLength)
        {
            return 4 * originalArrayLength - 1;
        }
    }
}