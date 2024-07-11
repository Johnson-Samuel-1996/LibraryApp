namespace LibraryApp
{
    public interface IBook
    {
        string? Author { get; set; }
        int AvailableCopies { get; set; }
        double ISBN { get; set; }
        int PublicationYear { get; set; }
        string? Title { get; set; }

        void CheckoutCopies();
        void ReturnCopies();
        string ToString();
    }
}