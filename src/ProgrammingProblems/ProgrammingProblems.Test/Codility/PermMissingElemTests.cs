using System.Collections;
using NUnit.Framework;
using ProgrammingProblems.Codility;

namespace ProgrammingProblems.Test.Codility
{
    public class PermMissingElemTests
    {
        [TestCaseSource(typeof(PermMissingElemTestCases), nameof(PermMissingElemTestCases.TestCases))]
        public int Perm_missing_loop_solution_returns_the_correct_value(int[] numbers)
        {
            var permMissingElem = new PermMissingElem();
            var solution = permMissingElem.SolutionCount(numbers);

            return solution;
        }

        [TestCaseSource(typeof(PermMissingElemTestCases), nameof(PermMissingElemTestCases.TestCases))]
        public int Perm_missing_xor_solution_returns_the_correct_value(int[] numbers)
        {
            var permMissingElem = new PermMissingElem();
            var solution = permMissingElem.SolutionXor(numbers);

            return solution;
        }
    }

    public class PermMissingElemTestCases
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new[] { 1, 2, 4 }).Returns(3);
                yield return new TestCaseData(new[] { 1, 2, 4, 3, 6 }).Returns(5);
            }
        }
    }
}