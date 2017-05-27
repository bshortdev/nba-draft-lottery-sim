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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void lottoGenBtn_Click(object sender, RoutedEventArgs e)
        {
            // Create new Lottery.
            Lottery newLotto = new Lottery(2015);

            // Print the Lottery
            mainLabel.Content = newLotto.printLottery();
        }        
    }
}
