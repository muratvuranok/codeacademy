using PRO.SharedKernel.Domain.Membership.AccountDomain;
using PRO.SharedKernel.Domain.Notification.EmailDomain;
using PRO.SharedKernel.Infrastructure.DbProvider.EFCore.Aggregates;

namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

public partial class RequestHistory : Entity<Guid>, ITenant
{
    #region Properties
    public byte? RequestType { get; set; }
    public Guid? RequestedBy { get; set; }
    public byte? ResolvedType { get; set; }
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

    #endregion

    #region Constructor
    public RequestHistory() { }
    //TODO: Done -> request istory olustugunda resolve date viewed date istememiz gerekmez hocam. request gondermek icin sadece gerekli alanlari eklemelisin. 

    public RequestHistory(
        Guid estimateId,
        Guid? emailLogId,
        byte? requestType,   // Enum Olacak
        Guid? requestedBy,
        //byte? resolvedType,  // Enum Olacak 
        Guid? resolvedByUserId 
        ) : this()
    {
        this.EstimateId = estimateId;
        this.EmailLogId = emailLogId;
        this.RequestType = requestType;
        this.RequestDate = DateTime.UtcNow;
        this.RequestedBy = requestedBy;
        this.ResolvedByUserId = resolvedByUserId; 
    }
    #endregion

    #region Public Methods
    public void UpdateView(  // view için
    Guid? emailLogId,
    byte? requestType,
    Guid? requestedBy,
    byte? resolvedType,
    DateTime? viewedDate,
    DateTime? requestDate,
    DateTime? resolvedDate,
    Guid? resolvedByUserId,
    int? resolvedByContactId
    )
    {
        this.EmailLogId = emailLogId;
        this.ViewedDate = DateTime.UtcNow;
        this.RequestType = requestType;
        this.RequestDate = requestDate;
        this.RequestedBy = requestedBy;
        this.ResolvedType = resolvedType;
        this.ResolvedDate = resolvedDate;
        this.ResolvedByUserId = resolvedByUserId;
        this.ResolvedByContactId = resolvedByContactId;
    }

    public void UpdateResolve() { // resolve için
    
    
    }
    #endregion
}


