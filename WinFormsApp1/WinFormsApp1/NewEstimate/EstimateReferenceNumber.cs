namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

public partial class EstimateReferenceNumber : Entity<Guid>
{
    #region Properties
    public string? ReferencePrefix { get; set; }
    public byte NumberLength { get; set; }
    public int? LastNumber { get; set; }
    public string? ReferenceSuffix { get; set; }

    public Guid AccountId { get; set; }
    public virtual Account Account { get; set; } = null!;
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;
    #endregion
     
}
