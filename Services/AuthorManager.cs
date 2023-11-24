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
        public IEnumerable<Author> GetAllAuthors(bool trackChanges)
        {
            return _manager.Author.FindAll(trackChanges);
        }

        public Author? GetOneAuthor(int id, bool trackChanges)
        {
            return _manager.Author.GetOneAuthor(id, trackChanges);
        }
    }
}
