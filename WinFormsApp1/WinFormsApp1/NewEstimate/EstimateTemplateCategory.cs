

namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;
public partial class EstimateTemplateCategory : Entity<Guid>
{
    #region Properties
    public string? Name { get; set; }
    public virtual ICollection<EstimateTemplate> EstimateTemplates { get; set; } = null!;
    public virtual ICollection<EstimateTemplateCategoryAccount> EstimateTemplateCategoryAccounts { get; set; } = null!;
    #endregion
     

}
