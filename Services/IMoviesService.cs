namespace movieAPI.Services
{
    public interface IMoviesService
    {
        Task<IEnumerable<Movie>> GetMoviesAsync(byte genreId = 0);
        Task<Movie> GetByID(int id);

        Task<Movie> Add(Movie movie);

        Movie Update(Movie movie);

        Movie Delete (Movie movie);
    }
}
