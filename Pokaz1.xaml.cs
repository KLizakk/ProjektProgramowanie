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

namespace Projekt1
{
    /// <summary>
    /// Logika interakcji dla klasy Pokaz1.xaml
    /// </summary>
    public partial class Pokaz1 : Window
    {
        public Pokaz1()
        {
            InitializeComponent();
        }

        private void Cofnij_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
