using PRO.SharedKernel.Domain.Application.NewEstimate.Enums;

namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

public partial class EstimateNote : Entity<Guid>
{
    #region Properties

    public string? Title { get; set; }
    public byte? Sequence { get; set; }
    public string? Description { get; set; }
     
    //TODO: Done -> UserID ve AccountID yi her tabloya ekleyip ITenant ekleyelim. HEPSINE!!


    //TODO: Done -> Required
    public Guid EstimateId { get; set; }
    public virtual Estimate Estimate { get; set; } = null!;

    public Guid UserId { get; set; }
    public virtual User User { get; set; } = null!;
    public Guid AccountId { get; set; }
    public virtual Account Account { get; set; } = null!;

    public byte EstimateNoteTypeId { get; set; }
    //TODO:Done -> yukarsi required asagisi degil. Asagiyi required yapalim.
    public EstimateNoteType timateNoteType { get; set; } = null!;
    #endregion
     
}
