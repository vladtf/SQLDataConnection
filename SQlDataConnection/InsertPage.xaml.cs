using System.Windows.Controls;
using System.Windows.Input;
namespace MyCalc
{
    /// <summary>
    /// Interaction logic for InsertPage.xaml
    /// </summary>
    public partial class InsertPage : Page
    {
        MainWindow parentWindow;
        public InsertPage(MainWindow mainWindow)
        {
            InitializeComponent();

            parentWindow = mainWindow;
        }

        private void backButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            HomeDataAcces homeDataAcces = new HomeDataAcces(parentWindow);
            parentWindow.Content = homeDataAcces;
        }

        private void Grid_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                parentWindow.DragMove();
        }

        private void backButton_Copy_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            parentWindow.Close();
        }
    }
}