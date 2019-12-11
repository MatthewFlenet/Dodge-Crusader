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
using System.Windows.Forms;
using System.Threading;

namespace Dodge_Crusader
{
    /// <summary>
    /// Logique d'interaction pour Game.xaml
    /// </summary>
    /// 

    // The ThreadProc method is called when the thread starts.
    // It loops ten times, writing to the console and yielding 
    // the rest of its time slice each time, and then ends.


    public partial class Game : Window
    {
        public Game()
        {
            InitializeComponent();





        }

        private void Game_KeyDown(object sender, System.Windows.Forms.KeyEventArgs key)
        {
            Thickness margin = Hero.Margin; // défini le déplacement du vaisseau


            if (margin.Left < 630)
            {
                margin.Left = margin.Left + 10;
                Hero.Margin = margin;
            }
            else
            {
                margin.Left = margin.Left;
                Hero.Margin = margin;
            }

        }

    }
