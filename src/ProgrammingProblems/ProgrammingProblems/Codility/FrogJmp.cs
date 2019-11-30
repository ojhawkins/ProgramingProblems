using System;

namespace ProgrammingProblems.Codility
{
    public class FrogJmp
    {
        public int Solution(int x, int y, int d)
        {
            return (int)Math.Ceiling((decimal) (y - x) / d);
        }
    }
}