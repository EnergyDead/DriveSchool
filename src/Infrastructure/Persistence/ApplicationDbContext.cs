using Application.Common;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

public class ApplicationDbContext : DbContext, IApplicationDbContext 
{
    public DbSet<Client> Client => Set<Client>();
    public DbSet<DrivingSchool> DrivingSchool => Set<DrivingSchool>();
    public DbSet<DrivingSchoolReview> DrivingSchoolReview => Set<DrivingSchoolReview>();
    public DbSet<Exam> Exam => Set<Exam>();
    public DbSet<Faq> Faq => Set<Faq>();
    public DbSet<Instructor> Instructor => Set<Instructor>();
    public DbSet<InstructorReview> InstructorReview => Set<InstructorReview>();

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
    {
    }
}
