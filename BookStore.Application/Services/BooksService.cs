using BookStore.Core.Abstractions;
using BookStore.Core.Models;

namespace BookStore.Application.Services;

public class BooksService : IBooksService
{
    public BooksService(IBooksRepository booksRepository)
    {
        this._booksRepository = booksRepository;
    }

    private readonly IBooksRepository _booksRepository;

    public async Task<List<Book>> GetAllBooks()
    {
        return await _booksRepository.Get();
    }

    public async Task<Guid> CreateBook(Book book)
    {
        return await _booksRepository.Create(book);
    }

    public async Task<Guid> UpdateBook(Guid id, string title, string description, decimal price)
    {
        return await _booksRepository.Update(id, title, description, price);
    }

    public async Task<Guid> DeleteProduct(Guid id)
    {
        return await _booksRepository.Delete(id);
    }
}