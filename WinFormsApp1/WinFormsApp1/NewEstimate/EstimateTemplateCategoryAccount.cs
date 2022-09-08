using Microsoft.VisualBasic.ApplicationServices;

namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

//TODO: Done - category yanlis yazilmis
public partial class EstimateTemplateCategoryAccount : Entity<Guid>
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
}

public partial class Account : Entity<Guid>
{
    public Account()
    {
        Users = new HashSet<User>();
        ResourceFiles = new HashSet<ResourceFile>(); 
    }

    public bool Active { get; set; }
    public int SubscriptionId { get; set; }
    public byte SubscriptionPeriodId { get; set; }
    public DateTime SubscriptionStartDate { get; set; }
    public DateTime SubscriptionEndDate { get; set; }
    public int? PendingSubscriptionId { get; set; }
    public byte? PendingSubscriptionPeriodId { get; set; }
    public string CompanyLogoPath { get; set; } = null!;
    public string CompanyName { get; set; } = null!;
    public string CompanyEmail { get; set; } = null!;
    public string CompanyPhone { get; set; } = null!;
    public string CompanyAddress { get; set; } = null!;
    public string CompanyCity { get; set; } = null!;
    public string CompanyState { get; set; } = null!;
    public string CompanyCountry { get; set; } = null!;
    public string CompanyPostalCode { get; set; } = null!;
    public double CompanyLatitude { get; set; }
    public double CompanyLongitude { get; set; }
    public string CompanyWebsite { get; set; } = null!;
    public string CompanyInsurance { get; set; } = null!;
    public string CompanyLicense { get; set; } = null!;
    public string? BillingName { get; set; }
    public string? BillingAddress { get; set; }
    public string? BillingCity { get; set; }
    public string? BillingState { get; set; }
    public string? BillingCountry { get; set; }
    public string? BillingPostalCode { get; set; }
    public int? CompanyPhoneCountryId { get; set; }
    public int CurrencyId { get; set; }
    public byte CompanyBrandDisplayType { get; set; }
    public byte CompanyBrandFontSize { get; set; }
    public byte CompanyBrandImageHeight { get; set; }
    public byte? CompanySize { get; set; }
    public string? LogPromotion { get; set; }
    public Guid? LogReferral { get; set; }



    public virtual ICollection<User> Users { get; set; }

    public virtual ICollection<ResourceFile> ResourceFiles { get; set; }

}
