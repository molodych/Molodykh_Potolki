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

namespace Molodykh_Potolki.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageFactura.xaml
    /// </summary>
    public partial class PageFactura : Page
    {
        public PageFactura()
        {
            InitializeComponent();

            using (var db = new Entities.MolodykhPotolkiEntities())
            {
                FacturaDataGrid.ItemsSource = db.Фактура.ToList();
            }
        }
    }
}
