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

namespace WpfCalculatrice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Addition addition;
        private Soustraction soustraction;
        public MainWindow()
        {
            InitializeComponent();
            addition = new Addition(0, 0);
<<<<<<< HEAD
            soustraction = new Soustraction(0, 0);
<<<<<<< HEAD

=======
            multiplication = new Multiplication(0, 0);
           division = new Division(0, 0);
=======
            division = new Division(0, 0);
>>>>>>> 95929fdb7433b8f74609f181fb0ccd4a225d6380
>>>>>>> 1590f0a92b9324409f8d8efba5636507c2767274
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            double dblNumber1;
            double dblNumber2;

            if (double.TryParse(tbxNumber1.Text, out dblNumber1))
            {
                if (double.TryParse(tbxNumber2.Text, out dblNumber2))
                {
                    addition.setVal1(22);
                    addition.setVal2(33);
                    lblResponse.Content = addition.Additionne();
                }
            }
            else
            {
                MessageBox.Show("Veuillez contrôler le format des nombres saisies !", "Conversion", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {

<<<<<<< HEAD
            if (double.TryParse(tbxNumber1.Text, out dblNumber1))
            {
                if (double.TryParse(tbxNumber2.Text, out dblNumber2))
                {
                    soustraction.setVal1(dblNumber1);
                    soustraction.setVal2(dblNumber2);
                    lblResponse.Content = soustraction.Soustraire();
                }
            }
            else
            {
                MessageBox.Show("Veuillez contrôler le format des nombres saisies !", "Conversion", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
=======
>>>>>>> 1590f0a92b9324409f8d8efba5636507c2767274
        }

        private void btnMul_Click(object sender, RoutedEventArgs e)
        {

<<<<<<< HEAD
=======
<<<<<<< HEAD
            if (double.TryParse(tbxNumber1.Text, out dblNumber1))
            {
                if (double.TryParse(tbxNumber2.Text, out dblNumber2))
                {
                    multiplication.setV1(dblNumber1);
                    multiplication.setV2(dblNumber2);
                    lblResponse.Content = multiplication.Multiplit();
                }
            }
            else
            {
                MessageBox.Show("Veuillez contrôler le format des nombres saisies !", "Conversion", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
=======
>>>>>>> 95929fdb7433b8f74609f181fb0ccd4a225d6380
>>>>>>> 1590f0a92b9324409f8d8efba5636507c2767274
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {

<<<<<<< HEAD
=======
            if (double.TryParse(tbxNumber1.Text, out dblNumber1))
            {
                if (double.TryParse(tbxNumber2.Text, out dblNumber2))
                {
                    division.setVal1(dblNumber1);
                    division.setVal2(dblNumber2);
                    lblResponse.Content = division.Diviser();
                }
            }
            else
            {
                MessageBox.Show("Veuillez contrôler le format des nombres saisies !", "Conversion", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
>>>>>>> 1590f0a92b9324409f8d8efba5636507c2767274
        }
    }
}

