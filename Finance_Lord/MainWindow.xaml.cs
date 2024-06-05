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
using System.Windows.Threading;

namespace Finance_Lord
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    WindowImmobilien ObjwindowImmobilien = new WindowImmobilien();
    DispatcherTimer timer;
    public static string nickname;
    private static bool isNicknameEntered = false;


    public MainWindow()
    {
      
      InitializeComponent();
      this.Loaded += MainWindow_Loaded;
      
      timer = new DispatcherTimer();
      timer.Interval = TimeSpan.FromSeconds(1);
      timer.Tick += Timer_Tick;
      timer.Start();

      
    }

    private void MainWindow_Loaded(object sender, RoutedEventArgs e)
    {
      if (!isNicknameEntered)
      {
        NicknameWindow nicknameWindow = new NicknameWindow
        {
          Owner = this
        };

        if (nicknameWindow.ShowDialog() == true)
        {
          nickname = nicknameWindow.Nickname;
          isNicknameEntered = true;

        }
      }
      updatekonto();
      updatenickname();
    }
    public void updatenickname(){
    nicknametxt.Text=nickname;
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
      updatekonto();
    }
    public void updatekonto()
    {
      string budgettext = Convert.ToString(WindowImmobilien.budget);
      konto.Text = "Konto: " + budgettext;

    }

    private void Btn_x_Click(object sender, RoutedEventArgs e)
    {

    }

    private void BtnImbclick(object sender, RoutedEventArgs e)
    {
      
      this.Visibility = Visibility.Hidden;
      ObjwindowImmobilien.Show();
    }

    private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
    {

        }

    private void Btn_auktion_Click(object sender, RoutedEventArgs e)
    {

    }

    private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
    {

    }
  }
}
