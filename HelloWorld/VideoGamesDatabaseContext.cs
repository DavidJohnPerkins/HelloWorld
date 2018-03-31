using Microsoft.EntityFrameworkCore;

namespace HelloWorld
{
    /// <summary>
    /// This class handles the SQLite database.
    /// </summary>
    public class VideoGamesDatabaseContext : DbContext
    {
        /// <summary>
        /// This property allows the manipulation of the viedo games table
        /// </summary>
        public DbSet<VideoGame> VideoGames { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Specify the path of the database here
            optionsBuilder.UseSqlite("FileName=./videogames.sqlite");
        }
    }
}
