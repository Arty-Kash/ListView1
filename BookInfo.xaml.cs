using Xamarin.Forms;
namespace ListView
{
    public partial class BookInfo : ContentPage
    {
        /* Book Information Page
                showing the tapped book information */
        public BookInfo(string[] TappedBook)
        {
            InitializeComponent();
            Label1.Text = TappedBook[0];
        }
    }
}
