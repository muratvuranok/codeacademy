using PRO.SharedKernel.Domain.Application.CommonDomain;
using PRO.SharedKernel.Domain.Application.ContactDomain;
using PRO.SharedKernel.Domain.Application.NewEstimate.Enums;
using PRO.SharedKernel.Domain.Membership.AccountDomain;
using PRO.SharedKernel.Infrastructure.DbProvider.EFCore.Aggregates;

namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;
public partial class EstimateContact : Entity<Guid>, ITransactionDate, ITenant
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

    #region Constructor
    public EstimateContact() { }
    //TODO: Done -> bir estimat econtact olusurken estimateID yi zorunli kilmak zorundasin. 
    public EstimateContact(
        int contactId,
        Guid estimateId,
        Guid? signatureId,
        int? contactEmailId,
        int? contactPhoneId,
        int? contactAddressId,
        EstimateContactTypes estimateContactTypeId) : this()
    {
        this.ContactId = contactId;
        this.EstimateId = estimateId;
        this.SignatureId = signatureId;
        this.ContactEmailId = contactEmailId;
        this.ContactPhoneId = contactPhoneId;
        this.ContactAddressId = contactAddressId;
        this.EstimateContactTypeId = (byte)estimateContactTypeId;
    }
    #endregion

    #region Public Methods
    //TODO:Done -> update yaparken signatuere id ve type gerek yok. signature update islemine girmiyor.O signature olusturmak.
    //TODO: Method isimlerini dikkatli olusturmak gerekli. 
    public void Update(
        int contactId,
        int? contactEmailId,
        int? contactPhoneId,
        int? contactAddressId)
    {
        this.ContactId = contactId;
        this.ContactEmailId = contactEmailId;
        this.ContactPhoneId = contactPhoneId;
        this.ContactAddressId = contactAddressId;
    }
    #endregion

}
