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
        public MainWindow()
        {
            InitializeComponent();

            lbReadText.ItemsSource = File.ReadAllLines("Контакты.txt", Encoding.UTF8);

        }

        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
            spAuto.Visibility = Visibility.Visible;
            BtnEnter.Visibility = Visibility.Hidden;
        }

        static void lineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("Контакты.txt", true))
            {
                sw.Write("\nКабинет:\t" + tbKab.Text); sw.Write("\tДолжность или ФИО:\t" + tbFio.Text);
                sw.Write("Номер телефона: " + tbNumberPhone.Text);
                sw.Close();

                MessageBox.Show("Информация сохранена!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);

                tbKab.Text = ""; tbFio.Text = ""; tbNumberPhone.Text = "";

                lbReadText.ItemsSource = File.ReadAllLines("Контакты.txt", Encoding.UTF8);

            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            GridVis.Visibility = Visibility.Hidden;
            BtnSave.Visibility = Visibility.Hidden;
            BtnEnter.Visibility = Visibility.Visible;
            spAuto.Visibility = Visibility.Hidden;
            BtnBack.Visibility = Visibility.Hidden;
        }

        private void BtnVhod_Click(object sender, RoutedEventArgs e)
        {
            if (tbPassword.Text != "")
            {
                if (tbPassword.Text == "894409")
                {
                    GridVis.Visibility = Visibility.Visible;
                    BtnSave.Visibility = Visibility.Visible;
                    spAuto.Visibility = Visibility.Hidden;
                    BtnBack.Visibility = Visibility.Visible;
                }
            }
            else
                MessageBox.Show("Поле пароля не должно быть пустым", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void lbReadText_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(BtnEnter.Visibility == Visibility.Hidden)
            {
                tbKab.Text = lbReadText.SelectedItem.ToString().Split('\t')[1];
                tbFio.Text = lbReadText.SelectedItem.ToString().Split('\t')[3];
                tbNumberPhone.Text = lbReadText.SelectedItem.ToString().Split(' ')[4];
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            lbReadText.Items.RemoveAt(lbReadText.SelectedIndex);
            StreamWriter sw = new StreamWriter("Контакты.txt");

            foreach (string line in lbReadText.Items)
                sw.WriteLine(line);

            sw.Close();
        }
    }
}
