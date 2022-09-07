using PRO.SharedKernel.Domain.Membership.AccountDomain;
using PRO.SharedKernel.Infrastructure.DbProvider.EFCore.Aggregates;

namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

public partial class EstimateCategory : Entity<Guid>, ITenant
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

    #region Constructor
    public EstimateCategory() { }
    public EstimateCategory(
        string? name,
        byte? sequence,
        Guid? estimateId,
        Guid? estimateTemplateId) : this()
    {
        this.Name = name;
        this.Sequence = sequence;
        this.EstimateId = estimateId;
        this.EstimateTemplateId = estimateTemplateId;
    }
    #endregion

    #region Public Methods
 
    public void Update(
    string? name,
    byte? sequence)
    {
        this.Name = name;
        this.Sequence = sequence;
    }

    public void UpdateName(
        string? name)
    {
        this.Name = name;
    }

    public void UpdateSequence(
        byte? sequence
        )
    {
        this.Sequence = sequence;
    }

    #endregion
     
}
