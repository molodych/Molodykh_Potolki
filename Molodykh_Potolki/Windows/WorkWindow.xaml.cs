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

namespace Molodykh_Potolki.Windows
{
    /// <summary>
    /// Логика взаимодействия для WorkWindow.xaml
    /// </summary>
    public partial class WorkWindow : Window
    {
        public WorkWindow(Entities.Пользователи user)
        {
            InitializeComponent();

            switch (user.Роль_пользователя.код_роли)
            {
                case 1:
                    WorkPagesFrame.Navigate(new Pages.PageMenuAdmin());
                    this.Title = user.Роль_пользователя.название;
                    break;
            }
        }
    }
}
