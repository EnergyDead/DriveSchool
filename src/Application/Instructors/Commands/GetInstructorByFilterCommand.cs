using Application.Common;
using Application.Instructors.Queries;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Instructors.Commands;

public class GetInstructorByFilterCommand : IRequest<List<InstructorDto>>
{
    public string Name { get; init; }
}

public class GetInstructorByFilterHandler : IRequestHandler<GetInstructorByFilterCommand, List<InstructorDto>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetInstructorByFilterHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<InstructorDto>> Handle(GetInstructorByFilterCommand filter, CancellationToken cancellationToken)
    {
        return await _context.Instructor
            .Where(x => x.Name == filter.Name)
            .ProjectTo<InstructorDto>(_mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken: cancellationToken);
    }
}