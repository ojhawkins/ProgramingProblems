using NUnit.Framework;
using ProgrammingProblems.Codility;

namespace ProgrammingProblems.Test.Codility
{
    public class BinaryGapsTests
    {
        [TestCase(9, 2)]
        [TestCase(529, 4)]
        [TestCase(352352, 6)]
        public void Binary_gaps_solution_returns_the_correct_answer(int number, int answer)
        {
            var binaryGaps = new BinaryGaps();
            var solution = binaryGaps.Solution(number);

            Assert.AreEqual(answer, solution);
        }
    }
}