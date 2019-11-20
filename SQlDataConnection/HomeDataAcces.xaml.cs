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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyCalc
{
    /// <summary>
    /// Interaction logic for HomeDataAcces.xaml
    /// </summary>
    public partial class HomeDataAcces : Page
    {
        private List<Person> people = new List<Person>();
        private MainWindow parentWindow;
        public HomeDataAcces(MainWindow window)
        {
            InitializeComponent();

            UpdateBinding();

            parentWindow = window;
        }

        //update the list box
        private void UpdateBinding()
        {
            peopleFoundListBox.ItemsSource = people;
            peopleFoundListBox.DisplayMemberPath = "FullInfo";
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            Search_Action();
        }

        //acces the database and shows it on a list box
        private void Search_Action()
        {
            DataAcces db = new DataAcces();

            people = db.GetPeople(lastNameTextBox.Text);

            UpdateBinding();
        }

        private void enterButton_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                Search_Action();
        }

        private void InsertPage_Click(object sender, RoutedEventArgs e)
        {
            InsertPage insertPage = new InsertPage(parentWindow);
            parentWindow.Content = insertPage;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                parentWindow.DragMove();
        }

        private void backButton_Copy_Click(object sender, RoutedEventArgs e)
        {
            parentWindow.Close();
        }
    }
    
}