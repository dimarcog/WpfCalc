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
        private Multiplication multiplication;
        private Division division;
        public MainWindow()
        {
            InitializeComponent();
            addition = new Addition(0, 0);
            soustraction = new Soustraction(0, 0);
            multiplication = new Multiplication(0, 0);
            division = new Division(0, 0);
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
            double dblNumber1;
            double dblNumber2;

            if (double.TryParse(tbxNumber1.Text, out dblNumber1))
            {
                if (double.TryParse(tbxNumber2.Text, out dblNumber2))
                {
                    soustraction.setVal1(22);
                    soustraction.setVal2(33);
                    lblResponse.Content = soustraction.Soustraire();
                }
            }
            else
            {
                MessageBox.Show("Veuillez contrôler le format des nombres saisies !", "Conversion", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnMul_Click(object sender, RoutedEventArgs e)
        {
            double dblNumber1;
            double dblNumber2;

            if (double.TryParse(tbxNumber1.Text, out dblNumber1))
            {
                if (double.TryParse(tbxNumber2.Text, out dblNumber2))
                {
                    multiplication.setVal1(22);
                    multiplication.setVal2(33);
                    lblResponse.Content = multiplication.Multiplier();
                }
            }
            else
            {
                MessageBox.Show("Veuillez contrôler le format des nombres saisies !", "Conversion", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            double dblNumber1;
            double dblNumber2;

            if (double.TryParse(tbxNumber1.Text, out dblNumber1))
            {
                if (double.TryParse(tbxNumber2.Text, out dblNumber2))
                {
                    division.setVal1(22);
                    division.setVal2(33);
                    lblResponse.Content = division.Diviser();
                }
            }
            else
            {
                MessageBox.Show("Veuillez contrôler le format des nombres saisies !", "Conversion", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}

