using RibbonWin;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using BsecureMailing.XAML;
using RibbonWin;
namespace BsecureMailing
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {


        public string Mfromname="";
        public string MfromID;
        public string Mtoname;
        public string Mcc;
        public string Msubject;
        public string Mdate;
        public string htmldata;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Login2  mw = new Login2();
            mw.Show();
        }


    }
}
