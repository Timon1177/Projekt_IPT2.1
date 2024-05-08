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

namespace Finance_Lord
{
    /// <summary>
    /// Interaktionslogik für WindowImmobilien.xaml
    /// </summary>
    public partial class WindowImmobilien : Window
    {
    static int anzahl = 0;
    static double value1zimmerplus;
    static int value1zimmer;
    static int budget;

    public WindowImmobilien()
        {
            InitializeComponent();
            updatecount();
        }

    private void BtnBack(object sender, RoutedEventArgs e)
    {
      MainWindow ObjMainWindow = new MainWindow();
      this.Visibility = Visibility.Hidden;
      ObjMainWindow.Show();
    }

    private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
    {

    }

    private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
    {

    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      if (budget>=value1zimmer){
        anzahl += 1;
        budget -= value1zimmer;
        value1zimmerplus = value1zimmer * 1.2;
        value1zimmer = Convert.ToInt32(value1zimmerplus);
        updatecount();
      }
    }
    private void updatecount(){
      string anzahlzimmer1 = "Anzahl: " + anzahl;
      count.Text = anzahlzimmer1;
    }
  }
}
