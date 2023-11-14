using P.NET_;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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

namespace P.NET_0._1._0
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {

       
        

        public MainWindow()
        {
            InitializeComponent();

        }

        private void BT_Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        //private void BT_login_Click(object sender, RoutedEventArgs e)
        //{
        //    var db = new P_NET_Entities();
        //    var USER_INFO = new USER_INFO();

        //    if (TB_login.Text != null && TB_password.Text != null)
        //    {
        //        foreach (var item in db.USER_INFO.ToArray())
        //        {
        //            if (TB_login.Text != item.username && TB_password.Text != item.password)
        //            {
        //                LB_login_or_registrate.Content = "Error password or login";
        //            }
        //            else 
        //            {

        //            }
        //        }
        //    }


        //}

        //private void BT_registration_Click(object sender, RoutedEventArgs e)
        //{
        //    var db = new P_NET_Entities();
        //    var USER_INFO = new USER_INFO();


        //    if (TB_login.Text != null && TB_password.Text != null)
        //    {
        //        foreach (var item in db.USER_INFO.ToArray())
        //        {
        //            USER_INFO.id = item.id + 1;
        //        }
        //        USER_INFO.username = TB_login.Text;
        //        USER_INFO.password = TB_password.Text;
        //        db.USER_INFO.Add(USER_INFO);
        //        db.SaveChanges();

        //        TB_password.Text = "";
        //        TB_login.Text = "";

        //        LB_login_or_registrate.Content = "Login";


        //    }
        //    else
        //    {
        //        MessageBox.Show("enter error");
        //    }
        //}


    }
}
