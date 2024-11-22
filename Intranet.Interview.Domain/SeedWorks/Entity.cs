namespace Mapper.GSB.Domain.SeedWorks;

public abstract class Entity
{
    protected private Entity()
    {

    }
    public Entity(DateTime? createDate)
    {
        CreatedDate = createDate ?? DateTime.Now;
        ModifiedDate = CreatedDate;
        RowVersion = null;
    }
    public DateTime CreatedDate { get; protected set; }
    public DateTime ModifiedDate { get; protected set; }
    public byte[]? RowVersion { get; private set; }
}
