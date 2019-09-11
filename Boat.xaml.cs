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

namespace FishingSimulator
{
    /// <summary>
    /// Interaction logic for Boat.xaml
    /// </summary>
    public partial class Boat : Window
    {
        public Boat()
        {
            InitializeComponent();

            Cast.Click += fish; //Clicking cast runs this method
        }

        private void Return_click(object sender, RoutedEventArgs e) //Return to choice screen
        {

            Choice options = new Choice();
            this.Close();
            options.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            options.Show();
        }

        readonly Random random = new Random();

        private void fish(object sender, RoutedEventArgs e) //Method for when Casting rod
        {
            Task.Delay(2000).Wait();//Cast realism
            int cast = random.Next(1, 22); //What will be caught randomizer
            if (cast == 1 || cast == 2 || cast == 3 || cast == 4 || cast == 5 || cast == 6 || cast == 7 || cast == 8)
            {
                Nothing nothing = new Nothing();
                nothing.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                nothing.Show();

            }
            if (cast == 9 || cast == 10 || cast == 11 || cast == 12)
            {
                Seaweed seaweed = new Seaweed();
                seaweed.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                seaweed.Show();

            }

            if (cast == 13 || cast == 14 || cast == 15)
            {
                Bass small = new Bass();
                small.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                small.Show();
            }
            if (cast == 16 || cast == 17)
            {
                LargeMouthBass large = new LargeMouthBass();
                large.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                large.Show();
            }
            if (cast == 18)
            {
                Pike pike = new Pike();
                pike.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                pike.Show();
            }
            if (cast == 19 || cast == 20)
            {
                Trout trout = new Trout();
                trout.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                trout.Show();
            }
            if (cast == 21)
            {
                Boot boot = new Boot();
                boot.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                boot.Show();
            }

        }
    }
}
