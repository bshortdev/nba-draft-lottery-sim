﻿using System;
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

        private LotteryResults results = new LotteryResults();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void lottoGenBtn_Click(object sender, RoutedEventArgs e)
        {
            // Timer to track amount of time has passed.
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            offButtons();

            // Grab number of text box
            int runs = Convert.ToInt32(test_txtBox.Text);
            
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

            if(results.results.Count >= 10)
            {
                setButtons(10);
            }
            else
            {
                setButtons(results.results.Count);
            }

            mainLabel.Content = "Your lottery has been generated. Click a button on the left to see a result.";
            
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            timerLbl.Content = "RunTime: " + elapsedTime;
        }        

        private void offButtons()
        {
            mostLikeBtn.IsEnabled = false;
            twoLikeBtn.IsEnabled = false;
            threeLikeBtn.IsEnabled = false;
            fourLikeBtn.IsEnabled = false;
            fiveLikeBtn.IsEnabled = false;
            sixLikeBtn.IsEnabled = false;
            sevenLikeBtn.IsEnabled = false;
            eightLikeBtn.IsEnabled = false;
            nineLikeBtn.IsEnabled = false;
            tenLikeBtn.IsEnabled = false;
        }

        private void setButtons(int num)
        {
            switch(num)
            {
                case 1:
                    mostLikeBtn.IsEnabled = true;
                    break;
                case 2:
                    twoLikeBtn.IsEnabled = true;
                    break;
                case 3:
                    threeLikeBtn.IsEnabled = true;
                    break;
                case 4:
                    fourLikeBtn.IsEnabled = true;
                    break;
                case 5:
                    fiveLikeBtn.IsEnabled = true;
                    break;
                case 6:
                    sixLikeBtn.IsEnabled = true;
                    break;
                case 7:
                    sevenLikeBtn.IsEnabled = true;
                    break;
                case 8:
                    eightLikeBtn.IsEnabled = true;
                    break;
                case 9:
                    nineLikeBtn.IsEnabled = true;
                    break;
                case 10:
                    tenLikeBtn.IsEnabled = true;
                    break;
            }
            if(num > 1)
            {
                setButtons(num - 1);
            }
        }

        private void mostLikeBtn_Click(object sender, RoutedEventArgs e)
        {
            mainLabel.Content = results.results[0].printLottery() + Environment.NewLine + Environment.NewLine + "This Lottery happened " + results.results[0].outcomes + " times." + Environment.NewLine + Environment.NewLine + "There are a total of " + results.results.Count + " results.";
        }

        private void twoLikeBtn_Click(object sender, RoutedEventArgs e)
        {
            mainLabel.Content = results.results[1].printLottery() + Environment.NewLine + Environment.NewLine + "This Lottery happened " + results.results[1].outcomes + " times." + Environment.NewLine + Environment.NewLine + "There are a total of " + results.results.Count + " results.";
        }

        private void threeLikeBtn_Click(object sender, RoutedEventArgs e)
        {
            mainLabel.Content = results.results[2].printLottery() + Environment.NewLine + Environment.NewLine + "This Lottery happened " + results.results[2].outcomes + " times." + Environment.NewLine + Environment.NewLine + "There are a total of " + results.results.Count + " results.";
        }

        private void fourLikeBtn_Click(object sender, RoutedEventArgs e)
        {
            mainLabel.Content = results.results[3].printLottery() + Environment.NewLine + Environment.NewLine + "This Lottery happened " + results.results[3].outcomes + " times." + Environment.NewLine + Environment.NewLine + "There are a total of " + results.results.Count + " results.";
        }

        private void fiveLikeBtn_Click(object sender, RoutedEventArgs e)
        {
            mainLabel.Content = results.results[4].printLottery() + Environment.NewLine + Environment.NewLine + "This Lottery happened " + results.results[4].outcomes + " times." + Environment.NewLine + Environment.NewLine + "There are a total of " + results.results.Count + " results.";
        }

        private void sixLikeBtn_Click(object sender, RoutedEventArgs e)
        {
            mainLabel.Content = results.results[5].printLottery() + Environment.NewLine + Environment.NewLine + "This Lottery happened " + results.results[5].outcomes + " times." + Environment.NewLine + Environment.NewLine + "There are a total of " + results.results.Count + " results.";
        }

        private void sevenLikeBtn_Click(object sender, RoutedEventArgs e)
        {
            mainLabel.Content = results.results[6].printLottery() + Environment.NewLine + Environment.NewLine + "This Lottery happened " + results.results[6].outcomes + " times." + Environment.NewLine + Environment.NewLine + "There are a total of " + results.results.Count + " results.";
        }

        private void eightLikeBtn_Click(object sender, RoutedEventArgs e)
        {
            mainLabel.Content = results.results[7].printLottery() + Environment.NewLine + Environment.NewLine + "This Lottery happened " + results.results[7].outcomes + " times." + Environment.NewLine + Environment.NewLine + "There are a total of " + results.results.Count + " results.";
        }

        private void nineLikeBtn_Click(object sender, RoutedEventArgs e)
        {
            mainLabel.Content = results.results[8].printLottery() + Environment.NewLine + Environment.NewLine + "This Lottery happened " + results.results[8].outcomes + " times." + Environment.NewLine + Environment.NewLine + "There are a total of " + results.results.Count + " results.";
        }

        private void tenLikeBtn_Click(object sender, RoutedEventArgs e)
        {
            mainLabel.Content = results.results[9].printLottery() + Environment.NewLine + Environment.NewLine + "This Lottery happened " + results.results[9].outcomes + " times." + Environment.NewLine + Environment.NewLine + "There are a total of " + results.results.Count + " results.";
        }
    }
}
