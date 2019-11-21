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

        private void insertButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Insert_Action();
        }

        private void DeleteButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            DataAcces db = new DataAcces();

            db.DeletPerson(idTextBox.Text);

            firstNameTextBox.Text = lastNameTextBox.Text = idTextBox.Text = "";
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                Insert_Action();
        }
        private void Insert_Action()
        {
            DataAcces db = new DataAcces();

            db.InsertPerson(firstNameTextBox.Text, lastNameTextBox.Text, idTextBox.Text);

            firstNameTextBox.Text = lastNameTextBox.Text = idTextBox.Text = "";
        }
    }
}