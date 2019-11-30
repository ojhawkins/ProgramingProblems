using System.Collections;
using NUnit.Framework;
using ProgrammingProblems.Codility;

namespace ProgrammingProblems.Test.Codility
{
    public class FibFrogTests
    {
        [TestCaseSource(typeof(FibFrogTestCases), nameof(FibFrogTestCases.TestCases))]
        public int Fib_frog_solution_returns_the_correct_answer(int[] steps)
        {
            var fibFrog = new FibFrog();
            var solution = fibFrog.Solution(steps);

            return solution;
        }
    }

    public class FibFrogTestCases
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new[] { 0, 0 }).Returns(1);
                yield return new TestCaseData(new[] { 0 }).Returns(1);
                yield return new TestCaseData(new[] { 0, 0, 0, 0 }).Returns(1);
                yield return new TestCaseData(new[] { 1, 0, 0 }).Returns(2);
                yield return new TestCaseData(new[] { 0, 0, 0, 0, 1, 0, 0, 0, 0 }).Returns(2);
            }
        }
    }
}