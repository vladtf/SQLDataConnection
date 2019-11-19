using System.Collections.Generic;
using System.Windows;

namespace MyCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Person> people = new List<Person>();

        public MainWindow()
        {
            InitializeComponent();

            UpdateBinding();
        }

        //update the list box
        private void UpdateBinding()
        {
            peopleFoundListBox.ItemsSource = people;
            peopleFoundListBox.DisplayMemberPath = "FullInfo";
        }

        //acces the database and shows it on a list box
        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            DataAcces db = new DataAcces();

            people = db.GetPeople(lastNameTextBox.Text);

            UpdateBinding();
        }
    }
}