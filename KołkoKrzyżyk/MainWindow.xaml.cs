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
using System.Windows.Controls.Primitives;
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

        bool jestWinner = false;

        //metoda z gory zakładamy, że nie ma Winnera
        private void sprawdzanieWinnera()
        {
            bool jestWinner = false;
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

            //osobno rundy, gracz O, gracz X, itd.
            gracz = !gracz;

            //po kliknieciu przycisk zostaje wcisniety
            znak.IsEnabled = false;

            //sprawdza metode, sprawdzanieWinnera czy jest faktycznie false.
            sprawdzanieWinnera();
            

            // pionowo

            /* 1. O - -
                  O - -
                  O - -
            */
            if ((przycisk1.Content == przycisk4.Content) & (przycisk4.Content == przycisk7.Content) & (!przycisk1.IsEnabled) & (!przycisk4.IsEnabled))
            {          
                jestWinner = true;
                MessageBox.Show(znak.Content + " wygrywa!");
                przycisk2.IsEnabled = false;
                przycisk3.IsEnabled = false;
                przycisk5.IsEnabled = false;
                przycisk6.IsEnabled = false;
                przycisk8.IsEnabled = false;
                przycisk9.IsEnabled = false;
            }

            /* 2. - O -
                  - O -
                  - O -
            */
            else if ((przycisk2.Content == przycisk5.Content) & (przycisk5.Content == przycisk8.Content) & (!przycisk2.IsEnabled) & (!przycisk5.IsEnabled))
            {
                jestWinner = true;
                MessageBox.Show(znak.Content + " wygrywa!");
                przycisk1.IsEnabled = false;
                przycisk3.IsEnabled = false;
                przycisk4.IsEnabled = false;
                przycisk6.IsEnabled = false;
                przycisk7.IsEnabled = false;
                przycisk9.IsEnabled = false;
            }

            /* 3. - - O
                  - - O
                  - - O
            */
            else if ((przycisk3.Content == przycisk6.Content) & (przycisk6.Content == przycisk9.Content) & (!przycisk3.IsEnabled) & (!przycisk6.IsEnabled))
            {
                jestWinner = true;
                MessageBox.Show(znak.Content + " wygrywa!");
                przycisk1.IsEnabled = false;
                przycisk2.IsEnabled = false;
                przycisk4.IsEnabled = false;
                przycisk5.IsEnabled = false;
                przycisk7.IsEnabled = false;
                przycisk8.IsEnabled = false;
            }

            // poziomo

            /* 1. O O O
                  - - -
                  - - -
            */
            else if ((przycisk1.Content == przycisk2.Content) & (przycisk2.Content == przycisk3.Content) & (!przycisk1.IsEnabled) && (!przycisk2.IsEnabled))
            {
                jestWinner = true;
                MessageBox.Show(znak.Content + " wygrywa!");
                przycisk4.IsEnabled = false;
                przycisk5.IsEnabled = false;
                przycisk6.IsEnabled = false;
                przycisk7.IsEnabled = false;
                przycisk8.IsEnabled = false;
                przycisk9.IsEnabled = false;
            }

            /* 2. - - -
                  O O O
                  - - -
            */
            else if ((przycisk4.Content == przycisk5.Content) & (przycisk5.Content == przycisk6.Content) & (!przycisk4.IsEnabled) && (!przycisk5.IsEnabled))
            {
                jestWinner = true;
                MessageBox.Show(znak.Content + " wygrywa!");
                przycisk1.IsEnabled = false;
                przycisk2.IsEnabled = false;
                przycisk3.IsEnabled = false;
                przycisk7.IsEnabled = false;
                przycisk8.IsEnabled = false;
                przycisk9.IsEnabled = false;
            }

            /* 3. - - -
                  - - -
                  O O O
            */
            else if ((przycisk7.Content == przycisk8.Content) & (przycisk8.Content == przycisk9.Content) & (!przycisk7.IsEnabled) && (!przycisk8.IsEnabled))
            {
                jestWinner = true;
                MessageBox.Show(znak.Content + " wygrywa!");
                przycisk1.IsEnabled = false;
                przycisk2.IsEnabled = false;
                przycisk3.IsEnabled = false;
                przycisk4.IsEnabled = false;
                przycisk5.IsEnabled = false;
                przycisk6.IsEnabled = false;
            }

            /* 1. O - -
                  - O -
                  - - O
            */
            else if ((przycisk1.Content == przycisk5.Content) & (przycisk5.Content == przycisk9.Content) & (!przycisk1.IsEnabled) && (!przycisk5.IsEnabled))
            {
                jestWinner = true;
                MessageBox.Show(znak.Content + " wygrywa!");
                przycisk2.IsEnabled = false;
                przycisk3.IsEnabled = false;
                przycisk4.IsEnabled = false;
                przycisk6.IsEnabled = false;
                przycisk7.IsEnabled = false;
                przycisk8.IsEnabled = false;
            }
            /* 1. - - O
                  - O -
                  O - -
            */
            else if ((przycisk3.Content == przycisk5.Content) & (przycisk5.Content == przycisk7.Content) & (!przycisk3.IsEnabled) && (!przycisk5.IsEnabled))
            {
                jestWinner = true;
                MessageBox.Show(znak.Content + " wygrywa!");
                przycisk1.IsEnabled = false;
                przycisk2.IsEnabled = false;
                przycisk4.IsEnabled = false;
                przycisk6.IsEnabled = false;
                przycisk8.IsEnabled = false;
                przycisk9.IsEnabled = false;
            }
            
            // remis gdy nie ma Winnera
            if (liczbaRund == 9 & jestWinner == false)
            {
                MessageBox.Show("REMIS");
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
    }
}
