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
        private LotteryResults results;
        private int lotteryYear = 2015;
        private int realLottoIndex, realLottoTimes;
        private int runs;
        private int progMax;

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void lottoGenBtn_Click(object sender, RoutedEventArgs e)
        {
            var progress = new Progress<int>(value => lotteryProgress.Value = value);
            await Task.Run(() =>
            {
                results = new LotteryResults();
                realLottoIndex = -1;
                // Timer to track amount of time has passed.
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                offButtons();

                this.Dispatcher.Invoke((Action)(() =>
                {
                    // Grab number of text box
                    runs = Convert.ToInt32(test_txtBox.Text);

                    lotteryProgress.Maximum = runs + 5;
                    progMax = (int)lotteryProgress.Maximum;
                }));

                for (int i = 0; i < runs; i++)
                {
                    Lottery lotto = new Lottery(lotteryYear);
                    bool incOutcomes = false;
                    int whereToInc = 0;
                    for (int j = 0; j < results.results.Count; j++)
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
                    ((IProgress<int>)progress).Report(i + 1);
                }

                results.sortResults();

                ((IProgress<int>)progress).Report(progMax - 5);

                if (results.results.Count >= 10)
                {
                    setButtons(10);
                }
                else
                {
                    setButtons(results.results.Count);
                }
                ((IProgress<int>)progress).Report(progMax - 4);

                for (int i = 0; i < results.results.Count; i++)
                {
                    if (results.results[i].isEqual(Years.getTrueLottery(lotteryYear)))
                    {
                        realLottoIndex = i;
                        break;
                    }
                }

                ((IProgress<int>)progress).Report(progMax - 3);

                if (realLottoIndex == -1)
                {
                    realLottoTimes = 0;
                }
                else
                {
                    realLottoTimes = results.results[realLottoIndex].outcomes;
                }

                ((IProgress<int>)progress).Report(progMax);

                this.Dispatcher.Invoke((Action)(() =>
                {
                    actLottoBtn.IsEnabled = true;

                    mainLabel.Content = "Your lottery has been generated. Click a button on the left to see a result.";
                }));

                stopWatch.Stop();
                // Get the elapsed time as a TimeSpan value.
                TimeSpan ts = stopWatch.Elapsed;

                // Format and display the TimeSpan value.
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);
                this.Dispatcher.Invoke((Action)(() =>
                {
                    timerLbl.Content = "RunTime: " + elapsedTime;
                }));
            });
        }

        private void offButtons()
        {
            this.Dispatcher.Invoke((Action)(() =>
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
                actLottoBtn.IsEnabled = false;
            }));
        }

        private void setButtons(int num)
        {
            this.Dispatcher.Invoke((Action)(() =>
            {
                switch (num)
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
                if (num > 1)
                {
                    setButtons(num - 1);
                }
            }));
        }

        private void mostLikeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.Invoke((Action)(() =>
            {
                mainLabel.Content = results.results[0].printLottery() + Environment.NewLine + Environment.NewLine + "This Lottery happened " + results.results[0].outcomes + " times." + Environment.NewLine + Environment.NewLine + "There are a total of " + results.results.Count + " results.";
                if (results.results[0].isEqual(Years.getTrueLottery(lotteryYear)))
                {
                    mainLabel.Content += Environment.NewLine + Environment.NewLine + "This is the actual Lottery result of the " + lotteryYear + " Draft Lottery!";
                }
            }));
        }

        private void twoLikeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.Invoke((Action)(() =>
            {
                mainLabel.Content = results.results[1].printLottery() + Environment.NewLine + Environment.NewLine + "This Lottery happened " + results.results[1].outcomes + " times." + Environment.NewLine + Environment.NewLine + "There are a total of " + results.results.Count + " results.";
                if (results.results[1].isEqual(Years.getTrueLottery(lotteryYear)))
                {
                    mainLabel.Content += Environment.NewLine + Environment.NewLine + "This is the actual Lottery result of the " + lotteryYear + " Draft Lottery!";
                }
            }));
        }

        private void threeLikeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.Invoke((Action)(() =>
            {
                mainLabel.Content = results.results[2].printLottery() + Environment.NewLine + Environment.NewLine + "This Lottery happened " + results.results[2].outcomes + " times." + Environment.NewLine + Environment.NewLine + "There are a total of " + results.results.Count + " results.";
                if (results.results[2].isEqual(Years.getTrueLottery(lotteryYear)))
                {
                    mainLabel.Content += Environment.NewLine + Environment.NewLine + "This is the actual Lottery result of the " + lotteryYear + " Draft Lottery!";
                }
            }));
        }

        private void fourLikeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.Invoke((Action)(() =>
            {
                mainLabel.Content = results.results[3].printLottery() + Environment.NewLine + Environment.NewLine + "This Lottery happened " + results.results[3].outcomes + " times." + Environment.NewLine + Environment.NewLine + "There are a total of " + results.results.Count + " results.";
                if (results.results[3].isEqual(Years.getTrueLottery(lotteryYear)))
                {
                    mainLabel.Content += Environment.NewLine + Environment.NewLine + "This is the actual Lottery result of the " + lotteryYear + " Draft Lottery!";
                }
            }));
        }

        private void fiveLikeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.Invoke((Action)(() =>
            {
                mainLabel.Content = results.results[4].printLottery() + Environment.NewLine + Environment.NewLine + "This Lottery happened " + results.results[4].outcomes + " times." + Environment.NewLine + Environment.NewLine + "There are a total of " + results.results.Count + " results.";
                if (results.results[4].isEqual(Years.getTrueLottery(lotteryYear)))
                {
                    mainLabel.Content += Environment.NewLine + Environment.NewLine + "This is the actual Lottery result of the " + lotteryYear + " Draft Lottery!";
                }
            }));
        }

        private void sixLikeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.Invoke((Action)(() =>
            {
                mainLabel.Content = results.results[5].printLottery() + Environment.NewLine + Environment.NewLine + "This Lottery happened " + results.results[5].outcomes + " times." + Environment.NewLine + Environment.NewLine + "There are a total of " + results.results.Count + " results.";
                if (results.results[5].isEqual(Years.getTrueLottery(lotteryYear)))
                {
                    mainLabel.Content += Environment.NewLine + Environment.NewLine + "This is the actual Lottery result of the " + lotteryYear + " Draft Lottery!";
                }
            }));
        }

        private void sevenLikeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.Invoke((Action)(() =>
            {
                mainLabel.Content = results.results[6].printLottery() + Environment.NewLine + Environment.NewLine + "This Lottery happened " + results.results[6].outcomes + " times." + Environment.NewLine + Environment.NewLine + "There are a total of " + results.results.Count + " results.";
                if (results.results[6].isEqual(Years.getTrueLottery(lotteryYear)))
                {
                    mainLabel.Content += Environment.NewLine + Environment.NewLine + "This is the actual Lottery result of the " + lotteryYear + " Draft Lottery!";
                }
            }));
        }

        private void eightLikeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.Invoke((Action)(() =>
            {
                mainLabel.Content = results.results[7].printLottery() + Environment.NewLine + Environment.NewLine + "This Lottery happened " + results.results[7].outcomes + " times." + Environment.NewLine + Environment.NewLine + "There are a total of " + results.results.Count + " results.";
                if (results.results[7].isEqual(Years.getTrueLottery(lotteryYear)))
                {
                    mainLabel.Content += Environment.NewLine + Environment.NewLine + "This is the actual Lottery result of the " + lotteryYear + " Draft Lottery!";
                }
            }));
        }

        private void nineLikeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.Invoke((Action)(() =>
            {
                mainLabel.Content = results.results[8].printLottery() + Environment.NewLine + Environment.NewLine + "This Lottery happened " + results.results[8].outcomes + " times." + Environment.NewLine + Environment.NewLine + "There are a total of " + results.results.Count + " results.";
                if (results.results[8].isEqual(Years.getTrueLottery(lotteryYear)))
                {
                    mainLabel.Content += Environment.NewLine + Environment.NewLine + "This is the actual Lottery result of the " + lotteryYear + " Draft Lottery!";
                }
            }));
        }

        private void tenLikeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.Invoke((Action)(() =>
            {
                mainLabel.Content = results.results[9].printLottery() + Environment.NewLine + Environment.NewLine + "This Lottery happened " + results.results[9].outcomes + " times." + Environment.NewLine + Environment.NewLine + "There are a total of " + results.results.Count + " results.";
                if (results.results[9].isEqual(Years.getTrueLottery(lotteryYear)))
                {
                    mainLabel.Content += Environment.NewLine + Environment.NewLine + "This is the actual Lottery result of the " + lotteryYear + " Draft Lottery!";
                }
            }));
        }

        private void actLottoBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.Invoke((Action)(() =>
            {
                double percent = ((double)realLottoTimes / runs) * 100;
                mainLabel.Content = Years.getTrueLottery(lotteryYear).printLottery() + Environment.NewLine + Environment.NewLine + "This Lottery happened " + realLottoTimes + " times." + Environment.NewLine + Environment.NewLine + "This lottery happened " + Math.Round(percent, 5) + "% of the time.";
            }));
        }

    }
}