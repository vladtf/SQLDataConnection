using System.Windows.Navigation;
using System.Windows;
namespace MyCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            HomeDataAcces homeDataAcces = new HomeDataAcces(this);
            this.Content = homeDataAcces;
        }
    }
}