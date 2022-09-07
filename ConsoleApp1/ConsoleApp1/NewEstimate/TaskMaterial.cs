using PRO.SharedKernel.Infrastructure.DbProvider.EFCore.Aggregates;

namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

public partial class TaskMaterial : Entity<Guid>
{ 
    #region Properties
    public Guid? MaterialLibraryId { get; set; }
    public virtual MaterialLibrary? MaterialLibrary { get; set; }

    public Guid? TaskLibraryId { get; set; }
    public virtual TaskLibrary? TaskLibrary { get; set; }
    #endregion

    #region Constructor
    public TaskMaterial() { }
    public TaskMaterial(
        Guid? taskLibraryId,
        Guid? materialLibraryId
        ) : this()
    {
        this.TaskLibraryId = taskLibraryId;
        this.MaterialLibraryId = materialLibraryId;
    }
    #endregion 
}
