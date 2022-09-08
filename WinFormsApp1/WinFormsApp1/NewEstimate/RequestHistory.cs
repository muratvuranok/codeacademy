using PRO.SharedKernel.Domain.Application.NewEstimate;
using PRO.SharedKernel.Domain.Application.NewEstimate.Enums;


namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;
public partial class RequestHistory : Entity<Guid>
{
    #region Properties 
    public Guid? RequestedBy { get; set; }

    public DateTime? ViewedDate { get; set; }
    public DateTime? RequestDate { get; set; }
    public DateTime? ResolvedDate { get; set; }


    public Guid? EmailLogId { get; set; }
    public EmailLog? EmailLog { get; set; }
    public Guid? ResolvedByUserId { get; set; }
    public int? ResolvedByContactId { get; set; }


    public Guid EstimateId { get; set; }
    public Estimate Estimate { get; set; } = null!;
    public Guid AccountId { get; set; }
    public virtual Account Account { get; set; } = null!;
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    public byte RequestTypeId { get; set; }
    public RequestType RequestType { get; set; }

    public byte? ResolveTypeId { get; set; }
    public ResolveType? ResolveType { get; set; }

    #endregion 
}


