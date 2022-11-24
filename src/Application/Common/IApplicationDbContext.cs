using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Common;

public interface IApplicationDbContext
{
    public DbSet<Client> Client { get; }
    public DbSet<DrivingSchool> DrivingSchool { get; }
    public DbSet<DrivingSchoolReview> DrivingSchoolReview { get; }
    public DbSet<Exam> Exam { get; }
    public DbSet<Faq> Faq { get; }
    public DbSet<Instructor> Instructor { get; }
    public DbSet<InstructorReview> InstructorReview { get; }
}
