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
using RibbonWin;
namespace BsecureMailing.XAML
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login2 : Window
    {
        public Login2()
        {
            InitializeComponent();
            stcRegister.Visibility = Visibility.Collapsed;
            stcLogin.Visibility = Visibility.Visible;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            MainWindow vm = new MainWindow();
            vm.Show();
            
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            stcRegister.Visibility = Visibility.Visible;
            stcLogin.Visibility = Visibility.Collapsed;
        }

        private void btnSubmitReg_Click(object sender, RoutedEventArgs e)
        {
            stcRegister.Visibility = Visibility.Collapsed;
            stcLogin.Visibility = Visibility.Visible;

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            stcRegister.Visibility = Visibility.Collapsed;
            stcLogin.Visibility = Visibility.Visible;

        }
    }
}
