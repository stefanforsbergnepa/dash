using System;
using Shouldly;
using Xunit;
using System.Collections.Generic;

namespace lesson03.tests
{
    public class Tests
    {
        [Fact]
        public void ReverseArray()
        {
            var array = new PlayWithArrays();
            array.ReverseArray(new int[] {1,2,3,4}).ShouldBe(new int[] {4,3,2,1});
        }

        [Fact]
        public void SumUpArray()
        {
            var array = new PlayWithArrays();
            array.SumUpArray(new int[] {1,2,3,4}).ShouldBe(10);
            array.SumUpArray(new int[] {1,2,3,4,7}).ShouldBe(17);
        }
        [Fact]
        public void RotateArray()
        {
            var array = new PlayWithArrays();
            array.Rotate(new int[] {1,2,3,4}).ShouldBe(new int[] {2,3,4,1});
            array.Rotate(new int[] {4,5,6,7}).ShouldBe(new int[] {5,6,7,4});
        }
       
        [Fact]
        public void SmallestPartOfArrays()
        {
            var array = new PlayWithArrays();
            var firstArr = new int[]{5,33,1,8,3,2};
            var secondArr = new int[]{23,5454,2,3,745};
            var thirdArr = new int[]{45,76,4,878,3};
            var result = new int[]{1,2,3};
            array.Smallest(firstArr, secondArr, thirdArr).ShouldBe(result);
        }
        [Fact]
        public void MergeArrays()
        {
            var array = new PlayWithArrays();
            int[][] arraysToMerge = { new int[]{1,2,3}, new int[]{4,5,6},new int[]{7,8,9} };
            array.FlattenArrays(arraysToMerge).ShouldBe(new int[]{1,2,3,4,5,6,7,8,9});
        }
       [Fact]
       public void IsPalindrome()
        {
            var palindrome = new Palindrome();
            palindrome.IsPalindrome("hejsan").ShouldBe(false);
            palindrome.IsPalindrome("anna").ShouldBe(true);
            palindrome.IsPalindrome("Madam, I'm Adam!").ShouldBe(true);
        }

        [Fact]
        public void GrowList()
        {
            var listifier = new PlayWithLists(); 
            var list = new List<string>();

            listifier.growList(list).Count.ShouldBe(1);

        }

         [Fact]
        public void ShrinkList()
        {
            var listifier = new PlayWithLists(); 
            var list = new List<string>(){"string to be removed", "string to keep"};

            var returnedList = listifier.ShrinkList(list);
            returnedList.Count.ShouldBe(1);
            returnedList.Contains("string to keep").ShouldBe(true);

        }

        [Fact]

        public void GetNumbersSmallerThanNFromList()
        {
            var listifier = new PlayWithLists();
            var list = new List<int>(){1,2,3,4,11,12,13,21,22,23};

            listifier.GetSmallNumbers(list, 10).ShouldBe(new List<int>(){1,2,3,4});
            listifier.GetSmallNumbers(list, 20).ShouldBe(new List<int>(){1,2,3,4,11,12,13});

        }

        [Fact]
        public void MergeListOfLists()
        {
            var listifier = new PlayWithLists();
            var listToFlatten = new List<List<int>>() {new List<int>{1,2,3},new List<int>{4,5,6},new List<int>{7,8,9}};
            listifier.FlattenLists(listToFlatten).ShouldBe(new List<int>(){1,2,3,4,5,6,7,8,9});
            
        }

        [Fact]
        public void ReturnSortedList()
        {
            var listifier = new PlayWithLists();
            var list = new List<string>(){"z", "d", "s","w", "p","b"};
            listifier.SortList(list).ShouldBe(new List<string>(){"b", "d", "p", "s", "w", "z"});
        }

        [Fact]
        public void ReturnSortedListDesc()
        {
            var listifier = new PlayWithLists();
            var list = new List<string>(){"z", "d", "s","w", "p","b"};
            listifier.SortListDesc(list).ShouldBe(new List<string>(){"z", "w", "s", "p", "d", "b"});
        }

        [Fact]
        public void SumUpList()
        {
            var listifier = new PlayWithLists();
            var list = new List<int>(){34,54,23,6,14,67,5,64,32,34,53,99};
            
            listifier.SumUpList(list).ShouldBe(485);
        }

    }
}
