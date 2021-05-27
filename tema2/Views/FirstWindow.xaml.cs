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
using System.Windows.Shapes;
using tema2.Services;
using tema2.ViewModels;

namespace tema2.Views
{
    /// <summary>
    /// Interaction logic for FirstWindow.xaml
    /// </summary>
    public partial class FirstWindow : Window
    {
        public FirstWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {         
            GameVM.resumeGame = false;
            GameBusinessLogic.multipleMovesGame = false;
            GameWindow gameWindow = new GameWindow();
            gameWindow.Show();
            Close();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            GameVM.resumeGame = false;
            GameBusinessLogic.multipleMovesGame = true;          
            GameWindow gameWindow = new GameWindow();
            gameWindow.Show();
            Close();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {          
            GameVM.resumeGame = true;
            GameWindow gameWindow = new GameWindow();
            gameWindow.Show();
            Close();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            StatisticsWindow statisticsWindow = new StatisticsWindow();
            statisticsWindow.Show();
            Close();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow aboutWindow = new AboutWindow();
            aboutWindow.Show();
            Close();
        }
    }
}
