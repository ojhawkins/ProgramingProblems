using NUnit.Framework;
using ProgrammingProblems.Codility;

namespace ProgrammingProblems.Test.Codility
{
    public class FrogJmpTests
    {
        [TestCase(20, 21, 15, 1)]
        [TestCase(20, 36, 15, 2)]
        [TestCase(0, 45, 10, 5)]
        public void Frog_jmp_solution_returns_the_correct_value(int x, int y, int d, int answer)
        {
            var frogJmp = new FrogJmp();
            var solution = frogJmp.Solution(x, y, d);

            Assert.AreEqual(answer, solution);
        }
    }
}