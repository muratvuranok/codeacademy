using PRO.SharedKernel.Domain.Membership.AccountDomain;
using PRO.SharedKernel.Infrastructure.DbProvider.EFCore.Aggregates;

namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

//TODO: Done - category yanlis yazilmis
public partial class EstimateTemplateCategoryAccount : Entity<Guid>, ITenant
{
    #region Properties
    //TODO: Done -> hepsi zorunlu 
    public Guid AccountId { get; set; }
    public virtual Account Account { get; set; } = null!;

    public Guid UserId { get; set; }
    public virtual User User { get; set; } = null!;

    public Guid EstimateTemplateCategoryId { get; set; }
    public virtual EstimateTemplateCategory EstimateTemplateCategory { get; set; } = null!;
    #endregion

    #region Constructor
    public EstimateTemplateCategoryAccount() { }
    public EstimateTemplateCategoryAccount(
        Guid accountId,
        Guid estimateTemplateCategoryId
        ) : this()
    {
        this.AccountId = accountId;
        this.EstimateTemplateCategoryId = estimateTemplateCategoryId;
    }
    #endregion 
}
