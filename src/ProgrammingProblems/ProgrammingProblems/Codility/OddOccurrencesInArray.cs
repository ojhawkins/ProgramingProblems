using System.Linq;

namespace ProgrammingProblems.Codility
{
    public class OddOccurrencesInArray
    {
        public int Solution(int[] values)
        {
            return values.Aggregate(0, (current, value) => current ^ value);
        }
    }
}