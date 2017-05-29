using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBADraftLotterySim
{
    class Lottery
    {
        public Team firstPick { get; set; }

        public Team secondPick { get; set; }

        public Team thirdPick { get; set; }

        public Team fourthPick { get; set; }

        public Team fifthPick { get; set; }

        public Team sixthPick { get; set; }

        public Team seventhPick { get; set; }

        public Team eighthPick { get; set; }

        public Team ninthPick { get; set; }

        public Team tenthPick { get; set; }

        public Team eleventhPick { get; set; }

        public Team twelfthPick { get; set; }

        public Team thirteenthPick { get; set; }

        public Team fourteenthPick { get; set; }

        private Team[] picks;

        public int[] lottoBalls = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

        public int outcomes { get; set; }

        public Lottery (int year)
        {
            outcomes = 1;
            picks = new Team[14];
            createLotto(year);
            firstPick = picks[0];
            secondPick = picks[1];
            thirdPick = picks[2];
            fourthPick = picks[3];
            fifthPick = picks[4];
            sixthPick = picks[5];
            seventhPick = picks[6];
            eighthPick = picks[7];
            ninthPick = picks[8];
            tenthPick = picks[9];
            eleventhPick = picks[10];
            twelfthPick = picks[11];
            thirteenthPick = picks[12];
            fourteenthPick = picks[13];
        }

        // Creates the Draft Lottery
        private void createLotto(int year)
        {
            // Testing Teams
            Years twentyFifteen = new Years(year);
            Combination[] lotteryPool = Combination.makeLotteryPool();
            Team[] lotto2015 = twentyFifteen.chosenLotto;
            lotteryPool = assignTeams(lotteryPool, lotto2015);
            for (int i = 0; i < 20; i++)
            {
                lotteryPool = shuffleLottery(lotteryPool);
            }
            picks[0] = pullCombo(lotteryPool).team;
            bool secondPickCtrl = false;
            while (!secondPickCtrl)
            {
                Team temp = pullCombo(lotteryPool).team;
                if (!isPicked(temp))
                {
                    secondPickCtrl = true;
                    picks[1] = temp;
                    break;
                }
            }
            bool thirdPickCtrl = false;
            while (!thirdPickCtrl)
            {
                Team temp = pullCombo(lotteryPool).team;
                if (!isPicked(temp))
                {
                    thirdPickCtrl = true;
                    picks[2] = temp;
                    break;
                }
            }
            for (int j = 3; j < picks.Length; j++)
            {
                int k = 0;
                for(k = 0; k < lotto2015.Length; k++)
                {
                    if(!isPicked(lotto2015[k]))
                    {
                        break;
                    }
                }
                picks[j] = lotto2015[k];
            }
        }

        public void addOutcome()
        {
            outcomes++;
        }

        // Create a true comparison method
        public bool isEqual(Lottery compareTo)
        {
            bool result = false;
            if((this.firstPick.teamName.Equals(compareTo.firstPick.teamName)) && (this.secondPick.teamName.Equals(compareTo.secondPick.teamName)) && (this.thirdPick.teamName.Equals(compareTo.thirdPick.teamName)) && (this.fourthPick.teamName.Equals(compareTo.fourthPick.teamName)) && (this.fifthPick.teamName.Equals(compareTo.fifthPick.teamName)) && (this.sixthPick.teamName.Equals(compareTo.sixthPick.teamName)) && (this.seventhPick.teamName.Equals(compareTo.seventhPick.teamName)) && (this.eighthPick.teamName.Equals(compareTo.eighthPick.teamName)) && (this.ninthPick.teamName.Equals(compareTo.ninthPick.teamName)) && (this.tenthPick.teamName.Equals(compareTo.tenthPick.teamName)) && (this.eleventhPick.teamName.Equals(compareTo.eleventhPick.teamName)) && (this.twelfthPick.teamName.Equals(compareTo.twelfthPick.teamName)) && (this.thirteenthPick.teamName.Equals(compareTo.thirteenthPick.teamName)) && (this.fourteenthPick.teamName.Equals(compareTo.fourteenthPick.teamName)))
            {
                result = true;
            }
            return result;
        }

        // Saves the lottery to a string
        public string printLottery()
        {
            string result = "Lottery Results";
            for(int i = 0; i < picks.Length; i++)
            {
                result += Environment.NewLine + (i + 1) + ". " + picks[i].teamName;
            }
            return result;
        }

        // Check to see if the Tema is currently assigned to a Draft Pick
        private bool isPicked(Team pick)
        {
            bool picked = false;
            for(int i = 0; i < picks.Length; i++)
            {
                if(pick.Equals(picks[i]))
                {
                    picked = true;
                }
            }
            return picked;
        }
        
        // Pull a random combination value from the array of Combinations
        private Combination pullCombo(Combination[] combo)
        {
            Random rnd = new Random();
            int index = rnd.Next(0, combo.Length);
            Combination pull = combo[index];
            return pull;
        }

        // Shuffles the array of Combinations
        private Combination[] shuffleLottery(Combination[] combo)
        {
            Random rnd = new Random();
            return combo.OrderBy(x => rnd.Next()).ToArray();
        }

        // Assigns the teams to lottery combinations in the array based on lotery odds.
        private Combination[] assignTeams(Combination[] combo, Team[] lotto)
        {
            int index = 0;
            int counter = 0;
            foreach (Combination c in combo)
            {
                if (counter >= lotto[index].lotteryOdds)
                {
                    index++;
                    counter = 0;
                }
                c.team = lotto[index];
                counter++;
            }
            return combo;
        }

        // An array of Teams from the 2015 Draft Lottery
        private Team[] lottery2015()
        {
            return new Team[] { new Team("Minnesota Timberwolves", 250, 1),
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
        }

        // Method ensures a random value is picked from the array of lottery balls.
        private int randArrayVal(int[] arr)
        {
            int len = arr.Length;
            Random rnd = new Random();
            int index = rnd.Next(0, len);
            return arr[index];
        }
    }
}
