namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

public class Entity<TPrimaryKey> : Entity, IEntity<TPrimaryKey>
{
    public virtual TPrimaryKey Id { get; set; }


    public Entity() : base()
    {

    }
    public Entity(TPrimaryKey id) : this()
    {
        this.Id = id;
    }
}
public interface IEntity
{
}

public interface IEntity<TPrimaryKey> : IEntity
{
    public TPrimaryKey Id { get; set; }
}