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
                results.results.Add(new Lottery(2015));
            }

            // Create new Lottery.
            //Lottery newLotto = new Lottery(2015);

            // Print the Lottery
            mainLabel.Content = results.results[0].printLottery();
            
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
