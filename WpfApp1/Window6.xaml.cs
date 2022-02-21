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
    /// Логика взаимодействия для Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        SALONEntities db = new SALONEntities();
        public Window6()
        {
            InitializeComponent();
        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (db.Admin.Where(r => r.Login == Login.Text && r.Password == Password.Text).Count() > 0)
                {
                    Window7 window7 = new Window7();
                    window7.Show();
                    this.Hide();
                }
                else
                {
                    Login.Text = "";
                    Password.Text = "";
                    MessageBox.Show("Ошибка!");
                }
            }
            catch
            {

            }           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }
    }
}
