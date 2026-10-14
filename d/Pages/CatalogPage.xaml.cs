using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using d.Windows;

namespace d.Pages
{
    /// <summary>
    /// Логика взаимодействия для CatalogPage.xaml
    /// </summary>
    public partial class CatalogPage : Page
    {
        ObservableCollection<Book> books = new ObservableCollection<Book>();

        public CatalogPage()
        {
            InitializeComponent();

            books.Add(new Book { Title = "Мастер и Маргарита", Author = "М. Булгаков", Year = 1967 });
            books.Add(new Book { Title = "Три товарища", Author = "Э.М. Ремарк", Year = 1936 });
            books.Add(new Book { Title = "Пикник на обочине", Author = "Стругацкие", Year = 1972 });

            listBooks.ItemsSource = books;

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddBookWindow w = new AddBookWindow();
            w.ShowDialog();
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}