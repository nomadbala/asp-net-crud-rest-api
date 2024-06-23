namespace BookStore.Core.Models;

public class Book
{
    public const int MAX_TITLE_LENGTH = 250;
    
    private Book(Guid id, string title, string description, decimal price)
    {
        this.Id = id;
        this.Title = title;
        this.Description = description;
        this.Price = price;
    }
    
    public Guid Id { get; }

    public string Title { get; }

    public string Description { get; }

    public decimal Price { get; }

    public static (Book book, string Error) CreateInstance(Guid id, string title, string description, decimal price)
    {
        string error = string.Empty;

        if (string.IsNullOrEmpty(title) || title.Length > MAX_TITLE_LENGTH)
        {
            error = $"Title can not be empty or longer than ${MAX_TITLE_LENGTH} symbols";
        }
        
        Book book = new Book(id, title, description, price);

        return (book, error);
    }
}