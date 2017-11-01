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

namespace Praktikum05
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Inimene> _inimesed;

        public MainWindow()
        {
            InitializeComponent();
            _inimesed = new List<Inimene>();
            lboxInimesed.ItemsSource = _inimesed;
        }

        private void btnLisa_Click(object sender, RoutedEventArgs e)
        {
            if (lboxInimesed.SelectedIndex < 0)
            {
                Inimene uusInimene = new Inimene();
                uusInimene.Eesnimi = txtEesnimi.Text;
                uusInimene.Perenimi = txtPerenimi.Text;
                uusInimene.Pikkus = int.Parse(txtPikkus.Text);
                _inimesed.Add(uusInimene);
            }
            else
            {
                var muudetav = lboxInimesed.SelectedItem as Inimene;
                muudetav.Perenimi = txtPerenimi.Text;
                muudetav.Eesnimi = txtEesnimi.Text;
                muudetav.Pikkus = int.Parse(txtPikkus.Text);
                btnLisa.Content = "Lisa";
                lboxInimesed.SelectedIndex = -1;
            }
            lboxInimesed.Items.Refresh();
        }






        private void lboxInimesed_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //SelectedIndex  > -1 siis listboxist on midagi valitud
            //SelectedIndex == -1 (listboxist ei ole midagi valitud)
            if (lboxInimesed.SelectedIndex > -1)
            {
                //Küsime inimese, kes valiti
                Inimene valitud = lboxInimesed.SelectedItem as Inimene;

                if (valitud != null)
                {
                    txtEesnimi.Text = valitud.Eesnimi;
                    txtPerenimi.Text = valitud.Perenimi;
                    txtPikkus.Text = valitud.Pikkus.ToString();
                    btnLisa.Content = "Muuda"; //muudab Lisa nupu Muuda-ks
                }
            }
        }
    }
    } 

