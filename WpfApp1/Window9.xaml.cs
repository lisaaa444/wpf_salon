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
    /// Логика взаимодействия для Window9.xaml
    /// </summary>
    public partial class Window9 : Window
    {
        Specialist specialist = new Specialist();
        SALONEntities db = new SALONEntities();
        int n = 0;
        public Window9()
        {
            InitializeComponent();
            foreach (var user in db.Specialist)
            {
                if (n == 0)
                {
                    prof.Text = user.Profession;
                    work.Text = user.Work_experience.ToString();
                    cours.Text = user.Courses.ToString();
                    n=1;
                }
                else if (n == 1)
                {
                    prof1.Text = user.Profession;
                    work1.Text = user.Work_experience.ToString();
                    cours1.Text = user.Courses.ToString();
                    n = 2;
                }
                else if (n == 2)
                {
                    prof2.Text = user.Profession;
                    work2.Text = user.Work_experience.ToString();
                    cours2.Text = user.Courses.ToString();
                    n=3;
                }
                else if(n == 3)
                {
                    prof3.Text = user.Profession;
                    work3.Text = user.Work_experience.ToString();
                    cours3.Text = user.Courses.ToString();
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(txtID.Text != "")
            {
                int id = Convert.ToInt32(txtID.Text);
                foreach (var idS in db.Specialist)
                {
                    if (idS.ID == id)
                    {
                        specialist = idS;
                        break;
                    }
                }
                if (id == 1)
                {
                    specialist.Profession = prof.Text;
                    specialist.Work_experience = Convert.ToInt32(work.Text);
                    specialist.Courses = Convert.ToInt32(cours.Text);
                    db.SaveChanges();
                    MessageBox.Show("Информация обновлена!", "Успех!");
                }
                else if (id == 2)
                {
                    specialist.Profession = prof1.Text;
                    specialist.Work_experience = Convert.ToInt32(work1.Text);
                    specialist.Courses = Convert.ToInt32(cours1.Text);
                    db.SaveChanges();
                    MessageBox.Show("Информация обновлена!", "Успех!");
                }
                else if (id == 3)
                {
                    specialist.Profession = prof2.Text;
                    specialist.Work_experience = Convert.ToInt32(work2.Text);
                    specialist.Courses = Convert.ToInt32(cours2.Text);
                    db.SaveChanges();
                    MessageBox.Show("Информация обновлена!", "Успех!");
                }
                else if (id == 4)
                {
                    specialist.Profession = prof3.Text;
                    specialist.Work_experience = Convert.ToInt32(work3.Text);
                    specialist.Courses = Convert.ToInt32(cours3.Text);
                    db.SaveChanges();
                    MessageBox.Show("Информация обновлена!", "Успех!");
                }
                else
                {
                    MessageBox.Show("ID не существует", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Укажите ID", "Ошибка");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window7 window7 = new Window7();
            window7.Show();
            this.Hide();
        }
    }
}
