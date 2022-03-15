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
            Zobraz(karel, txt1);

            jan = new Clovek();
            jan.Jmeno = "Jan";
            Zobraz(jan, txt2);
        }

        public void Zobraz(Clovek clovek, TextBox textBox)
        {

        }

    }
}
