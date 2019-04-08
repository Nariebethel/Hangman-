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
      private char[] word_letters;
      private int random_number;
      private int win_condition = 0;
      private DispatcherTimer dispatcher_timer = new DispatcherTimer();
      private Stopwatch stop_watch = new Stopwatch();

      private const int LIST_SIZE = 9;
      private const int WORD_SIZE = 4;

      List<string> extreme_list = new List<string>()
      {
         "supercalifragilisticexpialidocious",
         "hepaticocholangiogastrostomy",
         "spectrophotofluorometrically",
      };

      public ExtremeWindow()
      {
         InitializeComponent();
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
      //      if (letter == letter_selected)
      //         switch (letter_index)
      //         {
      //            case 0:
      //               First_Letter_Label.Content = button_selected.Content;
      //               win_condition += 1;
      //               break;
      //            case 1:
      //               Second_Letter_Label.Content = button_selected.Content;
      //               win_condition += 1;
      //               break;
      //            case 2:
      //               Third_Letter_Label.Content = button_selected.Content;
      //               win_condition += 1;
      //               break;
      //            case 3:
      //               Fourth_Letter_Label.Content = button_selected.Content;
      //               win_condition += 1;
      //               break;
      //         }
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

         if (win_condition == WORD_SIZE)
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
      private void Return_Home(object sender, RoutedEventArgs e)
      {
         this.KeyDown += new KeyEventHandler(Home_Button_Click);
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
   }
}
