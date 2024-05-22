using System.Windows;

namespace Finance_Lord
{
  public partial class NicknameWindow : Window
  {
    public string Nickname { get; private set; }

    public NicknameWindow()
    {
      InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      Nickname = NicknameTextBox.Text;
      this.DialogResult = true; 
    }
  }
}
