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

namespace Dodge_Crusader
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //test
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Game GameWindow = new Game(); // défini un nouveau window
            GameWindow.Show(); // ouvre ce window
            this.Close(); // ferme le window précédent
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            GameOver GameOverWindow = new GameOver(); // défini un nouveau window
            GameOverWindow.Show(); // ouvre ce window
            this.Close(); // ferme le window précédent
        }
    }
}
