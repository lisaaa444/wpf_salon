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
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }
        Client client = new Client();
        Priem prim = new Priem();
        SALONEntities db = new SALONEntities();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtSur.Text != "")
            {
                foreach (var user in db.Client)
                {
                    if (user.Surname == txtSur.Text)
                    {
                        client = user;
                        break;
                    }
                }
                foreach (var user in db.Priem)
                {
                    if (user.ID_client == client.ID)
                    {
                        prim = user;
                        break;
                    }
                }
                if (MessageBox.Show($"Удалить пользователя: {client.Surname}?", "Удаление!",
                               MessageBoxButton.YesNo, MessageBoxImage.Warning).ToString() == "Yes"
                               && client != null)
                {
                    db.Client.Remove(client);
                    prim.ID_specialist = null;
                    db.Priem.Remove(prim);
                    db.SaveChanges();
                    MessageBox.Show("Пользователь удален!");
                }
            }
            else
            {
                MessageBox.Show("Укажите фамилию!", "Ошибка!");
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }
    }
}
