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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window8.xaml
    /// </summary>
    public partial class Window8 : Window
    {
        public Window8()
        {
            InitializeComponent();
            DGrid.ItemsSource = SALONEntities.GetContext().Client.ToList();
            DGrid1.ItemsSource = SALONEntities.GetContext().Priem.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window7 window7 = new Window7();
            window7.Show();
            this.Hide();
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                SALONEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGrid.ItemsSource = SALONEntities.GetContext().Client.ToList();
                SALONEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGrid1.ItemsSource = SALONEntities.GetContext().Priem.ToList();
            }
        }
    }
}
