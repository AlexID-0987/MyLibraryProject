namespace MyLibraryProject.Model
{
    public class RepoBooks: IGetBooks
    {
        public IEnumerable<Book> GetBooks(BookDbContext bookDbContext)
        {
            return bookDbContext.Books.ToList();
        }
    }
}
