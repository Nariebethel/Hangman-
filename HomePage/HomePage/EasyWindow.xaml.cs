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
using System.Windows.Shapes;

namespace Hangman
{
   /// <summary>
   /// Interaction logic for EasyWindow.xaml
   /// </summary>
   /// 


   public partial class EasyWindow : Window
   {
      private int random_number;
      private char[] word_letters;
      private MainWindow main_window;

      private List<string> easy_list = new List<string>()
      {
         "apex",
         "dogs",
         "cats",
         "deer",
         "epic",
         "frog",
         "glow",
         "zone",
         "whig",
         "lazy"
      };

      /*********************************************************************/
      /*                       Default Constructor                         */
      /*********************************************************************/
      public EasyWindow()
      {
         InitializeComponent();
         Random random = new Random();
         random_number = random.Next(1, 10);
         word_letters = Get_Word();
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      public EasyWindow(MainWindow window)
      {
         Random random = new Random();

         InitializeComponent();

         main_window = window;
         random_number = random.Next(1, 10);
         word_letters = Get_Word();
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private char[] Get_Word()
      {
         return easy_list.ElementAt(random_number).ToCharArray();
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private bool Validate_Selection(char letter_selected)
      {
         bool char_selection = false;

         foreach (char letter in word_letters)
            if (letter == letter_selected)
            {
               char_selection = true;
               break;
            }
            else
               char_selection = false;

         return char_selection;
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private void Get_index(char letter_selected, Button button_selected)
      {
         int letter_index = -1,
             target_index = 0;

         foreach (char letter in word_letters)
         {
            letter_index++;
            if (letter == letter_selected)
               target_index = letter_index;
         }

         switch(target_index)
         {
            case 0:
               First_Letter_Label.Content = button_selected.Content;
               break;
            case 1:
               Second_Letter_Label.Content = button_selected.Content;
               break;
            case 2:
               Third_Letter_Label.Content = button_selected.Content;
               break;
            case 3:
               Fourth_Letter_Label.Content = button_selected.Content;
               break;
         }
         return;
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private void Home_Button_Click(object sender, RoutedEventArgs e)
      {
         main_window.Show();
         this.Close();
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private void A_button_Click(object sender, RoutedEventArgs e)
      {
         A_button.Visibility = Visibility.Hidden;

         if (Validate_Selection('a') == true)
            Get_index('a', A_button);
         else
         {
            Used_Letters_Label.Foreground = new SolidColorBrush(Colors.Red);
            Used_Letters_Label.Content += "A ";
         }
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private void B_button_Click(object sender, RoutedEventArgs e)
      {
         B_button.Visibility = Visibility.Hidden;

         if (Validate_Selection('b') == true)
            Get_index('b', B_button);
         else
         {
            Used_Letters_Label.Foreground = new SolidColorBrush(Colors.Red);
            Used_Letters_Label.Content += "B ";
         }
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private void C_button_Click(object sender, RoutedEventArgs e)
      {
         C_button.Visibility = Visibility.Hidden;

         if (Validate_Selection('c') == true)
            Get_index('c', C_button);
         else
         {
            Used_Letters_Label.Foreground = new SolidColorBrush(Colors.Red);
            Used_Letters_Label.Content += "C ";
         }
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private void D_button_Click(object sender, RoutedEventArgs e)
      {
         D_button.Visibility = Visibility.Hidden;

         if (Validate_Selection('d') == true)
            Get_index('d', D_button);
         else
         {
            Used_Letters_Label.Foreground = new SolidColorBrush(Colors.Red);
            Used_Letters_Label.Content += "D ";
         }
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private void E_button_Click(object sender, RoutedEventArgs e)
      {
         E_button.Visibility = Visibility.Hidden;

         if (Validate_Selection('e') == true)
            Get_index('e', E_button);
         else
         {
            Used_Letters_Label.Foreground = new SolidColorBrush(Colors.Red);
            Used_Letters_Label.Content += "E ";
         }
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private void F_button_Click(object sender, RoutedEventArgs e)
      {
         F_button.Visibility = Visibility.Hidden;

         if (Validate_Selection('f') == true)
            Get_index('f', F_button);
         else
         {
            Used_Letters_Label.Foreground = new SolidColorBrush(Colors.Red);
            Used_Letters_Label.Content += "F ";
         }
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private void G_button_Click(object sender, RoutedEventArgs e)
      {
         G_button.Visibility = Visibility.Hidden;

         if (Validate_Selection('g') == true)
            Get_index('g', G_button);
         else
         {
            Used_Letters_Label.Foreground = new SolidColorBrush(Colors.Red);
            Used_Letters_Label.Content += "G ";
         }
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private void H_button_Click(object sender, RoutedEventArgs e)
      {
         H_button.Visibility = Visibility.Hidden;

         if (Validate_Selection('h') == true)
            Get_index('h', H_button);
         else
         {
            Used_Letters_Label.Foreground = new SolidColorBrush(Colors.Red);
            Used_Letters_Label.Content += "H ";
         }
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private void I_button_Click(object sender, RoutedEventArgs e)
      {
         I_button.Visibility = Visibility.Hidden;

         if (Validate_Selection('i') == true)
            Get_index('i', I_button);
         else
         {
            Used_Letters_Label.Foreground = new SolidColorBrush(Colors.Red);
            Used_Letters_Label.Content += "I ";
         }
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private void J_button_Click(object sender, RoutedEventArgs e)
      {
         J_button.Visibility = Visibility.Hidden;

         if (Validate_Selection('j') == true)
            Get_index('j', J_button);
         else
         {
            Used_Letters_Label.Foreground = new SolidColorBrush(Colors.Red);
            Used_Letters_Label.Content += "J ";
         }
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private void K_button_Click(object sender, RoutedEventArgs e)
      {
         K_button.Visibility = Visibility.Hidden;

         if (Validate_Selection('k') == true)
            Get_index('k', K_button);
         else
         {
            Used_Letters_Label.Foreground = new SolidColorBrush(Colors.Red);
            Used_Letters_Label.Content += "K ";
         }
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private void L_button_Click(object sender, RoutedEventArgs e)
      {
         L_button.Visibility = Visibility.Hidden;

         if (Validate_Selection('l') == true)
            Get_index('l', L_button);
         else
         {
            Used_Letters_Label.Foreground = new SolidColorBrush(Colors.Red);
            Used_Letters_Label.Content += "L ";
         }
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private void M_button_Click(object sender, RoutedEventArgs e)
      {
         M_button.Visibility = Visibility.Hidden;

         if (Validate_Selection('m') == true)
            Get_index('m', M_button);
         else
         {
            Used_Letters_Label.Foreground = new SolidColorBrush(Colors.Red);
            Used_Letters_Label.Content += "M ";
         }
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private void N_button_Click(object sender, RoutedEventArgs e)
      {
         N_button.Visibility = Visibility.Hidden;

         if (Validate_Selection('n') == true)
            Get_index('n', N_button);
         else
         {
            Used_Letters_Label.Foreground = new SolidColorBrush(Colors.Red);
            Used_Letters_Label.Content += "N ";
         }
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private void O_buton_Click(object sender, RoutedEventArgs e)
      {
         O_button.Visibility = Visibility.Hidden;

         if (Validate_Selection('o') == true)
            Get_index('o', O_button);
         else
         {
            Used_Letters_Label.Foreground = new SolidColorBrush(Colors.Red);
            Used_Letters_Label.Content += "O ";
         }
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private void P_button_Click(object sender, RoutedEventArgs e)
      {
         P_button.Visibility = Visibility.Hidden;

         if (Validate_Selection('p') == true)
            Get_index('p', P_button);
         else
         {
            Used_Letters_Label.Foreground = new SolidColorBrush(Colors.Red);
            Used_Letters_Label.Content += "P ";
         }
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private void Q_button_Click(object sender, RoutedEventArgs e)
      {
         Q_button.Visibility = Visibility.Hidden;

         if (Validate_Selection('q') == true)
            Get_index('q', Q_button);
         else
         {
            Used_Letters_Label.Foreground = new SolidColorBrush(Colors.Red);
            Used_Letters_Label.Content += "Q ";
         }
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private void R_button_Click(object sender, RoutedEventArgs e)
      {
         R_button.Visibility = Visibility.Hidden;

         if (Validate_Selection('r') == true)
            Get_index('r', R_button);
         else
         {
            Used_Letters_Label.Foreground = new SolidColorBrush(Colors.Red);
            Used_Letters_Label.Content += "R ";
         }
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private void S_Button_Click(object sender, RoutedEventArgs e)
      {
         S_button.Visibility = Visibility.Hidden;

         if (Validate_Selection('s') == true)
            Get_index('s', S_button);
         else
         {
            Used_Letters_Label.Foreground = new SolidColorBrush(Colors.Red);
            Used_Letters_Label.Content += "S ";
         }
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private void T_button_Click(object sender, RoutedEventArgs e)
      {
         T_button.Visibility = Visibility.Hidden;

         if (Validate_Selection('t') == true)
            Get_index('t', T_button);
         else
         {
            Used_Letters_Label.Foreground = new SolidColorBrush(Colors.Red);
            Used_Letters_Label.Content += "T ";
         }
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private void U_button_Click(object sender, RoutedEventArgs e)
      {
         U_button.Visibility = Visibility.Hidden;

         if (Validate_Selection('u') == true)
            Get_index('u', U_button);
         else
         {
            Used_Letters_Label.Foreground = new SolidColorBrush(Colors.Red);
            Used_Letters_Label.Content += "U ";
         }
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private void V_button_Click(object sender, RoutedEventArgs e)
      {
         V_button.Visibility = Visibility.Hidden;

         if (Validate_Selection('v') == true)
            Get_index('v', V_button);
         else
         {
            Used_Letters_Label.Foreground = new SolidColorBrush(Colors.Red);
            Used_Letters_Label.Content += "V ";
         }
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private void W_button_Click(object sender, RoutedEventArgs e)
      {
         W_button.Visibility = Visibility.Hidden;

         if (Validate_Selection('w') == true)
            Get_index('w', W_button);
         else
         {
            Used_Letters_Label.Foreground = new SolidColorBrush(Colors.Red);
            Used_Letters_Label.Content += "W ";
         }
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private void X_button_Click(object sender, RoutedEventArgs e)
      {
         X_button.Visibility = Visibility.Hidden;

         if (Validate_Selection('x') == true)
            Get_index('x', X_button);
         else
         {
            Used_Letters_Label.Foreground = new SolidColorBrush(Colors.Red);
            Used_Letters_Label.Content += "X ";
         }
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private void Y_button_Click(object sender, RoutedEventArgs e)
      {
         Y_button.Visibility = Visibility.Hidden;

         if (Validate_Selection('y') == true)
            Get_index('y', Y_button);
         else
         {
            Used_Letters_Label.Foreground = new SolidColorBrush(Colors.Red);
            Used_Letters_Label.Content += "Y ";
         }
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private void Z_button_Click(object sender, RoutedEventArgs e)
      {
         Z_button.Visibility = Visibility.Hidden;

         if (Validate_Selection('z') == true)
            Get_index('z', Z_button);
         else
         {
            Used_Letters_Label.Foreground = new SolidColorBrush(Colors.Red);
            Used_Letters_Label.Content += "Z ";
         }
      }

   }
}
