using PRO.SharedKernel.Domain.Application.NewEstimate.Enums;
using PRO.SharedKernel.Domain.Membership.AccountDomain;
using PRO.SharedKernel.Infrastructure.DbProvider.EFCore.Aggregates;

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

    #region Constructor
    public EstimateNote() { }
    public EstimateNote(
        string? title,
        byte? sequence,
        Guid estimateId,
        string? description,
        EstimateNoteTypes estimateNoteTypeId
        ) : this()
    {
        this.Title = title;
        this.Sequence = sequence;
        this.EstimateId = estimateId;
        this.Description = description;
        this.EstimateNoteTypeId = (byte)estimateNoteTypeId;
    }
    #endregion

    #region Public Methods
    //TODO: Done -> notetye degismer update ile
    public void Update(
        string? title,
        byte? sequence,
        string? description
        )
    {
        this.Title = title;
        this.Sequence = sequence;
        this.Description = description;
    }
    #endregion 
}
