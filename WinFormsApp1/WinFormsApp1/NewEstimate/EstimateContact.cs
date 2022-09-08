namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;
public partial class EstimateContact : Entity<Guid> 
{
    #region Properties 
    //TODO: Done -> Bu iki degeri ekliyorsak ITransactionDate eklemek gerekiyor yoksa elle update yaparsn. 
    public DateTime? CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }

    public Guid AccountId { get; set; }
    public virtual Account Account { get; set; } = null!;
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;
    public byte? EstimateContactTypeId { get; set; }
    public virtual EstimateContactType? EstimateContactType { get; set; }

    //TODO: Done -> contactId ve EstoateId yi zorunli kilalim. 
    public int ContactId { get; set; }
    public virtual Contact Contact { get; set; } = null!;
    public int? ContactEmailId { get; set; }
    public virtual ContactEmail? ContactEmail { get; set; }
    public int? ContactPhoneId { get; set; }
    public virtual ContactPhone? ContactPhone { get; set; }
    public int? ContactAddressId { get; set; }
    public virtual ContactAddress? ContactAddress { get; set; }
    public Guid EstimateId { get; set; }
    public virtual Estimate Estimate { get; set; } = null!;
    public Guid? SignatureId { get; set; }
    public virtual Signature? Signature { get; set; } = null!;

    #endregion
     
}
