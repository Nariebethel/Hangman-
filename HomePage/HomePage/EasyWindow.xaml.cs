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

      public EasyWindow()
      {
         InitializeComponent();
         Random random = new Random();
         random_number = random.Next(1, 10);
      }

      private void Main_word()
      {
         
      }

   }
}
