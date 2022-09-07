using PRO.SharedKernel.Infrastructure.DbProvider.EFCore.Aggregates;

namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

public partial class EstimateTemplateCategory : Entity<Guid>
{
    #region Properties
    public string? Name { get; set; }
    public virtual ICollection<EstimateTemplate> EstimateTemplates { get; set; } = null!;
    public virtual ICollection<EstimateTemplateCategoryAccount> EstimateTemplateCategoryAccounts { get; set; } = null!;
    #endregion

    #region Constructor 
    public EstimateTemplateCategory()
    {
        this.EstimateTemplates = new HashSet<EstimateTemplate>();
        this.EstimateTemplateCategoryAccounts = new HashSet<EstimateTemplateCategoryAccount>();
    }

    public EstimateTemplateCategory(
        string? name,
        IEnumerable<EstimateTemplate>? estimateTemplates = null,
        IEnumerable<EstimateTemplateCategoryAccount>? estimateTemplateCategorieAccounts = null
        ) : this()
    {
        this.Name = name;
        this.EstimateTemplates.AddRange(estimateTemplates);
        this.EstimateTemplateCategoryAccounts.AddRange(estimateTemplateCategorieAccounts);
    }
    #endregion

    #region Public Methods
    public void Update(
        string? name
        )
    {
        this.Name = name;
    }
    #endregion

}
