namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;
public partial class EstimateTaskNote : Entity<Guid>
{ 
    #region Properties
    public string? Note { get; set; }
    public byte? Sequence { get; set; }

    public Guid AccountId { get; set; }
    public virtual Account Account { get; set; } = null!;
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;
    public Guid  EstimateTaskId { get; set; }
    public virtual EstimateTask  EstimateTask { get; set; } = null!;
    #endregion
     
}
