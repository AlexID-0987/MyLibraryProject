namespace MyLibraryProject.Model
{
    public static class DataBaseInit
    {
        public static void Initialize(BookDbContext context)
        {
            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book { Title = "Clean Code", Description = "Arhitecture, Clean Code, Patternes, Solid" },
                    new Book { Title = "ASP Net Core Application", Description = "Introduction ASP NET" },
                    new Book { Title = "C#", Description = "Introduction C#" }
                );
                context.SaveChanges();
            }
        }
    }
}
