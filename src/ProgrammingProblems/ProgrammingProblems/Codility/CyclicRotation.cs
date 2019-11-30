using System;

namespace ProgrammingProblems.Codility
{
    public class CyclicRotation
    {
        public int[] Solution(int[] array, int rotateAmount)
        {
            if (array.Length == 0)
            {
                return array;
            }

            var shiftAmount = rotateAmount % array.Length;
            var result = new int [array.Length];

            Array.Copy(array, array.Length - shiftAmount, result, 0, shiftAmount);
            Array.Copy(array, 0, result, shiftAmount, array.Length - shiftAmount);

            return result;
        }
    }
}