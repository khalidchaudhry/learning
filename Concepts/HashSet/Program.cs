﻿using System;

namespace HashSet
{
    class Program
    {
        static void Main(string[] args)
        {

            //_771 JewlsAndStone = new _771();
            //string J = "z";
            //string S = "ZZ";

            //Console.WriteLine(JewlsAndStone.NumJewelsInStones(J,S));

            //_463 IslandPerimeter = new _463();

            //int[][] grid = new int[][]
            //    {
            //        new int[]{0,1,0,0 },
            //        new int[]{1,1,1,0 },
            //        new int[]{0,1,0,0 },
            //        new int[]{1,1,0,0 },
            //    };
            //Console.WriteLine(IslandPerimeter.IslandPerimeter(grid));

            //_349 ArrayIntersection = new _349();
            //int[] nums1 = new int[] { 1, 2, 2, 1 };
            //int[] nums2 = new int[] { 3 };
            //ArrayIntersection.Intersection(nums1,nums2);

            //_500 KeyboardRow = new _500();
            //string[] words = new string[] { "Hello", "Alaska", "Dad", "Peace" };
            //KeyboardRow.FindWords(words);

            //_811 Visits = new _811();
            //{ "9001 discuss.leetcode.com" };

            //string[] cpdomains = new string[]
            //{ "900 google.mail.com",
            //  "50 yahoo.com",
            //  "1 intel.mail.com", "5 wiki.org"
            //};

            //Visits.SubdomainVisits(cpdomains);

            _760 AnagramMappings = new _760();
            int[] A = new int[] { 12, 28, 46, 32, 50 };
            int[] B = new int[] { 50, 12, 32, 46, 28 };

            AnagramMappings.AnagramMappings(A, B);



            Console.ReadLine();
        }
    }
}
