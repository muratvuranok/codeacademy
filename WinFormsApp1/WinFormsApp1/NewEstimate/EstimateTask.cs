using PRO.SharedKernel.Domain.Application.NewEstimate.Enums;


namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;
public partial class EstimateTask : Entity<Guid>
{
    #region Properties
    public int? Number { get; set; }
    public bool? HasTax { get; set; }
    public string? Name { get; set; }
    public byte? Sequence { get; set; }
    public string? Locations { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? LaborRate { get; set; }
    public decimal? LaborHours { get; set; }
    public decimal? LaborUnitCost { get; set; }
    public decimal? LaborMarkupAmount { get; set; }
    public decimal? LaborMarkupPercentage { get; set; }
     
    public int? UnitsOfMeasurementId { get; set; }
    public UnitsOfMeasurement? UnitsOfMeasurement { get; set; }

    public byte? MarkupTypeId { get; set; }
    public MarkupTypes? MarkupTypes { get; set; }

    public Guid? TaskLibraryId { get; set; }
    public TaskLibrary? TaskLibrary { get; set; }

    public Guid EstimateGroupId { get; set; }
    public virtual EstimateGroup EstimateGroup { get; set; } = null!;
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;
    public Guid AccountId { get; set; }
    public Account Account { get; set; } = null!;

    //TODO: Done -> userID accountId ekleyelim. Eklemeyi unuttugum yerler varsa da onlarada ekleyelim. ITenant ile. 

    public virtual ICollection<EstimateMaterial> EstimateMaterials { get; set; }
    public virtual ICollection<EstimateTaskNote> EstimateTaskNotes { get; set; }
    public virtual ICollection<EstimateTaskPhoto> EstimateTaskPhotos { get; set; }
    #endregion
     
     
}
