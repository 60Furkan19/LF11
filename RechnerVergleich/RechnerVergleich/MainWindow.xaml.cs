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

namespace RechnerVergleich
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Rechner PC = new Rechner("IP", "Name");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnHinzufuegen(object sender, RoutedEventArgs e)
        {


            if (!PC.Programme.Contains(tbxProgramme.Text.Trim()))
            {
                PC.Programme.Add(tbxProgramme.Text.Trim());
            }


            tblprogramme.Text = "";
            foreach (string s in PC.Programme)
            {
                tblprogramme.Text += s + "\n";
            }
        }

        private void btnerstellen(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
