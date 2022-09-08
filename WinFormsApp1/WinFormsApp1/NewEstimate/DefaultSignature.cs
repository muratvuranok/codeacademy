using PRO.SharedKernel.Domain.Application.CommonDomain;
using PRO.SharedKernel.Domain.Application.NewEstimate.Enums;
using PRO.SharedKernel.Domain.Membership.AccountDomain;


namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

public partial class DefaultSignature : Entity<Guid>
{

    #region Properties
    public string? SignedFontText { get; set; }
    public string? SignedImagePath { get; set; }
    public string? SignedFontFamily { get; set; }


    public byte? SignedTypeId { get; set; }
    public SignedType? SignedType { get; set; }


    public Guid AccountId { get; set; }
    public virtual Account Account { get; set; } = null!;

    public Guid UserId { get; set; }
    public virtual User User { get; set; } = null!;
    #endregion

    #region Constructor
    public DefaultSignature() { }
    public DefaultSignature(
        string? signedFontText,
        string? signedImagePath,
        string? signedFontFamily,
        SignedTypes signedTypeId
        ) : this()
    {
        this.SignedFontText = signedFontText;
        this.SignedTypeId = (byte)signedTypeId;
        this.SignedImagePath = signedImagePath;
        this.SignedFontFamily = signedFontFamily;
    }
    #endregion

    #region Public Methods
    public void Update(
    string? signedFontText,
    string? signedImagePath,
    SignedTypes signedTypeId,
    string? signedFontFamily
    )
    {
        this.SignedFontText = signedFontText;
        this.SignedTypeId = (byte)signedTypeId;
        this.SignedImagePath = signedImagePath;
        this.SignedFontFamily = signedFontFamily;
    }
    #endregion 

}
