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
using System.Diagnostics;

namespace NBADraftLotterySim
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void lottoGenBtn_Click(object sender, RoutedEventArgs e)
        {
            // Timer to track amount of time has passed.
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            // Grab number of text box
            int runs = Convert.ToInt32(test_txtBox.Text);

            LotteryResults results = new LotteryResults();

            for(int i = 0; i < runs; i++)
            {
                Lottery lotto = new Lottery(2015);
                bool incOutcomes = false;
                int whereToInc = 0;
                for(int j = 0; j < results.results.Count; j++)
                {
                    if (lotto.isEqual(results.results[j]))
                    {
                        incOutcomes = true;
                        whereToInc = j;
                    }
                }
                if (incOutcomes)
                {
                    results.results[whereToInc].addOutcome();
                }
                else
                {
                    results.results.Add(lotto);
                }
            }

            results.sortResults();

            // Print the Lottery
            mainLabel.Content = results.results[0].printLottery() + Environment.NewLine + Environment.NewLine + "This Lottery happened " + results.results[0].outcomes + " times." + Environment.NewLine + Environment.NewLine + "There are a total of " + results.results.Count + " results.";
            
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            timerLbl.Content = "RunTime: " + elapsedTime;
        }        
    }
}
