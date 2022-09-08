namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

public partial class EstimateCategory : Entity<Guid>
{

    #region Properties
    public string? Name { get; set; }
    public byte? Sequence { get; set; }


    public Guid? EstimateId { get; set; }
    public virtual Estimate? Estimate { get; set; }
    public Guid? EstimateTemplateId { get; set; }
    public virtual EstimateTemplate? EstimateTemplate { get; set; }

    public Guid AccountId { get; set; }
    public virtual Account Account { get; set; } = null!;
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;
    #endregion 
     
}
