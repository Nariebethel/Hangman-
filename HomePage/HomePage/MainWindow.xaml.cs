using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
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

namespace Hangman
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      public MainWindow()
      {
         InitializeComponent();
      }

      /*********************************************************************/
      /*                          Play button                              */
      /*********************************************************************/
      private void Play_Button_Click(object sender, RoutedEventArgs e)
      {
         string        level_difficulty;
         EasyWindow    easy_window    = new EasyWindow();
         MediumWindow  medium_window  = new MediumWindow();
         HardWindow    hard_window    = new HardWindow();
         ExtremeWindow extreme_window = new ExtremeWindow();

         level_difficulty = Level_Difficulty_Label.Content.ToString();

         switch(level_difficulty)
         {
            case "EASY":
               easy_window.Show();
               this.Hide();
               break;
            case "MEDIUM":
               medium_window.Show();
               this.Hide();
               break;
            case "HARD":
               hard_window.Show();
               this.Hide();
               break;
            case "EXTREME":
               extreme_window.Show();
               this.Hide();
               break;
            default:
               MessageBox.Show("Error in difficulty", "Error");
               break;
            
         }
      }

      /*********************************************************************/
      /*                         Activate L character                      */
      /*********************************************************************/
      private void Play_Button_MouseEnter(object sender, MouseEventArgs e)
      {
         Play_L_Label.Visibility = Visibility.Visible;
      }

      /*********************************************************************/
      /*                       De-active L character                       */
      /*********************************************************************/
      private void Play_Button_MouseLeave(object sender, MouseEventArgs e)
      {
         Play_L_Label.Visibility = Visibility.Hidden;
      }

      /*********************************************************************/
      /*                         Slider movement                           */
      /*********************************************************************/
      private void Level_Difficulty_Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
      {
         int difficutly;
         
         difficutly = (int)Level_Difficulty_Slider.Value;

         switch(difficutly)
         {
            case 0:
               Level_Difficulty_Label.Content = "EASY";
               break;
            case 1:
               Level_Difficulty_Label.Content = "MEDIUM";
               break;
            case 2:
               Level_Difficulty_Label.Content = "HARD";
               break;
            case 3:
               Level_Difficulty_Label.Content = "EXTREME";
               break;
            default:
               Level_Difficulty_Label.Content = "ERROR";
               break;
         }
         return;
      }
   }
}
