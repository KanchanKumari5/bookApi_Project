using BookStore_API.Models;
using Microsoft.AspNetCore.JsonPatch;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore_API.Repository
{
    public interface IBookRepository
    {
        Task<List<BookModel>> GetAllBookAsync();

        Task<BookModel> GetBookByIdAsync(int bookId);

        Task<int> AddBookAsync(BookModel bookModel);

        Task UpdateBookAsync(int bookId, BookModel bookModel);

        Task UpdateBookPatchAsync(int bookId, JsonPatchDocument bookModel);

        Task DeleteBookAsync(int bookId);
    }
}
