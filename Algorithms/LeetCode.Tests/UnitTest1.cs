using System.Collections.Generic;
using System.Linq;
using LeetCode.Domain;
using Xunit;

namespace LeetCode.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(5, new[] { 1, 2, 5 }, 4)]
        [InlineData(3, new[] { 2 }, 0)]
        [InlineData(10, new[] { 10 }, 1)]
        [InlineData(8, new int[0], 0)]
        [InlineData(9, new[] { 3 }, 1)]
        public void CoinChange2_Change(int amount, int[] coins, int expected)
        {
            var algo = new CoinChange2();
            var actual = algo.Change(amount, coins);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
        [InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]
        public void TwoSum_Solve(int[] nums, int target, int[] expected)
        {
            var algo = new TwoSum();
            var actual = algo.Solve(nums, target);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(12, 30, 165)]
        [InlineData(3, 30, 75)]
        [InlineData(3, 15, 7.5)]
        [InlineData(4, 50, 155)]
        [InlineData(24, 0, 0)]
        public void AngleBetweenHandsOfaClock_AngleClock(int hour, int minutes, double expected)
        {
            var algo = new AngleBetweenHandsOfaClock();
            var actual = algo.AngleClock(hour, minutes);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("the sky is blue", "blue is sky the")]
        [InlineData("  hello world!  ", "world! hello")]
        [InlineData("a good   example", "example good a")]
        public void ReverseWordsInAString_ReverseWords(string s, string expected)
        {
            var algo = new ReverseWordsInAString();
            var actual = algo.ReverseWords(s);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 2)]
        [InlineData(8, 3)]
        [InlineData(1, 1)]
        [InlineData(3, 2)]
        [InlineData(1804289383, 60070)]
        public void ArrangingCoins_ArrangeCoins(int n, int expected)
        {
            var algo = new ArrangingCoins();
            var actual = algo.ArrangeCoins(n);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 5 }, 11, 3)]
        [InlineData(new[] { 2, 5, 10, 1 }, 27, 4)]
        [InlineData(new[] { 1, 2, 3, 4 }, 6, 2)]
        [InlineData(new[] { 2 }, 3, -1)]
        [InlineData(new[] { 186, 419, 83, 408 }, 6249, 20)]
        public void CoinChange_Change(int[] coins, int amount, int expected)
        {
            var algo = new CoinChange();
            var actual = algo.Change(coins, amount);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 5)]
        [InlineData(4, 14)]
        public void UniqueBinarySearchTrees_NumTrees(int n, int expected)
        {
            var algo = new UniqueBinarySearchTrees();
            var actual = algo.NumTrees(n);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(15, 4, 19)]
        [InlineData(9, 3, 13)]
        public void WaterBottles_NumWaterBottles(int numBottles, int numExchange, int expected)
        {
            var algo = new WaterBottles();
            var actual = algo.NumWaterBottles(numBottles, numExchange);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 3, 5 }, 4)]
        [InlineData(new[] { 2, 4, 6 }, 0)]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7 }, 16)]
        [InlineData(new[] { 10, 100, 99, 99 }, 4)]
        [InlineData(new[] { 7 }, 1)]
        [InlineData(new[] { 1, 2 }, 2)]
        [InlineData(new[] { 1, 2, 3 }, 4)]
        [InlineData(new[] { 2, 5, 7 }, 3)]
        public void NumberOfSubArraysWithOddSum_NumOfSubarrays(int[] arr, int expected)
        {
            var algo = new NumberOfSubArraysWithOddSum();
            var actual = algo.NumOfSubarrays(arr);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 7, 3)]
        [InlineData(8, 10, 1)]
        public void CountOddNumbersInAnIntervalRange_CountOdds(int low, int high, int expected)
        {
            var algo = new CountOddNumbersInAnIntervalRange();
            var actual = algo.CountOdds(low, high);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("codeleet", new[] { 4, 5, 6, 7, 0, 2, 1, 3 }, "leetcode")]
        [InlineData("aiohn", new[] { 3, 1, 4, 2, 0 }, "nihao")]
        public void ShuffleString_RestoreString(string s, int[] indices, string expected)
        {
            var algo = new ShuffleString(); ;
            var actual = algo.RestoreString(s, indices);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("10111", 3)]
        [InlineData("101", 3)]
        [InlineData("00000", 0)]
        [InlineData("001011101", 5)]
        [InlineData("100", 2)]
        [InlineData("10100", 4)]
        public void BulbSwitcherIV_MinFlips(string target, int expected)
        {
            var algo = new BulbSwitcherIV();
            var actual = algo.MinFlips(target);

            Assert.Equal(expected, actual); ;
        }

        [Theory]
        [MemberData(nameof(NumberOfGoodLeafNodesPairs_CountPairs_Data))]
        public void NumberOfGoodLeafNodesPairs_CountPairs(TreeNode root, int distance, int expected)
        {
            var algo = new NumberOfGoodLeafNodesPairs();
            var actual = algo.CountPairs(root, distance);

            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> NumberOfGoodLeafNodesPairs_CountPairs_Data()
        {
            yield return new object[]
            {
                ReadBinary(1,2,3,null,4),
                3,
                1
            };

            yield return new object[]
            {
                ReadBinary(1,2,3,4,5,6,7),
                3,
                2
            };

            yield return new object[]
            {
                ReadBinary(7,1,4,6,null,5,3,null,null,null,null,null,2),
                3,
                1
            };

            yield return new object[]
            {
                ReadBinary(100),
                1,
                0
            };

            yield return new object[]
            {
                ReadBinary(1,1,1),
                2,
                1
            };
        }

        [Theory]
        [InlineData(new[] { 3, 0, 1, 1, 9, 7 }, 7, 2, 3, 4)]
        [InlineData(new[] { 1, 1, 2, 2, 3 }, 0, 0, 1, 0)]
        public void CountGoodTriplets_Solve(int[] arr, int a, int b, int c, int expected)
        {
            var algo = new CountGoodTriplets();
            var actual = algo.Solve(arr, a, b, c);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 2, 1, 3, 5, 4, 6, 7 }, 2, 5)]
        [InlineData(new[] { 1, 11, 22, 33, 44, 55, 66, 77, 88, 99 }, 1000000000, 99)]
        [InlineData(new[] { 1, 3, 2, 9, 8, 2, 3, 7, 6, 4 }, 8, 9)]
        [InlineData(new[] { 3, 2, 1 }, 10, 3)]
        public void FindTheWinnerOfAnArrayGame_GetWinner(int[] arr, int k, int expected)
        {
            var algo = new FindTheWinnerOfAnArrayGame();
            var actual = algo.GetWinner(arr, k);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("USA", true)]
        [InlineData("FlaG", false)]
        [InlineData("leetcode", true)]
        [InlineData("Google", true)]
        [InlineData("T", true)]
        [InlineData("i", true)]
        public void DetectCapital_DetectCapitalUse(string word, bool expected)
        {
            var algo = new DetectCapital();
            var actual = algo.DetectCapitalUse(word);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 2, 3, 4, 7, 11 }, 5, 9)]
        [InlineData(new[] { 1, 2, 3, 4 }, 2, 6)]
        [InlineData(new[] { 1, 2 }, 1, 3)]
        [InlineData(new[] { 3, 10 }, 2, 2)]
        [InlineData(new[] { 3, 10 }, 3, 4)]
        public void KthMissingPositiveNumber_FindKthPositive(int[] arr, int k, int expected)
        {
            var algo = new KthMissingPositiveNumber();
            var actual = algo.FindKthPositive(arr, k);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("input", "ouput", 9, true)]
        [InlineData("abc", "bcd", 10, false)]
        [InlineData("aab", "bbb", 27, true)]
        [InlineData("abc", "abcd", 1000, false)]
        [InlineData("atmtxzjkz", "tvbtjhvjd", 35, false)]
        [InlineData("mpzzwh", "kaeblv", 24, true)]
        public void CanConvertStringInKMoves_CanConvertString(string s, string t, int k, bool expected)
        {
            var algo = new CanConvertStringInKMoves();
            var actual = algo.CanConvertString(s, t, k);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("(()))", 1)]
        [InlineData("())", 0)]
        [InlineData("))())(", 3)]
        [InlineData("((((((", 12)]
        [InlineData(")))))))", 5)]
        public void MinimumInsertionsToBalanceAParenthesesString_MinInsertions(string s, int expected)
        {
            var algo = new MinimumInsertionsToBalanceAParenthesesString();
            var actual = algo.MinInsertions(s);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("leEeetcode", "leetcode")]
        [InlineData("abBAcC", "")]
        [InlineData("s", "s")]
        [InlineData("aAAaAa", "")]
        [InlineData("", "")]
        public void MakeTheStringGreat_MakeGood(string s, string expected)
        {
            var algo = new MakeTheStringGreat();
            var actual = algo.MakeGood(s);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1, '0')]
        [InlineData(2, 3, '1')]
        [InlineData(3, 1, '0')]
        [InlineData(4, 11, '1')]
        [InlineData(3, 2, '1')]
        public void FindKthBitInNthBinaryString_FindKthBit(int n, int k, char bit)
        {
            var algo = new FindKthBitInNthBinaryString();
            var actual = algo.FindKthBit(n, k);

            Assert.Equal(bit, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 7 }, 3, 3)]
        [InlineData(new[] { 5, 4, 3, 2, 1, 1000000000 }, 2, 999999999)]
        public void MagneticForceBetweenTwoBalls_MaxDistance(int[] position, int m, int expected)
        {
            var algo = new MagneticForceBetweenTwoBalls();
            var actual = algo.MaxDistance(position, m);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 7, 4 }, new[] { 5, 2, 8, 9 }, 1)]
        [InlineData(new[] { 1, 1 }, new[] { 1, 1, 1 }, 9)]
        [InlineData(new[] { 7, 7, 8, 3 }, new[] { 1, 2, 9, 7 }, 2)]
        [InlineData(new[] { 4, 7, 9, 11, 23 }, new[] { 3, 5, 1024, 12, 18 }, 0)]
        public void NumberOfWaysWhereSquareOfNumberIsEqualtoProductOfTwoNumbers_NumTriplets(int[] nums1, int[] nums2, int expected)
        {
            var algo = new NumberOfWaysWhereSquareOfNumberIsEqualtoProductOfTwoNumbers();
            var actual = algo.NumTriplets(nums1, nums2);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("abaac", new[] { 1, 2, 3, 4, 5 }, 3)]
        [InlineData("abc", new[] { 1, 2, 3 }, 0)]
        [InlineData("aabaa", new[] { 1, 2, 3, 4, 1 }, 2)]
        public void MinimumDeletionCostToAvoidRepeatingLetters_MinCost(string s, int[] cost, int expected)
        {
            var algo = new MinimumDeletionCostToAvoidRepeatingLetters();
            var actual = algo.MinCost(s, cost);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(Permutations_Permute_Data))]
        public void Permutations_Permute(int[] nums, IList<IList<int>> expected)
        {
            var algo = new Permutations();
            var result = algo.Permute(nums);

            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> Permutations_Permute_Data()
        {
            yield return new object[]
            {
                new[] {1, 2, 3},
                new[]
                {
                    new[] {1, 2, 3},
                    new[] {1, 3, 2},
                    new[] {2, 1, 3},
                    new[] {2, 3, 1},
                    new[] {3, 2, 1},
                    new[] {3, 1, 2}
                }
            };
        }

        [Theory]
        [InlineData(new[] { 1, 4, 2, 5, 3 }, 58)]
        [InlineData(new[] { 1, 2 }, 3)]
        [InlineData(new[] { 10, 11, 12 }, 66)]
        public void SumOfAllOddLengthSubArrays_SumOddLengthSubArrays(int[] arr, int expected)
        {
            var algo = new SumOfAllOddLengthSubArrays();
            var actual = algo.SumOddLengthSubArrays(arr);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(MaximumSumObtainedOfAnyPermutation_MaxSumRangeQuery_Data))]
        public void MaximumSumObtainedOfAnyPermutation_MaxSumRangeQuery(int[] nums, int[][] requests, int expected)
        {
            var algo = new MaximumSumObtainedOfAnyPermutation();
            var actual = algo.MaxSumRangeQuery(nums, requests);

            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> MaximumSumObtainedOfAnyPermutation_MaxSumRangeQuery_Data()
        {
            yield return new object[]
            {
                new []{ 1, 2, 3, 4, 5 },
                new []
                {
                    new []{1,3},
                    new []{0,1}
                },
                19
            };

            yield return new object[]
            {
                new []{ 1, 2, 3, 4, 5 },
                new []
                {
                    new []{1,3},
                    new []{0,1}
                },
                19
            };

            yield return new object[]
            {
                new []{ 1, 2, 3, 4, 5, 6 },
                new []
                {
                    new []{0, 1}
                },
                11
            };

            yield return new object[]
            {
                new []{ 1, 2, 3, 4, 5, 10},
                new []
                {
                    new []{0, 2},
                    new []{1, 3},
                    new []{1, 1}
                },
                47
            };

        }

        [Theory]
        [InlineData(new[] { 3, 5 }, 2)]
        [InlineData(new[] { 0, 0 }, -1)]
        [InlineData(new[] { 0, 4, 3, 0, 4 }, 3)]
        [InlineData(new[] { 3, 6, 7, 7, 0 }, -1)]
        public void SpecialArrayWithXElementsGreaterThanOrEqualX_SpecialArray(int[] nums, int expected)
        {
            var algo = new SpecialArrayWithXElementsGreaterThanOrEqualX();
            var actual = algo.SpecialArray(nums);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(EvenOddTree_IsEvenOddTree_Data))]
        public void EvenOddTree_IsEvenOddTree(TreeNode root, bool expected)
        {
            var algo = new EvenOddTree();
            var actual = algo.IsEvenOddTree(root);

            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> EvenOddTree_IsEvenOddTree_Data()
        {
            yield return new object[]
            {
                ReadBinary(1,10,4,3,null,7,9,12,8,6,null,null,2),
                true
            };

            yield return new object[]
            {
                ReadBinary(5,4,2,3,3,7),
                false
            };

            yield return new object[]
            {
                ReadBinary(1),
                true
            };

            yield return new object[]
            {
                ReadBinary(11,8,6,1,3,9,11,30,20,18,16,12,10,4,2,17),
                true
            };
        }

        private static TreeNode ReadBinary(params int?[] tree)
        {
            TreeNode ReadNodes(int index)
            {
                if (index >= tree.Length || tree[index] == null)
                {
                    return null;
                }

                var leftChild = ReadNodes(2 * index + 1);
                var rightChild = ReadNodes(2 * index + 2);

                return new TreeNode(tree[index].Value, leftChild, rightChild);
            }

            return ReadNodes(0);
        }

        [Theory]
        [MemberData(nameof(RotateImage_Rotate_Data))]
        public void RotateImage(int[][] matrix, int[][] expected)
        {
            var algo = new RotateImage();
            algo.Rotate(matrix);

            AssertMatrixEqual(matrix, expected);
        }

        public static IEnumerable<object[]> RotateImage_Rotate_Data()
        {
            yield return new object[]
            {
                new[]
                {
                    new []{1,2,3},
                    new []{4,5,6},
                    new []{7,8,9}
                },
                new[]
                {
                    new []{7,4,1},
                    new []{8,5,2},
                    new []{9,6,3}
                }
            };

            yield return new object[]
            {
                new[]
                {
                    new []{5,1,9,11},
                    new []{2,4,8,10},
                    new []{13,3,6,7},
                    new []{15,14,12,16}
                },
                new[]
                {
                    new []{15,13,2,5},
                    new []{14,3,4,1},
                    new []{12,6,8,9},
                    new []{16,7,10,11}
                }
            };
        }

        private static void AssertMatrixEqual(int[][] matrix1, int[][] matrix2)
        {
            for (var i = 0; i < matrix1.Length; ++i)
            {
                for (var j = 0; j < matrix1.Length; ++j)
                {
                    Assert.Equal(matrix1[i][j], matrix2[i][j]);
                }
            }
        }

        [Theory]
        [InlineData(new[] { 5, 7, 7, 8, 8, 10 }, 8, new[] { 3, 4 })]
        [InlineData(new[] { 5, 7, 7, 8, 8, 10 }, 6, new[] { -1, -1 })]
        [InlineData(new int[0], 0, new[] { -1, -1 })]
        public void FindFirstAndLastPositionOfElementInSortedArray_SearchRange(int[] nums, int target, int[] expected)
        {
            var algo = new FindFirstAndLastPositionOfElementInSortedArray();
            var actual = algo.SearchRange(nums, target);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 2, 3, 0, 1, 4 }, 2)]
        [InlineData(new[] { 2, 3, 1, 1, 4 }, 2)]
        [InlineData(new[] { 2, 0, 1, 1, 4 }, 3)]
        [InlineData(new[] { 2, 3, 1, 1, 1, 1, 1, 2 }, 5)]
        public void JumpGame2_Jump(int[] nums, int expected)
        {
            var algo = new JumpGame2();
            var actual = algo.Jump(nums);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 3, 2, 1, 0, 4 }, false)]
        [InlineData(new[] { 2, 3, 1, 1, 4 }, true)]
        public void JumpGame_Jump(int[] nums, bool expected)
        {
            var algo = new JumpGame();
            var actual = algo.CanJump(nums);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(ConvertSortedListToBinarySearchTree_SortedListToBST_Data))]
        public void ConvertSortedListToBinarySearchTree_SortedListToBST(ListNode list, TreeNode expected)
        {
            var algo = new ConvertSortedListToBinarySearchTree();
            var actual = algo.SortedListToBST(list);

            Assert.Equal(expected, actual, new TreeNodeComparer());
        }

        public static IEnumerable<object[]> ConvertSortedListToBinarySearchTree_SortedListToBST_Data()
        {
            yield return new object[]
            {
                ReadList(-10,-3,0,5,9),
                ReadBinary(0,-3,9,-10,null,5)
            };

            yield return new object[]
            {
                ReadList(),
                ReadBinary()
            };

            yield return new object[]
            {
                ReadList(0),
                ReadBinary(0)
            };

            yield return new object[]
            {
                ReadList(1, 3),
                ReadBinary(3, 1)
            };
        }

        private static ListNode ReadList(params int[] list)
        {
            if (!list.Any())
            {
                return null;
            }

            var head = new ListNode(list[0]);
            var iterator = head;

            foreach (var el in list.Skip(1))
            {
                iterator.next = new ListNode(el);
                iterator = iterator.next;
            }

            return head;
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6, 1 }, 3, 12)]
        [InlineData(new[] { 2, 2, 2 }, 2, 4)]
        [InlineData(new[] { 9, 7, 7, 9, 7, 7, 9 }, 7, 55)]
        [InlineData(new[] { 1, 1000, 1 }, 1, 1)]
        [InlineData(new[] { 1, 79, 80, 1, 1, 1, 200, 1 }, 3, 202)]
        [InlineData(new[] { 7 }, 1, 7)]
        public void MaximumPointsYouCanObtainFromCards_MaxScore(int[] cardPoints, int k, int expected)
        {
            var algo = new MaximumPointsYouCanObtainFromCards();
            var actual = algo.MaxScore(cardPoints, k);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("III", 3)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        public void RomanToInteger_RomanToInt(string s, int expected)
        {
            var algo = new RomanToInteger();
            var actual = algo.RomanToInt(s);

            Assert.Equal(expected, actual);
        }
    }
}