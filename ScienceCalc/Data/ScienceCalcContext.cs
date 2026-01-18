using Microsoft.EntityFrameworkCore;

namespace ScienceCalc.Data
{
    public class ScienceCalcContext : DbContext
    {
        public DbSet<Article>

        public ScienceCalcContext(DbContextOptions<ScienceCalcContext> options) : base(options)
        {

        }
    }
}
