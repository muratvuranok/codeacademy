using PRO.SharedKernel.Domain.Application.ResourceCenterDomain;
using PRO.SharedKernel.Infrastructure.DbProvider.EFCore.Aggregates;

namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

public partial class EstimateTaskPhoto : Entity<Guid>
{

    #region Properties
    public Guid? ResourceFileId { get; set; }
    public ResourceFile? ResourceFile { get; set; }
    public Guid? EstimateTaskId { get; set; }
    public virtual EstimateTask? EstimateTask { get; set; }
    #endregion

    #region Constructor
    public EstimateTaskPhoto() { }
    public EstimateTaskPhoto(
        Guid? estimateTaskId,
        Guid? resourceFileId
        ) : this()
    {
        this.EstimateTaskId = estimateTaskId;
        this.ResourceFileId = resourceFileId;
    }

    //TODO: Done -> buna update yok hocam. gerekmiyor.  ( silindi )
    #endregion 
}
