namespace MyLibraryProject.Model
{
    public class Book
    {
        private string _title=string.Empty;
        private string _description =string.Empty;
        public int Id { get; set; }
        public string Title
        {
            get =>_title;
            set   
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Title cannot be null or empty.");
                }
                if(value.Length > 40)
                {
                    throw new ArgumentException("Title cannot be longer than 40 characters.");
                }
                _title = value;
            }
        }
        public string Description
        {
            get => _description;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Description cannot be null or empty.");
                }
                if (value.Length > 80)
                {
                    throw new ArgumentException("Description cannot be longer than 80 characters.");
                }
                _description = value;
            }
        }

    }
}
