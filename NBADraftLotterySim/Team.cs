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
        public int standing { get; set; }

        public Team(string name, int odds, int rank)
        {
            teamName = name;
            lotteryOdds = odds;
            standing = rank;
        }
    }
}
