using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Finance_Lord
{
  public partial class WindowImmobilien : Window
  {

    static int anzahl = 0;
    static int anzahl3zimmer = 0;
    static int anzahlvilla = 0;
    static int anzahlhotel = 0;
    static double value1zimmerplus;
    static int value1zimmer = 500;
    static double value3zimmerplus;
    static int value3zimmer = 2500;
    static double valuevillaplus;
    static int valuevilla = 5000;
    static double valuehotelplus;
    static int valuehotel = 10000;
    public static int budget = 1000000000;
    static int profit1 = 0;
    static int profit2 = 0;
    static int profit3 = 0;
    static int profit4 = 0;


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
      verdienstupdate();
    }
    private void verdienstupdate(){
      int gesamtprofit = profit1 + profit2 + profit3 + profit4;
      string profittext = "Verdienst: " + Convert.ToString(gesamtprofit) + "/sek";  
    verdiensttxt.Text = profittext;
    }
    private void WindowImmobilien_Loaded(object sender, RoutedEventArgs e)
    {
      price1zimmer.Text = "Preis: " + Convert.ToString(value1zimmer);
      price3zimmer.Text = "Preis: " + Convert.ToString(value3zimmer);
      priceVilla.Text = "Preis: " + Convert.ToString(valuevilla);
      pricehotel.Text = "Preis: " + Convert.ToString(valuehotel);
      updatenickname();
      updatecount() ;
      updatecount2();
      updatecount3();
      updatecount4();
    }

    public void moneyupdate()
    {
      budget = budget + profit1 + profit2 +profit3 +profit4;
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
        price1zimmer.Text = "Preis: " + Convert.ToString(value1zimmer);
        double profit12 = profit1 * 1.2;
        profit1 = Convert.ToInt32(profit12);
        updatecount();
      }
      if (anzahl == 1)
      {
        profit1 = 10;
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
        anzahl3zimmer += 1;
        budget -= value3zimmer;
        value3zimmerplus = value3zimmer * 1.2;
        value3zimmer = Convert.ToInt32(value3zimmerplus);
        price3zimmer.Text = "Preis: " + Convert.ToString(value3zimmer);
        double profit21 = profit2 * 1.2;
        profit2 = Convert.ToInt32(profit21);
        updatecount2();
      }
      if (anzahl3zimmer == 1)
      {
        profit2 = 50;
      }
    }
    private void updatecount2()
    {
      string anzahlzimmer3 = "Anzahl: " + anzahl3zimmer;
      count2.Text = anzahlzimmer3;
    }

    private void kaufenbtn3(object sender, RoutedEventArgs e)
    {
      if (budget >= valuevilla)
      {
        anzahlvilla += 1;
        budget -= valuevilla;
        valuevillaplus = valuevilla * 1.2;
        valuevilla = Convert.ToInt32(valuevillaplus);
        priceVilla.Text = "Preis: " + Convert.ToString(valuevilla);
        double profit31 = profit3 * 1.2;
        profit3 = Convert.ToInt32(profit31);
        updatecount3();
      }
      if (anzahlvilla == 1)
      {
        profit3 = 100;
      }

    }
    private void updatecount3()
    {
      string anzahlvilla1 = "Anzahl: " + anzahlvilla;
      count3.Text = anzahlvilla1;
    }

    private void kaufenbtn4(object sender, RoutedEventArgs e)
    {
      if (budget >= valuehotel)
      {
        anzahlhotel += 1;
        budget -= valuehotel;
        valuehotelplus = valuehotel * 1.2;
        valuehotel = Convert.ToInt32(valuehotelplus);
        pricehotel.Text = "Preis: " + Convert.ToString(valuehotel);
        double profit41 = profit4 * 1.2;
        profit4 = Convert.ToInt32(profit41);
        updatecount4();
      }
      if (anzahlhotel == 1)
      {
        profit4 = 250;
      }
    }
    private void updatecount4()
    {
      string anzahlhotel1 = "Anzahl: " + anzahlhotel;
      count4.Text = anzahlhotel1;
    }

    private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
    {

    }
  }
}