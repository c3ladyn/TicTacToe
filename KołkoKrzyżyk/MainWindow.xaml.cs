using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
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

namespace KołkoKrzyżyk
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool gracz = true; // true = O, false = X
        int liczbaRund = 0;
        bool mamyZwyciezce = false;
                       
        public MainWindow()
        {
            
        }

        private void button_click(object sender, RoutedEventArgs e)
        {
            //wysyłanie przycisku
            Button znak = (Button)sender;

            //inkrementacja rund
            liczbaRund++;

            //true = O, false = X
            if (gracz == true)
            {
                znak.Content = "O";
            }
            else
            {
                znak.Content = "X";
            }


            // zliczamy rundy, jezeli jest ich 9 (full buttony, all.IsEnabled to draw, remis.)
            if (liczbaRund == 9)
            {
                MessageBox.Show("REMIS");
            }

            //osobno rundy, gracz O, gracz X, itp.
            gracz = !gracz;

            //po kliknieciu przycisk zostaje wcisniety
            znak.IsEnabled = false;

            // pionowo
            // 1. | L
            if ((przycisk1.Content == przycisk4.Content) & (przycisk4.Content == przycisk7.Content) & (!przycisk1.IsEnabled) & (!przycisk4.IsEnabled))
            {
                MessageBox.Show(znak.Content + " wygrywa!");
            }

            // 2. | mid
            else if ((przycisk2.Content == przycisk5.Content) & (przycisk5.Content == przycisk8.Content) & (!przycisk2.IsEnabled) & (!przycisk5.IsEnabled))
            {
                MessageBox.Show(znak.Content + " wygrywa!");
            }

            // 3 | R
            else if ((przycisk3.Content == przycisk6.Content) & (przycisk6.Content == przycisk9.Content) & (!przycisk3.IsEnabled) & (!przycisk6.IsEnabled))
            {
                MessageBox.Show(znak.Content + " wygrywa!");
            }

            // poziomo
            // 1. -
            else if ((przycisk1.Content == przycisk2.Content) & (przycisk2.Content == przycisk3.Content) & (!przycisk1.IsEnabled) && (!przycisk2.IsEnabled))
            {
                MessageBox.Show(znak.Content + " wygrywa!");
            }

            // 2. -
            else if ((przycisk4.Content == przycisk5.Content) & (przycisk5.Content == przycisk6.Content) & (!przycisk4.IsEnabled) && (!przycisk5.IsEnabled))
            {
                MessageBox.Show(znak.Content + " wygrywa!");
            }

            // 3. -
            else if ((przycisk7.Content == przycisk8.Content) & (przycisk8.Content == przycisk9.Content) & (!przycisk7.IsEnabled) && (!przycisk8.IsEnabled))
            {
                MessageBox.Show(znak.Content + " wygrywa!");
            }

            // \
            else if ((przycisk1.Content == przycisk5.Content) & (przycisk5.Content == przycisk9.Content) & (!przycisk1.IsEnabled) && (!przycisk5.IsEnabled))
            {
                MessageBox.Show(znak.Content + " wygrywa!");
            }
            // /
            else if ((przycisk3.Content == przycisk5.Content) & (przycisk5.Content == przycisk7.Content) & (!przycisk3.IsEnabled) && (!przycisk5.IsEnabled))
            {
                MessageBox.Show(znak.Content + " wygrywa!");
            }            

            
        }

        
        private void restart_click(object sender, RoutedEventArgs e)
        {
            // restart gry po kliknieciu Restart Game
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private void exit_click(object sender, RoutedEventArgs e)
        {
            // wyłączamy gre
            Application.Current.Shutdown();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
