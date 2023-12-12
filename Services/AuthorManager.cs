using Entitites.Models;
using Repositories.Contracts;
using Services.Contracts;


namespace Services
{
    public class AuthorManager : IAuthorService
    {
        private readonly IRepositoryManager _manager;

        public AuthorManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public void CreateAuthor(Author author)
        {
            _manager.Author.Create(author);
            _manager.Save();
        }

        public IEnumerable<Author> GetAllAuthors(bool trackChanges)
        {
            return _manager.Author.FindAll(trackChanges);
        }

        public Author? GetAuthorByAspNetUserId(string id, bool trackChanges)
        {
            return _manager.Author.GetAuthorByAspNetUserId(id, trackChanges);
        }

        public Author? GetOneAuthor(int id, bool trackChanges)
        {
            return _manager.Author.GetOneAuthor(id, trackChanges);
        }
    }
}
