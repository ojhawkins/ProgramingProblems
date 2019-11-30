using System.Collections.Generic;

namespace ProgrammingProblems.Codility
{
    public class FibFrog
    {
        public int Solution(int[] A)
        {
            var length = A.Length;
            var fibSet = FibSet(length);

            var positions = new HashSet<int>() {length};
            for (var j = 0; ; j++)
            {
                var nextPositions = new HashSet<int>();
                foreach (var i in positions)
                {
                    foreach (var f in fibSet)
                    {
                        //Calculate where we land
                        var p = i - f;

                        //Does this jump land at the start, if so we are done
                        if (p == -1)
                        {
                            return j;
                        }

                        //Have we gone to far? If so there are no path in this iteration
                        if (p < 0)
                        {
                            break;
                        }

                        //We found a stone, add for inspection in the next iteration (if required)
                        if (A[p] == 1)
                        {
                            nextPositions.Add(p);
                        }

                        if (nextPositions.Count == 0)
                        {
                            return -1;
                        }

                        positions = nextPositions;
                    }
                }
            }
        }

        private static int[] FibSet(int n)
        {
            var fibs = new List<int> { 1, 1 };
            while (fibs[fibs.Count -1] <= n)
            {
                fibs.Add(fibs[fibs.Count - 1] + fibs[fibs.Count - 2]);
            }

            return fibs.ToArray();
        }
    }
}