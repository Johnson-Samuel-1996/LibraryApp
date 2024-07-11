
namespace LibraryApp
{
    public interface ILibrary
    {
        List<IBook> Books { get; set; }
        int MaxCheckoutDays { get; set; }

        void AddBook(IBook book);
        void CheckoutBook(double isbn);
        void ReturnBook(double isbn);
    }
}