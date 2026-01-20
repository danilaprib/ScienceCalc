using Microsoft.EntityFrameworkCore;

namespace ScienceCalc.Data
{
    public class ScienceCalcContext : DbContext
    {
        public DbSet<Article> articles { get; set; }
        public DbSet<Subject> subjects { get; set; }
        public DbSet<ArticleToSubjectBridge> articles_to_subjects_bridges { get; set; }
        public ScienceCalcContext(DbContextOptions<ScienceCalcContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ArticleToSubjectBridge>()
                .HasKey(x => new { x.article_id, x.subject_id});

            modelBuilder.Entity<ArticleToSubjectBridge>()
                .HasOne(a => a.article)
                .WithMany(a => a.ArticleToSubjectBridges)
                .HasForeignKey(a => a.article_id);

            modelBuilder.Entity<ArticleToSubjectBridge>()
                .HasOne(s => s.subject)
                .WithMany(s => s.ArticleToSubjectBridges)
                .HasForeignKey(s => s.subject_id);
        }
    }
}
