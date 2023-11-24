using Entitites.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories;
  public class RepositoryContext : DbContext
  {
      public DbSet<Thesis> Thesis { get; set; }
      public DbSet<SubjectTopic> SubjectTopics { get; set; }
      public DbSet<Author> Authors { get; set; }
      public DbSet<ThesisAuthorship> ThesisAuthorship { get; set; }
      public DbSet<University> Universities { get; set; }
      public DbSet<Institute> Institutes { get; set; }
      public DbSet<ThesisSubjectTopic> ThesisSubjectTopics { get; set; }
      public DbSet<Keyword> Keyword { get; set; }
      public DbSet<Supervisor> Supervisor { get; set; }
      public DbSet<ThesisSupervision> ThesisSupervision { get; set; }
      public DbSet<ThesisType> ThesisType { get; set; }
    

    public RepositoryContext(DbContextOptions<RepositoryContext> options)
        : base(options)
      {
                  
      }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Thesis>()
            .ToTable("THESES");  // "Theses" tablosunu kullanacağımızı belirtiyoruz

        modelBuilder.Entity<SubjectTopic>()
            .ToTable("SUBJECT_TOPICS");  // "Subject_Topics" tablosunu kullanacağımızı belirtiyoruz

        modelBuilder.Entity<Author>()
            .ToTable("AUTHORS");  // "Authors" tablosunu kullanacağımızı belirtiyoruz
        modelBuilder.Entity<ThesisAuthorship>()
            .ToTable("THESIS_AUTHORSHIP")  // "Thesis_Authorship" tablosunu kullanacağımızı belirtiyoruz
            .HasKey(ta => new { ta.THESIS_NO, ta.AUTHOR_ID });
        modelBuilder.Entity<University>()
            .ToTable("UNIVERSITIES");  // "Universities" tablosunu kullanacağımızı belirtiyoruz
        modelBuilder.Entity<Institute>()
            .ToTable("INSTITUTES");  // "Institutes" tablosunu kullanacağımızı belirtiyoruz
        modelBuilder.Entity<ThesisSubjectTopic>()
            .ToTable("THESIS_SUBJECT_TOPICS")  // "Thesis_Subject_Topic" tablosunu kullanacağımızı belirtiyoruz
            .HasKey(tst => new { tst.THESIS_NO, tst.SUBJECT_TOPIC_ID });
        modelBuilder.Entity<Keyword>()
            .ToTable("KEYWORDS")  // "Keywords" tablosunu kullanacağımızı belirtiyoruz
            .HasKey(k => new { k.THESIS_NO, k.KEYWORD });
        modelBuilder.Entity<Supervisor>()
            .ToTable("SUPERVISORS");  // "Supervisors" tablosunu kullanacağımızı belirtiyoruz
        modelBuilder.Entity<ThesisSupervision>() 
            .ToTable("THESIS_SUPERVISION")  // "Thesis_Supervision" tablosunu kullanacağımızı belirtiyoruz
            .HasKey(ts => new { ts.THESIS_NO, ts.SUPERVISOR_ID });     
        modelBuilder.Entity<ThesisType>()
            .ToTable("THESIS_TYPE");  // "Thesis_Types" tablosunu kullanacağımızı belirtiyoruz       

        base.OnModelCreating(modelBuilder);
    }


}
