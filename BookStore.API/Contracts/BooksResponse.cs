﻿namespace BookStore.API.Contracts;

public record BooksResponse(Guid id, string Title, string Description, string Price);