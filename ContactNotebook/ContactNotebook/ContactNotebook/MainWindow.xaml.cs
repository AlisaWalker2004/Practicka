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
using System.IO;


namespace ContactNotebook
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public ClassForList list { get; set; } = new ClassForList();

        public MainWindow()
        {
            InitializeComponent();

            list.fileRead = File.ReadAllLines("Контакты.txt", Encoding.UTF8).ToList();
            DataContext = list;
            
        }

        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
            spAuto.Visibility = Visibility.Visible;
            BtnEnter.Visibility = Visibility.Hidden;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("Контакты.txt", true))
            {
                sw.Write("\nКабинет:\t" + tbKab.Text); sw.Write("\tДолжность или ФИО:\t" + tbFio.Text);
                sw.Write("\tНомер телефона:\t" + tbNumberPhone.Text);
                sw.Close();

                MessageBox.Show("Информация сохранена!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);

                tbKab.Text = ""; tbFio.Text = ""; tbNumberPhone.Text = "";

                list.fileRead = File.ReadAllLines("Контакты.txt", Encoding.UTF8).ToList();
                DataContext = list;
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            GridVis.Visibility = Visibility.Hidden;
            BtnEdit.Visibility = Visibility.Hidden;
            BtnEnter.Visibility = Visibility.Visible;
            spAuto.Visibility = Visibility.Hidden;
            BtnBack.Visibility = Visibility.Hidden;
            BtnDelete.Visibility = Visibility.Hidden;
        }

        private void BtnVhod_Click(object sender, RoutedEventArgs e)
        {
            if (tbPassword.Text != "")
            {
                if (tbPassword.Text == "894409")
                {
                    GridVis.Visibility = Visibility.Visible;
                    BtnEdit.Visibility = Visibility.Visible;
                    spAuto.Visibility = Visibility.Hidden;
                    BtnBack.Visibility = Visibility.Visible;
                    BtnDelete.Visibility = Visibility.Visible;
                    tbPassword.Text = "";
                }
            }
            else
                MessageBox.Show("Поле пароля не должно быть пустым", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void lbReadText_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (BtnEnter.Visibility == Visibility.Hidden)
            {
                
                tbKab.Text = lbReadText.SelectedItem.ToString().Split('\t')[1];
                tbFio.Text = lbReadText.SelectedItem.ToString().Split('\t')[3];
                tbNumberPhone.Text = lbReadText.SelectedItem.ToString().Split('\t')[5];

            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            list.fileRead.RemoveAt(lbReadText.SelectedIndex);

            TextWriter writer = new StreamWriter("Контакты.txt");
            foreach (var item in lbReadText.Items)
                writer.WriteLine(item.ToString());
            writer.Close();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            list.fileRead.RemoveAt(lbReadText.SelectedIndex);
            list.fileRead.Add("Кабинет:\t" + tbKab.Text + "\tДолжность или ФИО:\t" + tbFio.Text + "\tНомер телефона:\t" + tbNumberPhone.Text);

            TextWriter writer = new StreamWriter("Контакты.txt");
            foreach (var item in lbReadText.Items)
                writer.WriteLine(item.ToString());
            writer.Close();
        }

    }
}
