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
            Combination[] lotteryPool = Combination.makeLotteryPool();
            mainLabel.Content = Combination.printCombination(lotteryPool[2]);
            //mainLabel.Content = lotteryPool.Length;
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
