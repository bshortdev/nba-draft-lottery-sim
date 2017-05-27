using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBADraftLotterySim
{
    class Years
    {
        public Team[] chosenLotto { get; set; }
        private Team[] lottery2015 = new Team[] { new Team("Minnesota Timberwolves", 250, 1),
                new Team("New York Knicks", 199, 2),
                new Team("Philadelphia 76ers", 156, 3),
                new Team("Los Angeles Lakers", 119, 4),
                new Team("Orlando Magic", 88, 5),
                new Team("Sacramento Kings", 63, 6),
                new Team("Denver Nuggets", 43, 7),
                new Team("Detroit Pistons", 28, 8),
                new Team("Charlotte Hornets", 17, 9),
                new Team("Miami Heat", 11, 10),
                new Team("Indiana Pacers", 8, 11),
                new Team("Utah Jazz", 7, 12),
                new Team("Phoenix Suns", 6, 13),
                new Team("Oklahoma City Thunder", 5, 14) };

        public Years(int year)
        {
            if(year == 2015)
            {
                setTeams(lottery2015);
            }
        }

        public void setTeams(Team[] teams)
        {
            chosenLotto = teams;
        }
    }
}