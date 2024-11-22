using System.Collections.Immutable;

namespace Mapper.GSB.Domain.SeedWorks;

public abstract class AggregateRoot : Entity
{
    private protected AggregateRoot()
    {

    }
    protected AggregateRoot(DateTime? createDate, Guid id, int version) : base(createDate)
    {
        Id = id;
        Version = version;
    }
    public Guid Id { get; protected set; }
    public int Version { get; protected set; }
}
