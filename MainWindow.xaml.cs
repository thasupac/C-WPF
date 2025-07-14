using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppASMT;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void btMachine_Click(object sender, RoutedEventArgs e)
    {
        Machine secondWindow = new Machine();
        secondWindow.Show();
        //this.Close();
    }

    private void btSpare_Click(object sender, RoutedEventArgs e)
    {
        Spare secondWindow = new Spare();
        secondWindow.Show();
    }

    private void btDowntime_Click(object sender, RoutedEventArgs e)
    {
        Downtime scondWindow = new Downtime();
        scondWindow.Show();

    }
}