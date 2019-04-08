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
   /// Interaction logic for MediumWindow.xaml
   /// </summary>
   public partial class MediumWindow : Window
   {
      private char[] word_letters;
      private int random_number;
      private int letters_found = 0;
      private DispatcherTimer dispatcher_timer = new DispatcherTimer();
      private Stopwatch stop_watch = new Stopwatch();

      private const int LIST_SIZE = 9;
      private const int WORD_SIZE = 6;

      List<string> medium_list = new List<string>()
      {
         "action",
         "bamboo",
         "casbah",
         "dwarfs",
         "emotes",
         "flames",
         "ginger",
         "idioms",
         "ogdoad",
         "safari"
      };

      public MediumWindow()
      {
         InitializeComponent();

         Random random = new Random();

         dispatcher_timer.Tick += new EventHandler(Timer_tick);
         dispatcher_timer.Interval = new TimeSpan(0, 0, 0, 1);

         random_number = random.Next(0, LIST_SIZE);
         word_letters = Get_Word();
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private char[] Get_Word()
      {
         return medium_list.ElementAt(random_number).ToCharArray();
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private bool Validate_Selection(char letter_selected)
      {
         bool char_selection = false;

         foreach (char letter in word_letters)
            if (letter == letter_selected)
               char_selection = true;

         return char_selection;
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private void Get_index(char letter_selected, Button button_selected)
      {
         int letter_index = -1;

         foreach (char letter in word_letters)
         {
            letter_index++;
            if (letter == letter_selected)
               switch (letter_index)
               {
                  case 0:
                     First_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 1:
                     Second_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 2:
                     Third_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 3:
                     Fourth_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 4:
                     Fifth_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 5:
                     Sixth_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
               }
         }
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private void Letter_Button_Click(object sender, RoutedEventArgs e)
      {
         Button button_click = (Button)sender;
         string letter_chosen;
         char button_letter;


         letter_chosen = button_click.Content.ToString();
         letter_chosen = letter_chosen.ToLower();
         button_letter = Convert.ToChar(letter_chosen);

         if (stop_watch.IsRunning == false)
         {
            stop_watch.Start();
            dispatcher_timer.Start();
         }

         button_click.Visibility = Visibility.Hidden;

         if (Validate_Selection(button_letter) == true)
            Get_index(button_letter, button_click);
         else
         {
            Used_Letters_Label.Foreground = new SolidColorBrush(Colors.Red);
            Used_Letters_Label.Content += letter_chosen.ToUpper() + " ";
         }

         if (letters_found == WORD_SIZE)
         {
            TimeSpan clock = stop_watch.Elapsed;

            Win_Time_Label.Content = String.Format("{0:00}:{1:00}", clock.Minutes, clock.Seconds);

            stop_watch.Stop();
            dispatcher_timer.Stop();
            Win_Grid.Visibility = Visibility.Visible;
         }
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private void Timer_tick(object sender, EventArgs e)
      {
         if (stop_watch.IsRunning == true)
         {
            TimeSpan clock = stop_watch.Elapsed;
            Timer_Label.Content = String.Format("{0:00}:{1:00}", clock.Minutes, clock.Seconds);
         }
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
      private void Return_Home(object sender, RoutedEventArgs e)
      {
         this.KeyDown += new KeyEventHandler(Timer_Tick);
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private void Timer_Tick(object sender, RoutedEventArgs e)
      {
         if (letters_found == WORD_SIZE)
         {
            MainWindow main_window = new MainWindow();
            main_window.Show();
            this.Close();
         }
      }
   }
}
