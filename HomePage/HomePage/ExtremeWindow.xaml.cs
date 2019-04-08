using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace Hangman
{
   /// <summary>
   /// Interaction logic for ExtremeWindow.xaml
   /// </summary>
   public partial class ExtremeWindow : Window
   {
      private char[]          word_letters;
      private int             random_number;
      private int             letters_found    = 0;
      private bool            win_condition    = false;
      private DispatcherTimer dispatcher_timer = new DispatcherTimer();
      private Stopwatch       stop_watch       = new Stopwatch();

      private const int LIST_SIZE    = 9;
      private const int WORD_SIZE    = 28;
      private const int EX_WORD_SIZE = 34;

      List<string> extreme_list = new List<string>()
      {
         "supercalifragilisticexpialidocious",
         "hepaticocholangiogastrostomy",
         "spectrophotofluorometrically",
         "ethylenediaminetetraacetates",
         "hexakosioihexekontahexaphobe",
         "pharyngolaryngoesophagectomy",
         "quinquagintatrecentilliardth",
         "tetraphenylcyclopentadienone",
         "quinquaquinquagintilliardths",
         "ultramicrospectrophotometers"
      };

      public ExtremeWindow()
      {
         InitializeComponent();

         Random random = new Random();

         dispatcher_timer.Tick += new EventHandler(Timer_tick);
         dispatcher_timer.Interval = new TimeSpan(0, 0, 0, 1);

         random_number = random.Next(0, LIST_SIZE);
         word_letters = Get_Word();

         if (word_letters.Length > WORD_SIZE)
            EX_Word_Size_Grid.Visibility = Visibility.Visible;
      }

      /*********************************************************************/
      /*                                                 */
      /*********************************************************************/
      private char[] Get_Word()
      {
         return extreme_list.ElementAt(random_number).ToCharArray();
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
                     if (word_letters.Length > WORD_SIZE)
                        First_Letter_Label.Content = button_selected.Content;
                     else
                        Seventh_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 1:
                     if (word_letters.Length > WORD_SIZE)
                        Second_Letter_Label.Content = button_selected.Content;
                     else
                        Eighth_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 2:
                     if (word_letters.Length > WORD_SIZE)
                        Third_Letter_Label.Content = button_selected.Content;
                     else
                        Nineth_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 3:
                     if (word_letters.Length > WORD_SIZE)
                        Fourth_Letter_Label.Content = button_selected.Content;
                     else
                        Tenth_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 4:
                     if (word_letters.Length > WORD_SIZE)
                        Fifth_Letter_Label.Content = button_selected.Content;
                     else
                        Elevenfth_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 5:
                     if (word_letters.Length > WORD_SIZE)
                        Sixth_Letter_Label.Content = button_selected.Content;
                     else
                        Twelfth_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 6:
                     if (word_letters.Length > WORD_SIZE)
                        Seventh_Letter_Label.Content = button_selected.Content;
                     else
                        Thirteenth_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 7:
                     if (word_letters.Length > WORD_SIZE)
                        Eighth_Letter_Label.Content = button_selected.Content;
                     else
                        Fourteenth_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 8:
                     if (word_letters.Length > WORD_SIZE)
                        Nineth_Letter_Label.Content = button_selected.Content;
                     else
                        Fifteenth_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 9:
                     if (word_letters.Length > WORD_SIZE)
                        Tenth_Letter_Label.Content = button_selected.Content;
                     else
                        Sixteenth_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 10:
                     if (word_letters.Length > WORD_SIZE)
                        Elevenfth_Letter_Label.Content = button_selected.Content;
                     else
                        Seventeeth_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 11:
                     if (word_letters.Length > WORD_SIZE)
                        Twelfth_Letter_Label.Content = button_selected.Content;
                     else
                        Eighteenth_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 12:
                     if (word_letters.Length > WORD_SIZE)
                        Thirteenth_Letter_Label.Content = button_selected.Content;
                     else
                        Nineteenth_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 13:
                     if (word_letters.Length > WORD_SIZE)
                        Fourteenth_Letter_Label.Content = button_selected.Content;
                     else
                        Twenteth_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 14:
                     if (word_letters.Length > WORD_SIZE)
                        Fifteenth_Letter_Label.Content = button_selected.Content;
                     else
                        Twentyfirst_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 15:
                     if (word_letters.Length > WORD_SIZE)
                        Sixteenth_Letter_Label.Content = button_selected.Content;
                     else
                        Twentysecond_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                 case 16:
                     if (word_letters.Length > WORD_SIZE)
                        Seventeeth_Letter_Label.Content = button_selected.Content;
                     else
                        Twentythird_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 17:
                     if (word_letters.Length > WORD_SIZE)
                        Eighteenth_Letter_Label.Content = button_selected.Content;
                     else
                        Twentyfourth_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 18:
                     if (word_letters.Length > WORD_SIZE)
                        Nineteenth_Letter_Label.Content = button_selected.Content;
                     else
                        Twentyfifth_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 19:
                     if (word_letters.Length > WORD_SIZE)
                        Twenteth_Letter_Label.Content = button_selected.Content;
                     else
                        Twentysixeth_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 20:
                     if (word_letters.Length > WORD_SIZE)
                        Twentyfirst_Letter_Label.Content = button_selected.Content;
                     else
                        Twentyseventh_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 21:
                     if (word_letters.Length > WORD_SIZE)
                        Twentysecond_Letter_Label.Content = button_selected.Content;
                     else
                        Twentyeighth_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 22:
                     if (word_letters.Length > WORD_SIZE)
                        Twentythird_Letter_Label.Content = button_selected.Content;
                     else
                        Twentynineth_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 23:
                     if (word_letters.Length > WORD_SIZE)
                        Twentyfourth_Letter_Label.Content = button_selected.Content;
                     else
                        Thirtieth_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 24:
                     if (word_letters.Length > WORD_SIZE)
                        Twentyfifth_Letter_Label.Content = button_selected.Content;
                     else
                        Thirtyfirst_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 25:
                     if (word_letters.Length > WORD_SIZE)
                        Twentysixeth_Letter_Label.Content = button_selected.Content;
                     else
                        Thirtysecond_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 26:
                     if (word_letters.Length > WORD_SIZE)
                        Twentyseventh_Letter_Label.Content = button_selected.Content;
                     else
                        Thirtythird_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 27:
                     if (word_letters.Length > WORD_SIZE)
                        Twentyeighth_Letter_Label.Content = button_selected.Content;
                     else
                        Thirtyfourth_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 28:
                     if (word_letters.Length > WORD_SIZE)
                        Twentynineth_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 29:
                     if (word_letters.Length > WORD_SIZE)
                        Thirtieth_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 30:
                     if (word_letters.Length > WORD_SIZE)
                        Thirtyfirst_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 31:
                     if (word_letters.Length > WORD_SIZE)
                        Thirtysecond_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 32:
                     if (word_letters.Length > WORD_SIZE)
                        Thirtythird_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
                  case 33:
                     if (word_letters.Length > WORD_SIZE)
                        Thirtyfourth_Letter_Label.Content = button_selected.Content;
                     letters_found += 1;
                     break;
               }

            if (letters_found == word_letters.Length)
               win_condition = true;
         }
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

         // Win Condition check
         if (win_condition == true)
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
