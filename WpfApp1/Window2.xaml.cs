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
using System.Net;
using System.IO;
using System.Net.Mail;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
            this.Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();
            this.Hide();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window5 window5 = new Window5();
            window5.Show();
            this.Hide();
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {           
            Random rand = new Random();
            string email_send = "mojetnenado2020@mail.ru";
            string pass = "fKeiLL4x0J7QG2mHZC6s";
            string email_recipient = Email.Text;
            string name_send = "mojetnenado2020.2002@mail.ru";

            using (MailMessage mn = new MailMessage(name_send + "<" + email_send + ">", email_recipient))
            {
                mn.Subject = "Код для получения скидки!";
                mn.Body = "Ваш код: " + rand.Next(9, 31);
                using (SmtpClient sc = new SmtpClient("smtp.mail.ru", 25))
                {
                    sc.EnableSsl = true;
                    sc.DeliveryMethod = SmtpDeliveryMethod.Network;
                    sc.Credentials = new NetworkCredential(email_send, pass);
                    sc.Send(mn);
                    MessageBox.Show("Код отправлен на указанный Email!", "Успех!");
                }
            }
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }
    }
}
