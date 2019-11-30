using System.Collections;
using NUnit.Framework;
using ProgrammingProblems.Codility;

namespace ProgrammingProblems.Test.Codility
{
    public class CyclicRotationTests
    {
        [TestCaseSource(typeof(CyclicRotationTestCases), nameof(CyclicRotationTestCases.TestCases))]
        public int[] Fib_frog_solution_returns_the_correct_answer(int[] array, int rotateAmount)
        {
            var cyclicRotation = new CyclicRotation();
            var solution = cyclicRotation.Solution(array, rotateAmount);

            return solution;
        }
    }

    public class CyclicRotationTestCases
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new[] { 0, 0 }, 1).Returns(new[] { 0, 0 });
                yield return new TestCaseData(new[] { 0 }, 5).Returns(new[] { 0 });
                yield return new TestCaseData(new[] { 0, 0, 0, 0 }, 20).Returns(new[] { 0, 0, 0, 0 });
                yield return new TestCaseData(new[] { 1, 2, 3, 4 }, 1).Returns(new[] { 4, 1, 2, 3 });
            }
        }
    }
}