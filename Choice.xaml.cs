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
    /// Interaction logic for Choice.xaml
    /// </summary>
    public partial class Choice : Window
    {
        public Choice()
        {
            InitializeComponent();
        }
        private void Dock_Click(object sender, RoutedEventArgs e)
        {
            Dock dock = new Dock();
            this.Close();
            dock.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            dock.Show();
            
        }
        private void Boat_Click(object sender, RoutedEventArgs e)
        {
            Boat boat = new Boat();
            this.Close();
            boat.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            boat.Show();
        }
    }
}
