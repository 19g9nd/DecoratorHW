using DecoratorHW.Decorators;
using DecoratorHW.Weapons;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace DecoratorHW
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        Equipment gun = new Gun();
        Equipment riffle = new Riffle();
        public ObservableCollection<Equipment> Weapons { get; set; } = new ObservableCollection<Equipment>();
       
        public MainWindow()
        {
            InitializeComponent();
            Weapons.Add(gun);
            Weapons.Add(riffle);
            this.DataContext = this;
          

        }



        private void AimGunClicked(object sender, RoutedEventArgs e)
        {
            Weapons[Weapons.IndexOf(gun)] = new AimDecorator(wrapper: gun);
            this.GunButton.IsEnabled = false;

        }

        private void AimRiffleClicked(object sender, RoutedEventArgs e)
        {
            riffle = new AimDecorator(wrapper: riffle);
            this.RiffleButton.IsEnabled = false;
        }

        private void ButtGunClicked(object sender, RoutedEventArgs e)
        {

            if (gun.Mobility < 0) {
                this.GunButtonButt.IsEnabled = false;
            }
            else
            {
                 gun = new ButtDecorator(gun);
            }
        }

        private void ButtRiffleClicked(object sender, RoutedEventArgs e)
        {
            if (riffle.Mobility < 0)
            {
                this.RiffleButtonButt.IsEnabled = false;
            }
            else
            {
                 riffle = new ButtDecorator(riffle);
            }
        }
    }
}
