﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Greedy.Medium
{
    public class _253
    {
        public static void _253Main()
        {
            int[][] intervals = new int[3][] {
                new int[]{1,5 },
                new int[]{8,9 },
                new int[]{8,9 }

            };

            _253 MinRooms = new _253();

            var result = MinRooms.MinMeetingRooms1(intervals);

            Console.ReadLine();

        }



        public int MinMeetingRooms0(int[][] intervals)
        {

            SortedDictionary<int, int> timeStampCount = new SortedDictionary<int, int>();
            foreach (int[] interval in intervals)
            {
                int start = interval[0];
                int end = interval[1];

                if (!timeStampCount.ContainsKey(start))
                {
                    timeStampCount.Add(start, 0);
                }
                ++timeStampCount[start];

                if (!timeStampCount.ContainsKey(end))
                {
                    timeStampCount.Add(end, 0);
                }
                --timeStampCount[end];
            }

            int maxRooms = 0;
            int sum = 0;
            foreach (var keyValue in timeStampCount)
            {
                sum += keyValue.Value;
                maxRooms = Math.Max(maxRooms, sum);
            }
            return maxRooms;
        }

        public int MinMeetingRooms1(int[][] intervals)
        {
            var comparer = Comparer<int[]>.Create((x, y) => {
                return x[0].CompareTo(y[0]);
            });

            Array.Sort(intervals, comparer);
            int meetingRooms = 1;
            PQ<int> pq = new PQ<int>();
            foreach (var interval in intervals)
            {
                int start = interval[0];
                int end = interval[1];
                if (pq.Size > 0 && start < pq.Peek())
                {
                    ++meetingRooms;
                }
                else
                {
                    if (pq.Size > 0)
                    {
                        pq.Poll();
                    }

                }
                pq.Add(end);

            }
            return meetingRooms;
        }




    }
}
