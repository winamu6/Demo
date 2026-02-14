using Demo.DbConnection;
using Demo.Windows;
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

namespace Demo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<sotrydnik> employees { get; set;}

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AuthButton_Click(object sender, RoutedEventArgs e)
        {
            string Login = LoginBox.Text.Trim();
            string Password = AuthPassBox.Password.Trim();

            employees = new List<sotrydnik>(ConnectionString.DemoEntities.sotrydnik.ToList());

            sotrydnik CurrentUser = employees.FirstOrDefault(i => i.password.Trim() == Password && i.login.Trim() == Login);

            if (CurrentUser != null)
            {
                MessageBox.Show("Успешный вход👍");
                MenuLibrary menuLibrary = new MenuLibrary();
                menuLibrary.Show();
            }
            else
            {
                MessageBox.Show("Не успешно😨");
            }
        }
    }
}
