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

namespace SimpleLogin
{
    /// <summary>
    /// Interaction logic for UserLogin.xaml
    /// </summary>
    public partial class UserLogin : Window
    {
        public UserLogin()
        {
            InitializeComponent();
        }
        public void Login_Click(object sender, RoutedEventArgs e)
        {
            //getting information from the xaml page's textbox/passwordbox
            var Username = userNameBox.Text;
            var Password = passwordBox.Password;

            using(UserData context = new UserData())
            {
                //checking if the user exists in the database
                bool validUser = context.Users.Any(user=>user.name == Username && user.password==Password);
                if (validUser) 
                {
                    LoginAccess();
                    Close();
                }
                else
                {
                    MessageBox.Show("User not found!");
                }
            }

        }
        public void LoginAccess()
        {
            //granting access to the MainPage, closing the login page
            MainPage main = new MainPage();
            main.Show();
        }
    }
}
