using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBADraftLotterySim
{
    class Team
    {
        public string teamName { get; set; }
        public int lotteryOdds { get; set; }

        public Team(string name, int odds)
        {
            teamName = name;
            lotteryOdds = odds;
        }
    }
}
