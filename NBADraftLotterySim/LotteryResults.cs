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
    }
}
