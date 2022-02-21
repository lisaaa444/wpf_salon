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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    
    public partial class Window1 : Window
    {
        Specialist spec = new Specialist();
        SALONEntities db = new SALONEntities();
        int n = 0;
        public Window1()
        {
            InitializeComponent();
            foreach (var user in db.Specialist)
            {
                if (n == 0)
                {
                    lblProf.Content = user.Profession;
                    lblWork.Content = "Опыт работы " + user.Work_experience.ToString() + " года(лет)";
                    lblCours.Content = "Прошла " + user.Courses.ToString() + " курса(ов) повышения квалификации";
                    n = 1;
                }
                else if (n == 1)
                {
                    lblProf1.Content = user.Profession;
                    lblWork1.Content = "Опыт работы " + user.Work_experience.ToString() + " года(лет)";
                    lblCours1.Content = "Прошла " + user.Courses.ToString() + " курса(ов) повышения квалификации";
                    n = 2;
                }
                else if (n == 2)
                {
                    lblProf2.Content = user.Profession;
                    lblWork2.Content = "Опыт работы " + user.Work_experience.ToString() + " года(лет)";
                    lblCours2.Content = "Прошла " + user.Courses.ToString() + " курса(ов) повышения квалификации";
                    n = 3;
                }
                else if (n == 3)
                {
                    lblProf3.Content = user.Profession;
                    lblWork3.Content = "Опыт работы " + user.Work_experience.ToString() + " года(лет)";
                    lblCours3.Content = "Прошла " + user.Courses.ToString() + " курса(ов) повышения квалификации";
                }
            }
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
            Window4 window4 = new Window4();
            window4.Show();
            this.Hide();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Window4 window4 = new Window4();
            window4.Show();
            this.Hide();
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Window4 window4 = new Window4();
            window4.Show();
            this.Hide();
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Window4 window4 = new Window4();
            window4.Show();
            this.Hide();
        }
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }
    }
}
