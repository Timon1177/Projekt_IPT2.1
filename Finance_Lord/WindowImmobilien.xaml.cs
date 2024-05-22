using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Finance_Lord
{
  public partial class WindowImmobilien : Window
  {

    static int anzahl = 0;
    static double value1zimmerplus;
    static int value1zimmer=500;
    static double value3zimmerplus;
    static int value3zimmer = 2500;
    public static int budget = 1000;
    static int profit = 0;

    DispatcherTimer timer;

    public WindowImmobilien()
    {
      InitializeComponent();
      updatecount();


      timer = new DispatcherTimer();
      timer.Interval = TimeSpan.FromSeconds(1);
      timer.Tick += Timer_Tick;
      timer.Start();
      
      this.Loaded += WindowImmobilien_Loaded;
    }
    public void updatenickname()
    {
      nicknametxt.Text = MainWindow.nickname;
    }
    private void Timer_Tick(object sender, EventArgs e)
    {

      moneyupdate();
    }
    private void WindowImmobilien_Loaded(object sender, RoutedEventArgs e){
      price1zimmer.Text = "Preis: " + Convert.ToString(value1zimmer);
      price3zimmer.Text = "Preis: " + Convert.ToString(value3zimmer);
      updatenickname();
    }

    public void moneyupdate()
    {
      budget = budget + profit;
      updatekonto();
    }


    private void BtnBack(object sender, RoutedEventArgs e)
    {
      MainWindow ObjMainWindow = new MainWindow();
      ObjMainWindow.Show();
      this.Hide();
    }

    public void updatekonto()
    {
      string budgettext = Convert.ToString(budget);
      konto.Text = "Konto: " + budgettext;
      
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
      
      if (budget >= value1zimmer)
      {
        anzahl += 1;
        budget -= value1zimmer;
        value1zimmerplus = value1zimmer * 1.2;
        value1zimmer = Convert.ToInt32(value1zimmerplus);
        price1zimmer.Text = "Preis: "+Convert.ToString(value1zimmer);
        double profit1 = profit * 1.2;
        profit = Convert.ToInt32(profit1);
        updatecount();
      }
      if (anzahl == 1)
      {
        profit = 10;
      }
    }

    private void updatecount()
    {
      string anzahlzimmer1 = "Anzahl: " + anzahl;
      count.Text = anzahlzimmer1;
    }

    private void kaufenbtn2(object sender, RoutedEventArgs e)
    {
      if (budget >= value3zimmer)
      {
        anzahl += 1;
        budget -= value3zimmer;
        value3zimmerplus = value3zimmer * 1.2;
        value3zimmer = Convert.ToInt32(value3zimmerplus);
        price3zimmer.Text = "Preis: " + Convert.ToString(value3zimmer);
        double profit1 = profit * 1.2;
        profit = Convert.ToInt32(profit1);
        updatecount2();
      }
      if (anzahl == 1)
      {
        profit = 10;
      }
    }
    private void updatecount2()
    {
      string anzahlzimmer3 = "Anzahl: " + anzahl;
      count2.Text = anzahlzimmer3;
    }
  }
}
