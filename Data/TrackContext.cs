using DT191G___Moment_3._3.Models;
using Microsoft.EntityFrameworkCore;

namespace DT191G___Moment_3._3.Data
{
    public class TrackContext : DbContext
    {
        public TrackContext(DbContextOptions<TrackContext> options) : base(options)
        {

        }

        public DbSet<Track> Tracks { get; set; }
    }
}
