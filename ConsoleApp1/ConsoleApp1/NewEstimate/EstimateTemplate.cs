using PRO.SharedKernel.Domain.Membership.AccountDomain;
using PRO.SharedKernel.Infrastructure.DbProvider.EFCore.Aggregates;

namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

public partial class EstimateTemplate : Entity<Guid>, ITenant
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

    #region Constructor
    public EstimateTemplate()
    {
        this.EstimateCategories = new HashSet<EstimateCategory>();
    }

    //TODO: Done -> Neden komple account veriyoruz burda. AccountID bile gereksiz. ITenant isimizi gorecek zaten. 
    public EstimateTemplate(
        string? name,
        bool? enabled,
        Guid? estimateTemplateCategoryId,
        IEnumerable<EstimateCategory>? estimateCategories = null
        ) : this()
    {
        this.Name = name;
        this.Enabled = enabled;
        this.EstimateCategories.AddRange(estimateCategories);
        this.EstimateTemplateCategoryId = estimateTemplateCategoryId;
    }
    #endregion

    #region Public Methods
    //TODO: Done -> sadece name ve enabled yeterli
    public void Update(
        string? name,
        bool? enabled
        )
    {
        this.Name = name;
        this.Enabled = enabled;
    }
    #endregion 
}
