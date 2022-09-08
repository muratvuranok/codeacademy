

namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

public partial class TaskMaterial : Entity<Guid>
{ 
    #region Properties
    public Guid? MaterialLibraryId { get; set; }
    public virtual MaterialLibrary? MaterialLibrary { get; set; }

    public Guid? TaskLibraryId { get; set; }
    public virtual TaskLibrary? TaskLibrary { get; set; }
    #endregion
     
}
