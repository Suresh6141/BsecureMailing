using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BsecureMailing;
using System.Reflection;

namespace RibbonWin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        App currentApp = System.Windows.Application.Current as App;

        public MainWindow()
        {
            InitializeComponent();
            treeviewID.DataContext = DataSource.GetFolders();
            // Expand parent node and select the child node
            //(this.ItemContainerGenerator.ContainerFromIndex(0) as TreeViewItem).IsSelected = true;

            lstHome.ItemsSource = Items;
            lstHome.SelectedIndex = 0;
    


        }
    
        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnNewemail_Click(object sender, RoutedEventArgs e)
        {

            currentApp.Mfromname = "";
            currentApp.MfromID ="";
            currentApp.Mtoname ="";
            currentApp.Mcc ="";
            currentApp.Msubject ="";
            currentApp.Mdate ="";
            currentApp.htmldata ="";
            WebEditor  mw = new WebEditor();
            mw.Show();
        }

    

    
        //private void lstHome_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        //{
        //    ViewMail mw = new ViewMail();
        //    mw.Show();
        //}

        //private void lstHome_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    foreach (ListBoxItem  selectedItem in lstHome.SelectedItems )
        //    {
        //        //Treatment
        //    }

        //}
        public string selectedTreeFolder = "INBOX";
        private void treeviewID_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            string TreeViewItem = ((RibbonWin.Folder)treeviewID.SelectedItem).DisplayName.ToString();
            string ParentFolder = "";
            if ((((RibbonWin.Folder)treeviewID.SelectedItem)).ParentFolder != null)
            {
                 ParentFolder = ((RibbonWin.Folder)treeviewID.SelectedItem).ParentFolder.ToString();
            }
           
            selectedTreeFolder = ParentFolder.ToUpper();
        
       

            if (ParentFolder == "")
            {

                //if (TreeViewItem.ToUpper() == "INBOX")
                //{
                //    lstHome.ItemsSource = Items;
                //    lstHome.SelectedIndex = 0;
                //}
                //if (TreeViewItem.ToUpper() == "SENT ITEMS")
                //{

                //    lstHome.ItemsSource = null;
                //    lstHome.ItemsSource = SentItems;
                //    lstHome.SelectedIndex = 0;
                //    // lstHome.SelectedIndex = 0;
                //}
                //if (TreeViewItem.ToUpper() == "DRAFTS")
                //{

                //    lstHome.ItemsSource = null;
                //    lstHome.ItemsSource = DraftItems;
                //    lstHome.SelectedIndex = 0;
                //    // lstHome.SelectedIndex = 0;
                //}
                //if (TreeViewItem.ToUpper() == "DELETED ITEMS")
                //{

                //    lstHome.ItemsSource = null;
                //    lstHome.ItemsSource = DeleteItems;
                //    lstHome.SelectedIndex = 0;
                //    // lstHome.SelectedIndex = 0;
                //}
                //if (TreeViewItem.ToUpper() == "JUNK EMAIL")
                //{

                //    lstHome.ItemsSource = null;
                //    // lstHome.SelectedIndex = 0;
                //}
            }
            else
            {
                grdmailcontent.Visibility = Visibility.Collapsed;
                lstHome.ItemsSource = null;
                if (ParentFolder.ToUpper() == "INBOX" && TreeViewItem.ToUpper() == "BSECURE")
                {
                    lstHome.ItemsSource = Items;
                    lstHome.SelectedIndex = 0;
                }
                if (ParentFolder.ToUpper() == "SENT ITEMS" && TreeViewItem.ToUpper() == "BSECURE")
                {
                    lstHome.ItemsSource = null;
                    lstHome.ItemsSource = SentItems;
                    lstHome.SelectedIndex = 0;
                    // lstHome.SelectedIndex = 0;
                }

                if (ParentFolder.ToUpper() == "DRAFTS" && TreeViewItem.ToUpper() == "BSECURE")
                {
                    lstHome.ItemsSource = null;
                    lstHome.ItemsSource = DraftItems;
                    lstHome.SelectedIndex = 0;
                    // lstHome.SelectedIndex = 0;
                }


                if (ParentFolder.ToUpper() == "DELETED ITEMS" && TreeViewItem.ToUpper() == "BSECURE")
                {
                    lstHome.ItemsSource = null;
                    lstHome.ItemsSource = DeleteItems;
                    lstHome.SelectedIndex = 0;
                }

                if (ParentFolder.ToUpper() == "JUNK EMAIL" && TreeViewItem.ToUpper() == "BSECURE")
                {
                    lstHome.ItemsSource = null;
                }
            }
            }

     

        private void lstHome_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            ViewMail mw = new ViewMail();
              mw.ShowDialog();

           
        }

        private void lstHome_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grdmailcontent.Visibility = Visibility.Collapsed;
            if (lstHome.SelectedIndex != -1) {

                string index = (lstHome.SelectedIndex + 1).ToString();
                grdmailcontent.Visibility = Visibility.Visible;

                txtCC.Text = ((RibbonWin.InBoxMail)lstHome.SelectedItem).mailcc;
                txtSubject.Text = ((RibbonWin.InBoxMail)lstHome.SelectedItem).mailsubject.ToString();
                txtfromusername.Text = ((RibbonWin.InBoxMail)lstHome.SelectedItem).mailfromname.ToString();
                txtfromEmail.Text = ((RibbonWin.InBoxMail)lstHome.SelectedItem).mailfromID.ToString();
                txtdate.Text = ((RibbonWin.InBoxMail)lstHome.SelectedItem).maildate.ToString();
                txtmailto.Text = ((RibbonWin.InBoxMail)lstHome.SelectedItem).mailtoname.ToString();
                wbView.Source = new Uri("http://183.82.48.194:8484/ChachaWebAdmin/htmlfiles/" + selectedTreeFolder + "/" + index + ".html");

            
                currentApp.Mfromname = txtfromusername.Text.ToString();
                currentApp.MfromID = ((RibbonWin.InBoxMail)lstHome.SelectedItem).mailfromID.ToString();
                currentApp.Mtoname= ((RibbonWin.InBoxMail)lstHome.SelectedItem).mailtoname.ToString();
                currentApp.Mcc= ((RibbonWin.InBoxMail)lstHome.SelectedItem).mailcc;
                currentApp.Msubject = ((RibbonWin.InBoxMail)lstHome.SelectedItem).mailsubject.ToString();
                currentApp.Mdate = ((RibbonWin.InBoxMail)lstHome.SelectedItem).maildate.ToString();
                currentApp.htmldata = "http://183.82.48.194:8484/ChachaWebAdmin/htmlfiles/" + selectedTreeFolder + "/" + index + ".html";
    }


        }

        public List<InBoxMail> Items
        {
            get
            {
                return new List<InBoxMail>
            {
            new InBoxMail { mailfromname = "Keerthi Thakur", mailfromID ="Keerthiitakur@gmail.com",mailtoname="Suresh B",mailcc="harikrihna B",mailsubject="[hyderabadhi@ptgindia.com] Guide line for recording Attendence and Leaves", maildate="Wed 10/26/2016 10:52 AM" },
            new InBoxMail { mailfromname = "Nikunj  takkar", mailfromID ="Nikunj.takkar@peopletech.com",mailtoname="MobileApps",mailcc="GM UI Team",mailsubject="Features of Nougat 7.0", maildate="Sat 11/12/2016 11:37 PM" },
            new InBoxMail { mailfromname = "Facilities", mailfromID ="facilities.helpdesk@ptgindia.com",mailtoname="hyderabadies@ptgindia.com",mailcc="Siddarth Sunkari",mailsubject="[hyderabad@ptgindia.com] Please dont exchange chairs from new cubicles", maildate="Sun 11/13/2016 12:09 AM" },
            new InBoxMail { mailfromname = "Amits Gupta", mailfromID =" amitagupta@paytm.com",mailtoname="Nilesh",mailcc="Bhoomikabenerji @Paytm.com",mailsubject="Re: Issue while performing a transaction", maildate="Mon 11/14/2016 2:10 PM" },



            };
            }
        }
        public List<InBoxMail> SentItems
        {
            get
            {
                return new List<InBoxMail>
            {
            new InBoxMail { mailfromname = "Keerthi Thakur", mailfromID ="Keerthiitakur@gmail.com",mailtoname="Suresh B",mailcc="harikrihna B",mailsubject="[hyderabadhi@ptgindia.com] Guide line for recording Attendence and Leaves", maildate="Wed 10/26/2016 10:52 AM" },
            new InBoxMail { mailfromname = "Nikunj  takkar", mailfromID ="Nikunj.takkar@peopletech.com",mailtoname="MobileApps",mailcc="GM UI Team",mailsubject="Features of Nougat 7.0", maildate="Sat 11/12/2016 11:37 PM" },
            new InBoxMail { mailfromname = "Facilities", mailfromID ="facilities.helpdesk@ptgindia.com",mailtoname="hyderabadies@ptgindia.com",mailcc="Siddarth Sunkari",mailsubject="[hyderabad@ptgindia.com] Please dont exchange chairs from new cubicles", maildate="Sun 11/13/2016 12:09 AM" },
            new InBoxMail { mailfromname = "Amits Gupta", mailfromID =" amitagupta@paytm.com",mailtoname="Nilesh",mailcc="Bhoomikabenerji @Paytm.com",mailsubject="Re: Issue while performing a transaction", maildate="Mon 11/14/2016 2:10 PM" },



            };
            }
        }

        public List<InBoxMail> DeleteItems
        {
            get
            {
                return new List<InBoxMail>
            {
            new InBoxMail { mailfromname = "Ramanaiah Athota", mailfromID ="ramanaiahathota@gmail.com",mailtoname="Sanjay.tripathi@gmail.com",mailcc="nikunjhakkar@gmail.com",mailsubject="Screenshots of BottomWidget in EenaduIndia Android App", maildate="Tue 8/23/2016 3:01 PM" },



            };
            }
        }
        public List<InBoxMail> DraftItems
        {
            get
            {
                return new List<InBoxMail>
            {
            new InBoxMail { mailfromname = "suresh.trackitme@gmail.com", mailfromID ="suresh.trackitme@gmail.com",mailtoname="None",mailcc="",mailsubject="Leave Request", maildate="" },
         


            };
            }
        }

        private void btnReply_Click(object sender, RoutedEventArgs e)
        {
            WebEditor wb = new WebEditor();
            wb.Show();
        }

        private void btnreplyall_Click(object sender, RoutedEventArgs e)
        {
            WebEditor wb = new WebEditor();
            wb.Show();
        }

     
    }

    public class InBoxMail
    {
        public string mailfromname { get; set; }
        public string mailfromID { get; set; }
        public string mailtoname { get; set; }
        public string mailcc { get; set; }
        public string mailsubject { get; set; }
        public string maildate { get; set; }
    }

    public class Folder
    {
        public Folder(string displayName)
        {
            ImageSource = DataSource.Folder1;
            Children = new List<Folder>();
            ItemCountColor = "Blue";
            DisplayName = displayName;
        

        }

        public Folder(string displayName, int itemCount) : this(displayName)
        {
            ItemCount = itemCount;
         
        }

        public string DisplayName { get; set; }

        public int ItemCount { get; set; }

        public List<Folder> Children { get; set; }

        public string ItemCountColor { get; set; }

        public string ImageSource { get; set; }
        public string ParentFolder { get; set; }
    }
    public class MailItems
    {
        // create stock object properties
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }

    }

        public static class DataSource
    {
        public const string Folder1 = "/folder1.png";
        public const string Folder2 = "/Images/DeletedFolder16.png";
        public const string Folder3 = "/Images/DraftsFolder16.png";
        public const string Folder4 = "/Images/InboxFolder16.png";
        public const string Folder5 = "/Images/SentFolder16.png";
        public static List<Folder> GetFolders()
        {
            return new List<Folder>
            {
                //new Folder("sureshgoud.burra@gmail.com")
                //{
                //      Children =
                //            {
                     new Folder("Inbox",102)
                    {
                        ImageSource = Folder4,
                        Children =
                            {
                                new Folder("Bsecure") {
                        ImageSource = Folder4,
                                ParentFolder ="Inbox",
                                },
                                new Folder("On My Computer")  {
                        ImageSource = Folder4, ParentFolder ="Inbox",},
                            }
                    },


                new Folder("Drafts",7)
                    {
                        ImageSource = Folder3,
                        ItemCountColor = "Green",
                        Children =
                    {

                          new Folder("Bsecure") {
                        ImageSource = Folder3,ParentFolder ="Drafts", },
                          new Folder("On My Computer") {
                        ImageSource = Folder3, ParentFolder ="Drafts",},
                    }
                    },
                 new Folder("Sent Items",7)
                    {
                        ImageSource = Folder5,
                        ItemCountColor = "Green",

                         Children =
                    {

                          new Folder("Bsecure") {
                        ImageSource = Folder5,ParentFolder ="Sent Items", },
                          new Folder("On My Computer") {
                        ImageSource = Folder5,ParentFolder ="Sent Items", },
                    }
                    },
                  new Folder("Deleted Items",102)
                    {
                        ImageSource = Folder2,
                        Children =
                            {
                               new Folder("Bsecure") { ImageSource = Folder2, ParentFolder ="Deleted Items",},
                                new Folder("On My Computer") { ImageSource = Folder2,ParentFolder ="Deleted Items", },
                            }
                    },
                   new Folder("Bsecure")
                    {
                        ImageSource = Folder3,
                        ItemCountColor = "Green",

                        Children =
                            {
                               new Folder("Bsecure"),
                                new Folder("On My Computer"),
                            }
                    },
                    new Folder("Junk Email",7)
                    {
                        ImageSource = Folder3,
                        ItemCountColor = "Green",

                        Children =
                            {
                               new Folder("Bsecure") { ImageSource = Folder3, ParentFolder ="Junk Email",},
                                new Folder("On My Computer"){ ImageSource = Folder3,ParentFolder ="Junk Email", },
                            }
                    },
                      new Folder("Smart Folder")
                    {
                        ImageSource = Folder3,
                        ItemCountColor = "Green",

                        Children =
                            {
                               new Folder("Bsecure"),
                                new Folder("On My Computer"),
                            }
                    },
                //new Folder("Inbox",7)
                //    {
                //        ImageSource = Folder4,
                //        Children =
                //            {
                //                new Folder("_file")
                //                    {
                //                        Children =
                //                            {
                //                                new Folder("__plans"),
                //                                new Folder("_CEN&ISO", 5),
                                            
                //                                new Folder("_Interop")
                //                                {
                //                                    Children =
                //                                        {
                //                                            new Folder("CDSA", 1),
                //                                            new Folder("CPIS", 2),
                //                                            new Folder("DMIC"),
                //                                            new Folder("EOL"),
                //                                            new Folder("... And so on..."),
                //                                        }
                //                                }

                //                            }
                //                    }
                //            }
                //    }
                        //    }
             //   },
             
           

            };
        }
    }
}
