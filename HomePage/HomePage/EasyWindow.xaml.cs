using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Threading;

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
      private DispatcherTimer dispatcherTimer = new DispatcherTimer();
      private Stopwatch stopWatch = new Stopwatch();

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

         dispatcherTimer.Tick += new EventHandler(Timer_tick);
         dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 1);

         random_number = random.Next(0, 9);
         word_letters  = Get_Word();
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

         switch (target_index)
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
         MainWindow main_window = new MainWindow();
         main_window.Show();
         this.Close();
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private void Letter_Button_Click(object sender, RoutedEventArgs e)
      {
         Button button_click = (Button)sender;
         string letter_chosen;
         char  button_letter;

         if(stopWatch.IsRunning == false)
         {
            stopWatch.Start();
            dispatcherTimer.Start();
         }

         letter_chosen = button_click.Content.ToString();
         letter_chosen = letter_chosen.ToLower();
         button_letter = Convert.ToChar(letter_chosen);

         button_click.Visibility = Visibility.Hidden;

         if (Validate_Selection(button_letter) == true)
            Get_index(button_letter, button_click);
         else
         {
            Used_Letters_Label.Foreground = new SolidColorBrush(Colors.Red);
            Used_Letters_Label.Content += letter_chosen.ToUpper() + " ";
         }
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      void Timer_tick(object sender, EventArgs e)
      {
         if (stopWatch.IsRunning == true)
         {
            TimeSpan clock = stopWatch.Elapsed;
            Timer_Label.Content = String.Format("{0:00}:{1:00}", clock.Minutes, clock.Seconds);
         }
      }
   }
}
