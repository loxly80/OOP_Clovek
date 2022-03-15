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

namespace OOP_Clovek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Clovek karel;
        Clovek jan;

        public MainWindow()
        {
            InitializeComponent();

            karel = new Clovek();
            karel.Jmeno = "Karel";
            karel.Prijmeni = "Cveček";
            karel.DatumNarozeni = new DateTime(2006, 5, 24);
            Zobraz(karel, txt1);

            jan = new Clovek();
            jan.Jmeno = "Jan";
            Zobraz(jan, txt2);
        }

        public void Zobraz(Clovek clovek, TextBox textBox)
        {
            textBox.Text = clovek.Prijmeni + " " + clovek.Jmeno + "\n";
            textBox.Text += "Datum narození: " + clovek.DatumNarozeni.ToShortDateString() + "\n";
            textBox.Text += "Život: " + clovek.Zivot.ToString() + "\n";
            textBox.Text += "Energie: " + clovek.Energie.ToString() + "\n";
            textBox.Text += "Dovednost: " + clovek.Dovednost.ToString() + "\n";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            karel.Zestarnout();
            jan.Zestarnout();
            Zobraz(karel, txt1);
            Zobraz(jan, txt2);
        }
    }
}
