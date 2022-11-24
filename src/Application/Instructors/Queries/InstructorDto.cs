using Application.Common.Mappings;
using Domain.Entities;

namespace Application.Instructors.Queries;

public class InstructorDto : IMapFrom<Instructor>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Phone { get; set; }
    public string PathToImage { get; set; }
}
