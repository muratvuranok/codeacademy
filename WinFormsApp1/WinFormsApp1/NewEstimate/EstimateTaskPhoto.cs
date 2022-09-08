namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;
public partial class EstimateTaskPhoto : Entity<Guid>
{ 
    #region Properties
    public Guid? ResourceFileId { get; set; }
    public ResourceFile? ResourceFile { get; set; }
    public Guid? EstimateTaskId { get; set; }
    public virtual EstimateTask? EstimateTask { get; set; }
    #endregion 
}
