using System;
using System.Linq;

namespace Algorithms
{
    public class SegmentTree<T>
    {
        private readonly T[] _originalArray;
        private readonly T[] _segmentArray;
        private readonly Func<T, T, T> _agrFunc;

        public SegmentTree(T[] arr, Func<T, T, T> agrFunc)
        {
            _originalArray = arr.ToArray();
            _agrFunc = agrFunc;
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

        public T CalculateOnRange(int queryStart, int queryEnd)
        {
            var rangeStart = 0;
            var rangeEnd = _originalArray.Length - 1;
            var initialNodeIndex = 0;

            return CalculateOnRangeRecursive(queryStart, queryEnd, initialNodeIndex, rangeStart, rangeEnd);
        }

        private T CalculateOnRangeRecursive(int queryStart, int queryEnd, int nodeIndex, int rangeStart, int rangeEnd)
        {
            if (rangeStart >= queryStart && rangeEnd <= queryEnd)
            {
                return _segmentArray[nodeIndex];
            }

            var leftIndex = 2 * nodeIndex + 1;
            var rightIndex = 2 * nodeIndex + 2;

            var rangeMid = GetRangeMiddle(rangeStart, rangeEnd);

            if (IsOutOfRange(rangeStart, rangeMid, queryStart, queryEnd))
            {
                return CalculateOnRangeRecursive(queryStart, queryEnd, rightIndex, rangeMid + 1, rangeEnd);
            }

            if (IsOutOfRange(rangeMid + 1, rangeEnd, queryStart, queryEnd))
            {
                return CalculateOnRangeRecursive(queryStart, queryEnd, leftIndex, rangeStart, rangeMid);
            }

            var leftAgr = CalculateOnRangeRecursive(queryStart, queryEnd, leftIndex, rangeStart, rangeMid);
            var rightAgr = CalculateOnRangeRecursive(queryStart, queryEnd, rightIndex, rangeMid + 1, rangeEnd);

            return _agrFunc(leftAgr, rightAgr);
        }

        private static int GetRangeMiddle(int start, int end)
        {
            return (start + end) / 2;
        }

        private static int GetSegmentArrayLength(int originalArrayLength)
        {
            var log = Math.Log(originalArrayLength, 2);
            var ceil = (int)Math.Ceiling(log);
            var pow = (int)Math.Pow(2, ceil);

            return 2 * pow - 1;
        }

        private static bool IsOutOfRange(int start, int end, int minStart, int maxEnd)
        {
            return (end < minStart) || (start > maxEnd);
        }
    }
}