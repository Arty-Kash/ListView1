using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
namespace ListView
{
    public partial class MainPage : ContentPage
    {
        /* Create a book list data "books" as a dynamic data collection
           that provides notifications when a book get added */
        public static ObservableCollection<string> books { get; set; }
        public MainPage()
        {
            /* Create a new book list instance "books"
                            and set the initialize data */
            books = new ObservableCollection<string>()
            { 
                "Killing Floor (Lee Child)", 
                "Man On Fire (A.J.Quinnell)", 
                "The Lion's Game (Nelson DeMille)"
            };

            InitializeComponent();
            /* Bind the book list data "books" to
                 the ListView control "BookListView" */
            BookListView.ItemsSource = books;
        }

        /* Insert the new book to the book list */
        void OnNewBook(object sender, EventArgs e)
        {
            books.Insert(0, Entry1.Text);
        }

        /* If one of the books was tapped, move to the Book Information
           page "BookInfo" with the tapped book information */
        async void OnTap(object sender, ItemTappedEventArgs e)
        {
            string[] TappedBook = { e.Item.ToString() };
            await Navigation.PushAsync(new BookInfo(TappedBook));
        }
    }
}
