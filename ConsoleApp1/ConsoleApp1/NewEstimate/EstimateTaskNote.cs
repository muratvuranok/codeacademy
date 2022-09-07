using PRO.SharedKernel.Domain.Membership.AccountDomain;
using PRO.SharedKernel.Infrastructure.DbProvider.EFCore.Aggregates;

namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

public partial class EstimateTaskNote : Entity<Guid>, ITenant
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

    #region Constructor
    public EstimateTaskNote() { }
    //TODO: Done -> EstimateId zorunlu
    public EstimateTaskNote(
        string? note,
        byte? sequence,
        Guid estimateTaskId
        ) : this()
    {
        this.Note = note;
        this.Sequence = sequence;
        this.EstimateTaskId = estimateTaskId;
    }

    #endregion

    #region Public Methods
    public void Update(
     string? note,
     byte? sequence)
    {
        this.Note = note;
        this.Sequence = sequence;
    }
    #endregion
 
}
