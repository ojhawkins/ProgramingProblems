namespace ProgrammingProblems.Codility
{
    public class BinaryGaps
    {
        public int Solution(int N)
        {
            var mask = 1;

            var bitMask = ~N;
            
            //We want to start on a non gap
            while ((bitMask & mask) != 0)
            {
                mask <<= 1;
            }

            mask <<= 1;

            var currentGap = 0;
            var maxGap = 0;

            while (mask != 0)
            {
                if ((bitMask & mask) == 0)
                {
                    if (currentGap > maxGap)
                    {
                        maxGap = currentGap;
                    }

                    //Reset the current gap
                    currentGap = 0;
                }
                else
                {
                    currentGap++;
                }

                mask <<= 1;
            }

            return maxGap;
        }
    }
}