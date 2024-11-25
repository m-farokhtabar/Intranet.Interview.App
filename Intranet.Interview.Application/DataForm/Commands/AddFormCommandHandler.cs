using Intranet.Interview.Domain.DataForm;
using Mapper.GSB.Domain.SeedWork;
using MediatR;

namespace Intranet.Interview.Application.DataForm.Commands;

internal class AddFormCommandHandler : IRequestHandler<AddFormCommand>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IFormDataRepository repository;

    public AddFormCommandHandler(IUnitOfWork unitOfWork, IFormDataRepository repository)
    {
        this.unitOfWork = unitOfWork;
        this.repository = repository;
    }
    public async Task Handle(AddFormCommand request, CancellationToken cancellationToken)
    {
        if (request is null)
            throw new Exception();        
        FormData entity = new(request.JsonData);
        await repository.AddAsync(entity).ConfigureAwait(false);
        await unitOfWork.CommitAsync(cancellationToken).ConfigureAwait(false);
    }
}