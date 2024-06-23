using BookStore.API.Contracts;
using BookStore.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.API.Controllers;

[ApiController]
[Route("[controller]")]
public class BooksController : ControllerBase
{
    public BooksController(IBooksService booksService)
    {
        this._booksService = booksService;
    }

    private readonly IBooksService _booksService;

    [HttpGet]
    public async Task<ActionResult<List<BooksResponse>>> GetBooks()
    {
        var books = await _booksService.GetAllBooks();

        var response = books.Select(b => new BooksResponse(b.Id, b.Title, b.Description, b.Description));

        return Ok(response);
    }
}