namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;
public partial class EstimatePaymentSchedule : Entity<Guid>
{

    #region Properties
    public bool? IsLock { get; set; }
    //TODO:  Done -> sequence byte olmali.
    //TODO: max 100 payment schedule eklenebilir. 
    public byte? Sequence { get; set; }
    public decimal? Amount { get; set; }
    public string? Description { get; set; }

    public Guid? InvoiceId { get; set; }
    public Invoice? Invoice { get; set; }


    //TODO: asagidakiler icin ayni guncelleme yapilmali
    public Guid UserId { get; set; }
    public virtual User User { get; set; } = null!;
    public Guid EstimateId { get; set; }
    public virtual Estimate Estimate { get; set; } = null!;
    public Guid AccountId { get; set; }
    public virtual Account Account { get; set; } = null!;
    #endregion
     
}
