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

namespace T2TSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        private string imie; 
        private string nazwisko;
        private string pesel;
        private string[,] pacjent_dane;
        public MainWindow()
        {


        }
          

        private void bDodaj_Click(object sender, RoutedEventArgs e)
        {
            imie = tbImie.Text;
            nazwisko = tbNazwisko.Text;
            pesel = tbPesel.Text;


            lBPacjenci.Items.Add(string.Format("{0} | {1} | {2}", imie, nazwisko, pesel));
        }

        private void bUsun_Click_1(object sender, RoutedEventArgs e)
        {
            while (lBPacjenci.SelectedItems.Count != 0)
            {

                lBPacjenci.Items.Remove(lBPacjenci.SelectedItems[0]);

            }
        }

        }
    }

