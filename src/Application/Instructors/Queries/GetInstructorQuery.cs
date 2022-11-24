using Application.Common;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Instructors.Queries;

public class GetInstructorQuery : IRequest<InstructorDto>
{
    public int Id { get; init; }
}

public class GetInstructorQueryHandler : IRequestHandler<GetInstructorQuery, InstructorDto>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetInstructorQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<InstructorDto> Handle(GetInstructorQuery request, CancellationToken cancellationToken)
    {
        return await _context.Instructor
            .Where(x => x.Id == request.Id)
            .ProjectTo<InstructorDto>(_mapper.ConfigurationProvider)
            .FirstOrDefaultAsync(cancellationToken: cancellationToken);
    }
}
