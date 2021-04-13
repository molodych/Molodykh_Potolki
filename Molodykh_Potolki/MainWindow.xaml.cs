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

namespace Molodykh_Potolki
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Выйти из приложения?", "", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No) == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void AuthButton_Click(object sender, RoutedEventArgs e)
        {
            string _login = LoginTextBox.Text;
            string _password = PasswordTextBox.Password;

            if (!string.IsNullOrEmpty(_login) && !string.IsNullOrEmpty(_password))
            {
                using (var db = new Entities.MolodykhPotolkiEntities())
                {
                    var _currentAccount = from ac in db.Пользователи.ToList()
                                          where ac.логин == _login && ac.пароль == _password
                                          select ac;

                    if (_currentAccount.ToArray().Length > 0)
                    {
                        MessageBox.Show("Добро пожаловать!");
                        new Windows.WorkWindow(_currentAccount.ToList()[0]).Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ползователь не найден! Проверьте правильность логина и пароля");
                    }
                }
            }
            else
            {
                MessageBox.Show("Заполните все пустые поля!");
            }
        }
    }
}
