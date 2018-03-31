using System;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World vvvvv!");

            using (var context = new VideoGamesDatabaseContext())
            {
                // The line below clears and resets the database
                context.Database.EnsureDeleted();

                // Create the database if it doesn't exist
                context.Database.EnsureCreated();

                // Add some video games. 
                // Note that the Id field is autoincremented by default
                var SG = new VideoGame();
                SG.Title = "The Shawshank Redemption";
                SG.Platform = "DVD";
                context.VideoGames.Add(SG);

                var SG2 = new VideoGame();
                SG2.Title = "West Side Story";
                SG2.Platform = "CD";
                context.VideoGames.Add(SG2);

                context.SaveChanges();

                // Fetch all video games
                Console.WriteLine("Current database content");
                foreach (var videoGame in context.VideoGames.ToList())
                {
                    Console.WriteLine($"{videoGame.Title} - {videoGame.Platform}");
                }

            }
        }
    }
}
