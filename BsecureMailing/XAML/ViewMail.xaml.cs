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

namespace BsecureMailing
{
    /// <summary>
    /// Interaction logic for ViewMail.xaml
    /// </summary>

    public partial class ViewMail : Window
    {
        App currentApp = System.Windows.Application.Current as App;
        public ViewMail()
        {
            InitializeComponent();

              txtEMailFrom .Text= currentApp.Mfromname;
              txtEMailID.Text= currentApp.MfromID;
              txtEmailTo.Text= currentApp.Mtoname;
              txtCC.Text = currentApp.Mcc;
              txtSubject.Text= currentApp.Msubject;          
              wbbrowser.Source= new Uri(currentApp.htmldata);


        }

    
        private void btnreply_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            WebEditor we = new WebEditor();
            we.Show();

        }

        private void btnreply_Click(object sender, RoutedEventArgs e)
        {
            WebEditor we = new WebEditor();
            we.Show();
        }
    }
}
