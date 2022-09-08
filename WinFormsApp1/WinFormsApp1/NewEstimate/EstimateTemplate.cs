namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

public partial class EstimateTemplate : Entity<Guid>
{

    #region Properties 
    public string? Name { get; set; }
    public bool? Enabled { get; set; }
    public Guid AccountId { get; set; }
    public virtual Account Account { get; set; } = null!;
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    public Guid? EstimateTemplateCategoryId { get; set; }
    public virtual EstimateTemplateCategory? EstimateTemplateCategory { get; set; } = null!;

    public virtual ICollection<EstimateCategory> EstimateCategories { get; set; }
    #endregion
     
}
