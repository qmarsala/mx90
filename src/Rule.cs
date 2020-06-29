using System.Collections;
using System.Linq;

namespace mx90
{
    public class Rule
    {
        public bool[] Pattern { get; private set; }

        public Rule(int code)
        {
            Pattern = new BitArray(new int[] { code })
                .Cast<bool>()
                .Take(8)
                .Reverse()
                .ToArray();
        }

        public bool GetNewCellState(bool a, bool b, bool c)
        {
            return (a, b, c) switch
            {
                (true, true, true) => Pattern[0],
                (true, true, false) => Pattern[1],
                (true, false, true) => Pattern[2],
                (true, false, false) => Pattern[3],
                (false, true, true) => Pattern[4],
                (false, true, false) => Pattern[5],
                (false, false, true) => Pattern[6],
                (false, false, false) => Pattern[7] 
            };
        }
    }
}