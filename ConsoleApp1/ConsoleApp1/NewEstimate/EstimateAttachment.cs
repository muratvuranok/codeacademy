using PRO.SharedKernel.Domain.Application.ResourceCenterDomain;
using PRO.SharedKernel.Domain.Membership.AccountDomain;
using PRO.SharedKernel.Infrastructure.DbProvider.EFCore.Aggregates;

namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;
 
 
public partial class EstimateAttachment : Entity<Guid>, ITenant
{

    #region Properties

    //TODO : ( Murat )  Max 100 adet eklenebilir
    public byte? Sequence { get; set; }
    public string? FileName { get; set; }
    public string? CreatedDate { get; set; }
    public string? UpdatedDate { get; set; }
    public string? FileDescription { get; set; }


    public Guid ResourceFileId { get; set; }
    public ResourceFile ResourceFile { get; set; } = null!;
    public Guid EstimateId { get; set; }
    public virtual Estimate Estimate { get; set; } = null!;
    public Guid AccountId { get; set; }
    public virtual Account Account { get; set; } = null!;
    public Guid UserId { get; set; }
    public virtual User User { get; set; } = null!;
    #endregion

    #region Constructor
    public EstimateAttachment() { }

    public EstimateAttachment(
        Guid estimateId,
        Guid resourceFileId,
        byte? sequence,
        string? fileName,
        string? fileDescription
        ) : this()
    {
        this.FileName = fileName;
        this.Sequence = sequence;
        this.EstimateId = estimateId;
        this.ResourceFileId = resourceFileId;
        this.FileDescription = fileDescription;
    }
    #endregion

    #region Public Methods  
    public void Update(
        byte? sequence,
        string? fileName,
        string? fileDescription)
    {
        this.FileName = fileName;
        this.Sequence = sequence;
        this.FileDescription = fileDescription;
    }
    #endregion

}
