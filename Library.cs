namespace LibraryApp
{
    public class Library : ILibrary
    {
        public int MaxCheckoutDays { get; set; } = 14;
        public List<IBook> Books { get; set; } = new List<IBook>();
        public void AddBook(IBook book)
        {
            Books.Add(book);
        }
        public void ReturnBook(double isbn)
        {
            var book = Books.Find(e => e.ISBN == isbn);
            if (book == null)
            {
                throw new Exception("No book found");
            }
            book.ReturnCopies();


        }
        public void CheckoutBook(double isbn)
        {
            var book = Books.Find(e => e.ISBN == isbn);
            if (book == null)
            {
                throw new Exception("No book found");
            }

            book.CheckoutCopies();
        }

    }
}

