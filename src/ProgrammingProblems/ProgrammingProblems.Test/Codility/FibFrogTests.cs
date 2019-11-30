using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ProgrammingProblems.Codility;

namespace ProgrammingProblems.Test.Codility
{
    public class FibFrogTests
    {
        [TestCaseSource(typeof(FibFrogTestCases), "TestCases")]
        public void F(int[] steps, int minStepsAnswer)
        {
            var fibFrog = new FibFrog();
            var solution = fibFrog.Solution(steps);

            Assert.AreEqual(minStepsAnswer, solution);
        }
    }

    public class FibFrogTestCases
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new[] { 0, 0 }).Returns(4);
            }
        }
    }
}
