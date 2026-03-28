namespace MyLibraryProject.Model
{
    public interface IGetBooks
    {
        IEnumerable<Book> GetBooks(BookDbContext bookDbContext);
    }
}
