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

namespace Kalkulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button dugme = (Button)sender;
            PrikazTexta.Text +=dugme.Content.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (PrikazTexta.Text.Length > 0)
            {
                PrikazTexta.Text.Substring(0, PrikazTexta.Text.Length - 1);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            PrikazTexta.Text = string.Empty;
        }
        private void Click_Rezultat(object sender, RoutedEventArgs e)
        {
            try
            {
                string op = string.Empty;
                int index = 0;

                if(PrikazTexta.Text.Contains("/"))
                {
                    index = PrikazTexta.Text.IndexOf("/");
                } 
                else if (PrikazTexta.Text.Contains("*"))
                {
                    index = PrikazTexta.Text.IndexOf("*");
                }
                else if (PrikazTexta.Text.Contains("-"))
                {
                    index = PrikazTexta.Text.IndexOf("-");
                }
                else if (PrikazTexta.Text.Contains("+"))
                {
                    index = PrikazTexta.Text.IndexOf("+");
                }

                op = PrikazTexta.Text.Substring(index, 1);

                double op1 = Convert.ToDouble(PrikazTexta.Text.Substring(0, index));
                double op2 = Convert.ToDouble(PrikazTexta.Text.Substring(index + 1, PrikazTexta.Text.Length - index - 1));

                if(op == "+")
                {
                    PrikazTexta.Text += "=" + (op1 + op2);
                } 
                else if (op == "-")
                {
                    PrikazTexta.Text += "=" + (op1 - op2);
                }
                else if (op == "*")
                {
                    PrikazTexta.Text += "=" + (op1 * op2);
                }
                else
                {
                    PrikazTexta.Text += "=" + (op1 / op2);
                }

            }
            catch (Exception ex)
            {
                PrikazTexta.Text = "Error!";
            }
        }
    }
}
