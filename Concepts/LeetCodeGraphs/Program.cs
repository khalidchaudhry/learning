using LeetCodeGraphs.Easy;
using LeetCodeGraphs.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeGraphs
{
    class Program
    {
        static void Main(string[] args)
        {


            //int[][] paths = new int[][]
            //{
            //   //new int[] { 1, 2},
            //   //new int[] { 3, 4},
            //   //new int[] { 3,1},
            //   //new int[] { 4,1},
            //   //new int[] { 1,3},
            //   //new int[] { 2,4}
            //};


            //_1042 FlowerPlanting = new _1042();

            //var result = FlowerPlanting.GardenNoAdj(10000, paths);

            //int N = 2;
            //int[][] trust = new int[][]
            //{
            //    new int[]{1,2 }
            //};

            //int N = 3;
            //int[][] trust = new int[][]
            //{
            //    new int[]{1,3},
            //    new int[]{2,3}
            //};

            //int N = 3;
            //int[][] trust = new int[][]
            //{
            //    new int[]{1,3},
            //    new int[]{2,3},
            //    new int[]{3,1}
            //};

            //int N = 3;
            //int[][] trust = new int[][]
            //{
            //    new int[]{1,2},
            //    new int[]{2,3}            
            //};

            //int N = 4;
            //int[][] trust = new int[][]
            //{
            //    new int[]{1,3},
            //    new int[]{1,4},
            //    new int[] {2,3},
            //    new int[]{2, 4},
            //    new int[]{4, 3 }

            //};


            //_997 townJudge = new _997();

            //townJudge.FindJudge(N, trust);

            string[] grid = new string[] 
            { " /",
              "/ "
            };

            _959 RegionsBySlashes = new _959();

            var ans=RegionsBySlashes.RegionsBySlashes(grid);


            Console.ReadKey();

        }
    }
}
