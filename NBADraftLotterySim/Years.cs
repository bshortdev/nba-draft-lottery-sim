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

        private Team[] lottery2010 = new Team[] {
            new Team("New Jersey Nets", 250, 1),
                new Team("Minnesota Timberwolves", 199, 2),
                new Team("Sacramento Kings", 156, 3),
                new Team("Golden State Warriors", 104, 4),
                new Team("Washington Wizards", 103, 5),
                new Team("Philadelphia 76ers", 53, 6),
                new Team("Detroit Pistons", 53, 7),
                new Team("Los Angeles Clippers", 23, 8),
                new Team("New York Knicks", 22, 9),
                new Team("Indiana Pacers", 11, 10),
                new Team("New Orleans Hornets", 8, 11),
                new Team("Memphis Grizzlies", 7, 12),
                new Team("Toronto Raptors", 6, 13),
                new Team("Houston Rockets", 5, 14) };

        private static Team[] actual2010 = new Team[] {
            new Team("Washington Wizards"),
                new Team("Philadelphia 76ers"),
                new Team("New Jersey Nets"),
                new Team("Minnesota Timberwolves"),
                new Team("Sacramento Kings"),
                new Team("Golden State Warriors"),
                new Team("Detroit Pistons"),
                new Team("Los Angeles Clippers"),
                new Team("Utah Jazz"),
                new Team("Indiana Pacers"),
                new Team("New Orleans Hornets"),
                new Team("Memphis Grizzlies"),
                new Team("Toronto Raptors"),
                new Team("Houston Rockets")};

        private Team[] lottery2011 = new Team[] {
            new Team("Minnesota Timberwolves", 250, 1),
                new Team("Cleveland Cavaliers", 199, 2),
                new Team("Toronto Raptors", 156, 3),
                new Team("Washington Wizards", 119, 4),
                new Team("Sacramento Kings", 76, 5),
                new Team("Utah Jazz", 75, 6),
                new Team("Detroit Pistons", 43, 7),
                new Team("Cleveland Cavaliers", 28, 8),
                new Team("Charlotte Bobcats", 17, 9),
                new Team("Milwaukee Bucks", 11, 10),
                new Team("Golden State Warriors", 8, 11),
                new Team("Utah Jazz", 7, 12),
                new Team("Phoneix Suns", 6, 13),
                new Team("Houston Rockets", 5, 14) };

        private static Team[] actual2011 = new Team[] {
            new Team("Cleveland Cavaliers"),
                new Team("Minnesota Timberwolves"),
                new Team("Utah Jazz"),
                new Team("Cleveland Cavaliers"),
                new Team("Toronto Raptors"),
                new Team("Washington Wizards"),
                new Team("Sacramento Kings"),
                new Team("Detroit Pistons"),
                new Team("Charlotte Bobcats"),
                new Team("Milwaukee Bucks"),
                new Team("Golden State Warriors"),
                new Team("Utah Jazz"),
                new Team("Phoenix Suns"),
                new Team("Houston Rockets")};

        private Team[] lottery2012 = new Team[] {
            new Team("Charlotte Bobcats", 250, 1),
                new Team("Washington Wizards", 199, 2),
                new Team("Cleveland Cavaliers", 138, 3),
                new Team("New Orleans Hornets", 137, 4),
                new Team("Sacramento Kings", 76, 5),
                new Team("Portland Trail Blazers", 75, 6),
                new Team("Golden State Warriors", 36, 7),
                new Team("Toronto Raptors", 35, 8),
                new Team("Detroit Pistons", 17, 9),
                new Team("Minnesota Timberwolves", 11, 10),
                new Team("Portland Trail Blazers", 8, 11),
                new Team("Milwaukee Bucks", 7, 12),
                new Team("Phoneix Suns", 6, 13),
                new Team("Houston Rockets", 5, 14) };

        private static Team[] actual2012 = new Team[] {
            new Team("New Orleans Hornets"),
                new Team("Charlotte Bobcats"),
                new Team("Washington Wizards"),
                new Team("Cleveland Cavaliers"),
                new Team("Sacramento Kings"),
                new Team("Portland Trail Blazers"),
                new Team("Golden State Warriors"),
                new Team("Toronto Raptors"),
                new Team("Detroit Pistons"),
                new Team("New Orleans Hornets"),
                new Team("Portland Trail Blazers"),
                new Team("Milwaukee Bucks"),
                new Team("Phoenix Suns"),
                new Team("Houston Rockets")};

        private Team[] lottery2013 = new Team[] {
            new Team("Orlando Magic", 250, 1),
                new Team("Charlotte Bobcats", 199, 2),
                new Team("Cleveland Cavaliers", 156, 3),
                new Team("Phoenix Suns", 119, 4),
                new Team("New Orleans Pelicans", 88, 5),
                new Team("Sacramento Kings", 63, 6),
                new Team("Detroit Pistons", 36, 7),
                new Team("Washington Wizards", 35, 8),
                new Team("Minnesota Timberwolves", 17, 9),
                new Team("Portland Trail Blazers", 11, 10),
                new Team("Philadelphia 76ers", 8, 11),
                new Team("Oklahoma City Thunder", 7, 12),
                new Team("Dallas Mavericks", 6, 13),
                new Team("Utah Jazz", 5, 14) };

        private static Team[] actual2013 = new Team[] {
            new Team("Cleveland Cavaliers"),
                new Team("Orlando Magic"),
                new Team("Washington Wizards"),
                new Team("Charlotte Bobcats"),
                new Team("Phoenix Suns"),
                new Team("New Orleans Pelicans"),
                new Team("Sacramento Kings"),
                new Team("Detroit Pistons"),
                new Team("Minnesota Timberwolves"),
                new Team("Portland Trail Blazers"),
                new Team("Philadelphia 76ers"),
                new Team("Oklahoma City Thunder"),
                new Team("Dallas Mavericks"),
                new Team("Utah Jazz")};

        private Team[] lottery2014 = new Team[] {
            new Team("Milwaukee Bucks", 250, 1),
                new Team("Philadephia 76ers", 199, 2),
                new Team("Orlando Magic", 156, 3),
                new Team("Utah Jazz", 119, 4),
                new Team("Boston Celtics", 88, 5),
                new Team("Los Angeles Lakers", 63, 6),
                new Team("Sacramento Kings", 43, 7),
                new Team("Detroit Pistons", 28, 8),
                new Team("Cleveland Cavaliers", 17, 9),
                new Team("New Orleans Pelicans", 11, 10),
                new Team("Denver Nuggets", 8, 11),
                new Team("New York Knicks", 7, 12),
                new Team("Minnesota Timberwolves", 6, 13),
                new Team("Phoenix Suns", 5, 14) };

        private static Team[] actual2014 = new Team[] {
            new Team("Cleveland Cavaliers"),
                new Team("Milwaukee Bucks"),
                new Team("Philadelphia 76ers"),
                new Team("Orlando Magic"),
                new Team("Utah Jazz"),
                new Team("Boston Celtics"),
                new Team("Los Angeles Lakers"),
                new Team("Sacramento Kings"),
                new Team("Charlotte Hornets"),
                new Team("Philadelphia 76ers"),
                new Team("Denver Nuggets"),
                new Team("Orlando Magic"),
                new Team("Minnesota Timberwolves"),
                new Team("Phoenix Suns")};

        private Team[] lottery2015 = new Team[] {
            new Team("Minnesota Timberwolves", 250, 1),
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

        private static Team[] actual2015 = new Team[] {
            new Team("Minnesota Timberwolves"),
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

        private Team[] lottery2016 = new Team[] {
            new Team("Philadelphia 76ers", 250, 1),
                new Team("Los Angeles Lakers", 199, 2),
                new Team("Boston Celtics", 156, 3),
                new Team("Phoenix Suns", 119, 4),
                new Team("Minnesota Timberwolves", 88, 5),
                new Team("New Orleans Pelicans", 63, 6),
                new Team("New York Knicks", 43, 7),
                new Team("Sacramento Kings", 19, 8),
                new Team("Denver Nuggets", 19, 9),
                new Team("Milwaukee Bucks", 18, 10),
                new Team("Orlando Magic", 8, 11),
                new Team("Utah Jazz", 7, 12),
                new Team("Washington Wizards", 6, 13),
                new Team("Chicago Bulls", 5, 14) };

        private static Team[] actual2016 = new Team[] {
            new Team("Philadelphia 76ers"),
                new Team("Los Angeles Lakers"),
                new Team("Boston Celtics"),
                new Team("Phoenix Suns"),
                new Team("Minnesota Timberwolves"),
                new Team("New Orleans Pelicans"),
                new Team("Denver Nuggets"),
                new Team("Sacramento Kings"),
                new Team("Toronto Raptors"),
                new Team("Milwaukee Bucks"),
                new Team("Orlando Magic"),
                new Team("Utah Jazz"),
                new Team("Phoenix Suns"),
                new Team("Chicago Bulls") };

        private Team[] lottery2017 = new Team[] {
            new Team("Boston Celtics", 250, 1),
                new Team("Phoenix Suns", 199, 2),
                new Team("Los Angeles Lakers", 156, 3),
                new Team("Philadelphia 76ers", 119, 4),
                new Team("Orlando Magic", 88, 5),
                new Team("Minnesota Timberwolves", 53, 6),
                new Team("New York Knicks", 53, 7),
                new Team("Sacramento Kings", 28, 8),
                new Team("Dallas Mavericks", 17, 9),
                new Team("New Orleans Pelicans", 11, 10),
                new Team("Charlotte Hornets", 8, 11),
                new Team("Detroit Pistons", 7, 12),
                new Team("Denver Nuggets", 6, 13),
                new Team("Miami Heat", 5, 14) };

        private static Team[] actual2017 = new Team[] { 
            new Team("Boston Celtics"),
                new Team("Los Angeles Lakers"),
                new Team("Sacramento Kings"),
                new Team("Phoenix Suns"),
                new Team("Philadelphia 76ers"),
                new Team("Orlando Magic"),
                new Team("Minnesota Timberwolves"),
                new Team("New York Knicks"),
                new Team("Dallas Mavericks"),
                new Team("New Orleans Hornets"),
                new Team("Charlotte Hornets"),
                new Team("Detroit Pistons"),
                new Team("Denver Nuggets"),
                new Team("Miami Heat")};

        public Years(int year)
        {
            switch(year)
            {
                case 2015:
                    setTeams(lottery2015);
                    break;
                case 2016:
                    setTeams(lottery2016);
                    break;
                case 2017:
                    setTeams(lottery2017);
                    break;
            }
        }

        public void setTeams(Team[] teams)
        {
            chosenLotto = teams;
        }

        public static Lottery getTrueLottery(int year)
        {
            Lottery ret = null;
            switch (year)
            {
                case 2015:
                    ret = new Lottery(actual2015);
                    break;
                case 2016:
                    ret = new Lottery(actual2016);
                    break;
                case 2017:
                    ret = new Lottery(actual2017);
                    break;
            }
            return ret;
        }
    }
}