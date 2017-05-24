using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NBADraftLotterySim
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int[] lottoBalls = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void lottoGenBtn_Click(object sender, RoutedEventArgs e)
        {
            // Create a new Combination.
            Combination combo = new Combination();

            // Change label to a randomly generated Combination.
            //mainLabel.Content = Combination.printCombination(combo);

            // Testing Combination Methods
            //Combination test1 = new Combination(1, 2, 3, 4);
            //Combination test2 = new Combination(2, 6, 3, 4);
            //mainLabel.Content = Combination.equalCombination(test1, test2);
            //Combination[] lotteryPool = Combination.makeLotteryPool();
            //mainLabel.Content = Combination.printCombination(lotteryPool[2]);
            //mainLabel.Content = lotteryPool.Length;

            // Testing Teams
            Combination[] lotteryPool = Combination.makeLotteryPool();
            Team[] lotto2015 = lottery2015();
            lotteryPool = assignTeams(lotteryPool, lotto2015);
            for(int i = 0; i< 20; i++)
            {
                lotteryPool = shuffleLottery(lotteryPool);
            }
            string pick = pullCombo(lotteryPool).team.teamName;
            mainLabel.Content = "The number one pick belongs to the " + pick;
            //int ind = Convert.ToInt32(test_txtBox.Text);
            //mainLabel.Content = lotteryPool[ind].team.teamName;
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
            foreach(Combination c in combo)
            {
                if(counter >= lotto[index].lotteryOdds)
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
            return new Team[] { new Team("Minnesota Timberwolves", 250),
                new Team("New York Knicks", 199),
                new Team("Philadelphia 76ers", 156),
                new Team("Los Angeles Lakers", 119),
                new Team("Orlando Magic", 88),
                new Team("Sacramento Kings", 63),
                new Team("Denver Nuggets", 43),
                new Team("Detroit Pistons", 28),
                new Team("Charlotte Hornets", 17),
                new Team("Miami Heat", 11),
                new Team("Indiana Pacers", 8),
                new Team("Utah Jazz", 7),
                new Team("Phoenix Suns", 6),
                new Team("Oklahoma City Thunder", 5) };
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
