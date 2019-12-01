namespace ProgrammingProblems.Codility
{
    public class PermMissingElem
    {
        public int SolutionCount(int[] arr)
        {
            //As they are incremented by 1 from 1
            //Count the expected result less the actual
            var result = 1;
            for (var i = 2; i <= arr.Length; i++)
            {
                result += i - arr[i - 2];
            }

            return result;
        }

        public int SolutionXor(int[] arr)
        {
            var result = 0 ^ 1;
            for (var i = 2; i <= arr.Length; i++)
            {
                result ^= i ^ arr[i - 2];
            }

            return result;
        }
    }
}