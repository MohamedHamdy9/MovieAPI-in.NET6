using Microsoft.EntityFrameworkCore;

namespace movieAPI.Services
{
    public class MoviesService : IMoviesService
    {
        private readonly ApplicationDbContext _context ;
        public MoviesService(ApplicationDbContext context)
        {
            _context = context;

        }
        public async Task<Movie> Add(Movie movie)
        {
            await _context.Movies.AddAsync(movie);
            _context.SaveChanges();
            return movie;
        }

        public Movie Delete(Movie movie)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();
            return movie;
        }

        public  async Task<Movie> GetByID(int id)
        {
            return await _context.Movies.Include(m => m.Genre).SingleOrDefaultAsync(movie => movie.Id == id);
        }

        public async Task<IEnumerable<Movie>> GetMoviesAsync(byte genreId = 0)
        {
            return await _context.Movies
                .Where(m => m.GenreId == genreId || genreId == 0)
                .OrderByDescending(m => m.Rate)
                .Include(m => m.Genre)
                .ToListAsync();
        }

        public Movie Update(Movie movie)
        {
            _context.Movies.Update(movie);
            _context.SaveChanges();
            return movie;
        }
    }
}
