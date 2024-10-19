using Helper.Model.MainModel;
using Microsoft.EntityFrameworkCore;

namespace Helper.Model.Data
{
    public class ApplicationContex : DbContext
    {
        public DbSet<RecordModel> Records { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlite("DataSource=database.db");
        }
    }
}
