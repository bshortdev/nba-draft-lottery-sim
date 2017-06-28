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

        private static Team[] actual2015 = new Team[] { new Team("Minnesota Timberwolves"),
                new Team("Los Angeles Lakers"),
                new Team("Philadelphia 76ers"),
                new Team("New York Knicks"),
                new Team("Orlando Magic"),
                new Team("Sacramento Kings"),
                new Team("Denver Nuggets"),
                new Team("Detroit Pistons"),
                new Team("Charlotte Hornets"),
                new Team("Miami Heat"),
                new Team("Indiana Pacers"),
                new Team("Utah Jazz"),
                new Team("Phoenix Suns"),
                new Team("Oklahoma City Thunder")};

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

        public static Lottery getTrueLottery(int year)
        {
            if(year == 2015)
            {
                return new Lottery(actual2015);
            }
            else
            {
                return null;
            }
        }
    }
}