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

namespace Ultimate_Pet_GUI_Thing
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        Controller controller;
        public MainPage(Controller controller)
        {
            this.controller = controller;
            InitializeComponent();
            //this.controller = controller;
        }

        private void InsertPetButton_Click(object sender, RoutedEventArgs e)
        {
            controller.OpenIPP();
        }
    }
}
