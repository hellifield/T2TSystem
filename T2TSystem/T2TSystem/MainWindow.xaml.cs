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
     
        public MainWindow()
        {


        }
          

        private void bDodaj_Click(object sender, RoutedEventArgs e)
        {
            imie = tbImie.Text;
            nazwisko = tbNazwisko.Text;
            pesel = tbPesel.Text;

        
            if  (imie.Length == 0)
            {
            MessageBox.Show("Podaj imię!");

            }

            else if (nazwisko.Length == 0)
            {
                MessageBox.Show("Podaj nazwisko!");

            } 

            else if (pesel.Length != 11)
            {
                MessageBox.Show("Popraw PESEL! Składa się on z 11 znaków!");
               
            }
            else  
            {
                lBPacjenci.Items.Add(string.Format("{0} {1} {2}", imie, nazwisko, pesel));
            }

            
          
        }

        private void bUsun_Click_1(object sender, RoutedEventArgs e)
        {
         
                lBPacjenci.Items.Remove(lBPacjenci.SelectedItems[0]);

            
        }

        private void bEdytuj_Click(object sender, RoutedEventArgs e)
        {
            if (lBPacjenci.SelectedIndex < 0) return;
            MessageBox.Show("Po zmianie odpowiednich danych należy wybrać przycisk Dodaj pacjenta!");
            string temp = lBPacjenci.Items[lBPacjenci.SelectedIndex].ToString();
            string[] pacjent = temp.Split(' ');   
            tbImie.Text = pacjent[0].ToString();
            tbNazwisko.Text = pacjent[1];
            tbPesel.Text = pacjent[2];
            lBPacjenci.Items.Remove(lBPacjenci.SelectedItems[0]); // Usunąć, żeby się nie powtarzało, a dodawanie normalnie przyciskiem Dodaj Pacjenta po edycji
            
        }

        private void bSzukaj_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Należy wpisać pełne dane pacjenta: Imie Nazwisko Pesel - oddzielone znakiem SPACJI");
            string szukane = tbSzukaj.Text; 
            int ind = lBPacjenci.Items.IndexOf(szukane);
            tbPesel.Text = ind.ToString();
           string temp = lBPacjenci.Items[ind].ToString();
            lBPacjenci.Items.Clear();
            string[] pacjent = temp.Split(' ');
            tbImie.Text = pacjent[0].ToString();
            tbNazwisko.Text = pacjent[1];
            tbPesel.Text = pacjent[2];
            lBPacjenci.Items.Add(string.Format("{0} {1} {2}", tbImie.Text, tbNazwisko.Text, tbPesel.Text));
          
        }

        private void bSortuj_Click(object sender, RoutedEventArgs e)
        {
            lBPacjenci.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("Component", System.ComponentModel.ListSortDirection.Ascending));
        }

        private void bSortuj2_Click(object sender, RoutedEventArgs e)
        {
            lBPacjenci.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("Component", System.ComponentModel.ListSortDirection.Descending));
      
        }
      
           
        
        
        
        }
         
        }

    

