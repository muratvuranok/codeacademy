using PRO.SharedKernel.Domain.Membership.AccountDomain;
using PRO.SharedKernel.Infrastructure.DbProvider.EFCore.Aggregates;

namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

public partial class EstimatePaymentSchedule : Entity<Guid>, ITenant
{

    #region Properties
    public bool? IsLock { get; set; }
    //TODO:  Done -> sequence byte olmali.
    //TODO: max 100 payment schedule eklenebilir. 
    public byte? Sequence { get; set; }
    public Guid? InvoiceId { get; set; }
    public decimal? Amount { get; set; }
    public string? Description { get; set; }

    //TODO: asagidakiler icin ayni guncelleme yapilmali
    public Guid UserId { get; set; }
    public virtual User User { get; set; } = null!;
    public Guid EstimateId { get; set; }
    public virtual Estimate Estimate { get; set; } = null!;
    public Guid AccountId { get; set; }
    public virtual Account Account { get; set; } = null!;
    #endregion

    #region Constructor
    public EstimatePaymentSchedule() { } 
    public EstimatePaymentSchedule( 
        string? description,
        decimal? amount,
        byte? sequence,
        bool? isLock,
        Guid estimateId
        ) : this()
    {
        this.Amount = amount;
        this.IsLock = isLock;
        this.Sequence = sequence;
        this.EstimateId = estimateId;
        this.Description = description;
    }
    #endregion

    #region Public Methods
    //TODO: Done -> invoiceID baska bir update icerisine alalim. O tek basina bir islem. 
    public void Update(
        decimal? amount,
        string? description,
        bool? isLock,
        byte? sequence
        )
    {
        this.Amount = amount;
        this.IsLock = isLock;
        this.Sequence = sequence;
        this.Description = description;
    }

    public void UpdateInvoice(Guid invoiceId)
    {
        this.InvoiceId = invoiceId;
    }
    #endregion

}
