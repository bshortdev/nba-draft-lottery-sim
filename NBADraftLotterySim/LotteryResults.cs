using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBADraftLotterySim
{
    class LotteryResults
    {
        public List<Lottery> results { get; set; }

        public LotteryResults()
        {
            results = new List<Lottery>();
        }

        // Sorts results in descending order by number of outcomes.
        public void sortResults()
        {
            results = results.OrderByDescending(r => r.outcomes).ToList();
        }
    }
}
