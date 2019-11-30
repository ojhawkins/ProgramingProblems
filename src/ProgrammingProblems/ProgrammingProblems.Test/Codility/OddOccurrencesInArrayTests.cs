using System.Collections;
using NUnit.Framework;
using ProgrammingProblems.Codility;

namespace ProgrammingProblems.Test.Codility
{
    public class OddOccurrencesInArrayTests
    {
        [TestCaseSource(typeof(OddOccurrencesInArrayTestCases), nameof(OddOccurrencesInArrayTestCases.TestCases))]
        public int Fib_frog_solution_returns_the_correct_answer(int[] values)
        {
            var occurrencesInArray = new OddOccurrencesInArray();
            var solution = occurrencesInArray.Solution(values);

            return solution;
        }
    }

    public class OddOccurrencesInArrayTestCases
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new[] { 0, 0, 1 }).Returns(1);
                yield return new TestCaseData(new[] { 0, 1, 1, 0, 5 }).Returns(5);
                yield return new TestCaseData(new[] { 5, 3, 0, 1, 1, 0, 5 }).Returns(3);

            }
        }
    }
}