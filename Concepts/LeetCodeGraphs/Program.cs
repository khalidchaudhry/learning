using LeetCodeGraphs.Easy;
using LeetCodeGraphs.Medium;
using System;
using System.Collections;
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

            //string[] grid = new string[] 
            //{ " /",
            //  "/ "
            //};

            //_959 RegionsBySlashes = new _959();

            //var ans=RegionsBySlashes.RegionsBySlashes(grid);

            //_399 Division = new _399();

            //List<IList<string>> equations = new List<IList<string>>
            //{
            //    new List<string>{ "a", "b" },
            //    new List<string>{ "b", "c"}
            //};

            //double[] values = new double[] { 2.0, 3.0 };

            //List<IList<string>> queries = new List<IList<string>>
            //{
            //    new List<string>{ "a", "c" },
            //    new List<string>{ "b", "a"},
            //    new List<string>{ "a", "e"},
            //    new List<string>{ "a", "a"},
            //    new List<string>{ "x", "x"},
            //};


            //var result=Division.CalcEquation(equations,values,queries);

            //_332 It = new _332();
            //IList<IList<string>> tickets = new List<IList<string>>
            //{
            //    new List<string>{ "MUC", "LHR" },
            //    new List<string>{ "JFK", "MUC" },
            //    new List<string>{ "SFO", "SJC" },
            //    new List<string>{ "LHR", "SFO" }                
            //};

            //var result=It.FindItinerary2(tickets);

            //int numCourses = 2;
            //int[][] prerequisites = new int[][]
            //{
            //    new int[]{1,0},
            //    new int[]{2}
            //};


            //_207 CourseSchedule = new _207();
            //CourseSchedule.CanFinish2(numCourses, prerequisites);

            //_743 SortedNodeTest = new _743();

            //SortedNodeTest.SortedSetTest();

            //_210 CourseSchedule = new _210();

            //int numCourses = 4;
            //int[][] prerequisites = new int[][]
            //{
            //   new int[]{1, 0 },
            //   new int[]{2, 0 },
            //   new int[]{3, 1 },
            //   new int[]{3, 2 }
            //};
            //CourseSchedule.FindOrder(numCourses, prerequisites);

            //_310 MinHeight = new _310();
            //int n = 6;
            //int[][] edges = new int[5][]
            //{
            //    new int[]{0,3 },
            //    new int[]{1,3 },
            //    new int[]{2,3 },
            //    new int[]{4,3 },
            //    new int[]{5,4 },
            //};

            //MinHeight.FindMinHeightTrees(n,edges);

            int[][] graph = new int[4][]
            {
                new int[]{1,3 },
                new int[]{0,2 },
                new int[]{1,3},
                new int[]{0,2 },

            };

            _785 Bipartite = new _785();

            Bipartite.IsBipartite(graph);


            Console.ReadKey();

        }
    }
}
