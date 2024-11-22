using Intranet.Interview.Domain.DataForm;
using Mapper.GSB.Domain.SeedWork;
using MediatR;
using static Intranet.Interview.Application.DataForm.Helper.MapToDomain;

namespace Intranet.Interview.Application.DataForm.Commands;

internal class AddPersonCommandHandler : IRequestHandler<AddPersonCommand>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IPersonRepository personRepository;

    public AddPersonCommandHandler(IUnitOfWork unitOfWork, IPersonRepository personRepository)
    {
        this.unitOfWork = unitOfWork;
        this.personRepository = personRepository;
    }
    public async Task Handle(AddPersonCommand request, CancellationToken cancellationToken)
    {
        if (request is null)
            throw new Exception();
        var industry = MapToIndustryType(request.Industry);
        Person person = new(request.Name, request.Email, request.Age, industry, request.SubscribeToNewsletter);
        await personRepository.AddAsync(person).ConfigureAwait(false);
        await unitOfWork.CommitAsync(cancellationToken).ConfigureAwait(false);
    }
}