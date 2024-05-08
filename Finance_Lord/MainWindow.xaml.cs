using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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

namespace Finance_Lord
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
    
    

    private void Btn_x_Click(object sender, RoutedEventArgs e)
    {

    }

    private void BtnImbclick(object sender, RoutedEventArgs e)
    {
      WindowImmobilien ObjwindowImmobilien= new WindowImmobilien();
      this.Visibility = Visibility.Hidden;
      ObjwindowImmobilien.Show();
    }

    private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
    {

        }
    }
}
