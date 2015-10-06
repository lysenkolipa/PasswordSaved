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

namespace PasswordS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PasswordDBEntities db = new PasswordDBEntities();
            // Change db
            //var user = new UserAuthorize()
            //{
            //    Login = "qwerty",
            //    Password = "qwerty1"
            //};
            //db.UserAuthorize.Add(user);
            //db.SaveChanges();
            // edit
            var toChangeUser = (from item in db.UserAuthorize where item.Login == "admin" select item).FirstOrDefault();
            toChangeUser.Password = "pass";
            db.SaveChanges();
        }
    }
}
