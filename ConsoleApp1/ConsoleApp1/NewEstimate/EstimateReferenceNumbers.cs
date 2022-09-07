using PRO.SharedKernel.Domain.Membership.AccountDomain;
using PRO.SharedKernel.Infrastructure.DbProvider.EFCore.Aggregates;

namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

public partial class EstimateReferenceNumbers : Entity<Guid>, ITenant
{ 
    #region Properties
    public string? ReferencePrefix { get; set; }
    public byte NumberLength { get; set; }
    public int? LastNumber { get; set; }
    public string? ReferenceSuffix { get; set; }

    public Guid AccountId { get; set; }
    public virtual Account Account { get; set; } = null!;
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;
    #endregion

    #region Constructor
    public EstimateReferenceNumbers() { }
    public EstimateReferenceNumbers(
        string referencePrefix,
        string referenceSuffix,
        byte numberLength) : this()
    {
        this.ReferencePrefix = referencePrefix;
        this.ReferenceSuffix = referenceSuffix;
        this.NumberLength = numberLength;
    }
    #endregion

    #region Public Methods
    public void Update(string referencePrefix,
     string referenceSuffix,
     byte numberLength)
    {
        this.ReferencePrefix = referencePrefix;
        this.ReferenceSuffix = referenceSuffix;
        this.NumberLength = numberLength;
    }

    public void UpdateLastNumber(int lastNumber)
    {
        this.LastNumber = lastNumber;
    }
    #endregion


    //// Generate Metodu Ekle, Son numaranın bir üst değerini teslim etsin
    ///
     //  Reference number length isteniyor ayrica burda. Notlarima eklemeyi unutmus olabilirim. Yani 3 haneli mi 4 hanelimi rakam olusturulacak. sistematik olmali. 
    //Burayi iyi kurgulamalisin. RefereneNumber degeri string olmak zorunda artik. Ben estimaterimin "EST" ile baslamasini ve 3 rakamdan olusmasi gibi kural verebilmeliyim. 
    //Dolayisiyla yeni bir estimate olustugunda. Reference number EST001 olarak olusmali. O yuzden estimate reference numarasi str alan. Her account icin bu deger 1 den baslar. Yani account specific. 


    // : Estimate Numaralarını tutacak bir tablo yer alacak. Uniq olmak zorundadır. (sıralı gidecek) EstimateReferenceNumbers 
    //public string? ReferenceNumber { get; set; }

    //// EstimateReferanceSettings tablosu içerisine alınacak
    //public string? ReferencePrefix { get; set; }  // EST
    //// public byte? NumberLength { get; set; } 3
    //// public int? LastNumber { get; set; } 2
    //public string? ReferenceSuffix { get; set; } // XYC
    //// Generate Metodu Ekle, Son numaranın bir üst değerini teslim etsin
}
