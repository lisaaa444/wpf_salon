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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }
        Client client = new Client();
        Priem prim = new Priem();
        SALONEntities db = new SALONEntities();
        private void Button_Click(object sender, RoutedEventArgs e) 
        {
            if (txtSur.Text != "" && txtName.Text != "" && txtMail.Text != "" && txtDate.Text != "" && txtTime.Text != "" && txtSpec.Text != "")
            {
                client.Surname = txtSur.Text.Trim();
                client.Name = txtName.Text.Trim();
                client.Mail = txtMail.Text.Trim();
                if (txtCode.Text != "")
                {
                    client.Code = true;
                }
                else
                {
                    client.Code = false;
                }
                db.Client.Add(client);
                db.SaveChanges();

                prim.Date = txtDate.Text.Trim();
                prim.Time = txtTime.Text.Trim();
                prim.ID_specialist = Convert.ToInt32(txtSpec.Text.Trim());

                foreach (var user in db.Client)
                {
                    client = user;
                }
                prim.ID_client = client.ID;
                db.Priem.Add(prim);
                db.SaveChanges();
                MessageBox.Show("Успешная запись");
            }
            else
            {
                MessageBox.Show("Не все данные введены!", "Ошибка!");
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
