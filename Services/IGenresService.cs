namespace movieAPI.Services
{
    public interface IGenresService
    {
        Task<IEnumerable<Genre>> GetAll();
        Task<Genre> GetByID(byte id);

        Task<Genre> Add(Genre genre);

        Genre Update(Genre genre);

        Genre Delete (Genre genre);

        Task<bool> IsvalidGenre(byte id);
    }
}
