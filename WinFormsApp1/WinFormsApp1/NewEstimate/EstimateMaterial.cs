namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;
public partial class EstimateMaterial : Entity<Guid>
{
    #region Properties
    public string? Name { get; set; }
    public byte? Sequence { get; set; }
    public bool? Allowance { get; set; }
    public decimal? UnitCost { get; set; }
    public decimal? Quantity { get; set; }
    public bool? ClientFurnished { get; set; }

    public decimal? MaterialMarkupAmount { get; set; }
    public decimal? MaterialMarkupPercentage { get; set; }
     
    public int? UnitsOfMeasurementId { get; set; }
    public UnitsOfMeasurement? UnitsOfMeasurement { get; set; }

    public byte MaterialTypeId { get; set; }
    public MaterialType MaterialType { get; set; } = null!;
     
    public Guid EstimateTaskId { get; set; }
    public virtual EstimateTask EstimateTask { get; set; } = null!;

    public byte? MarkupTypeId { get; set; }
    public MarkupType? MaterialMarkupType { get; set; }

    public Guid? MaterialLibraryId { get; set; }
    public virtual MaterialLibrary? MaterialLibrary { get; set; }
     
    public Guid AccountId { get; set; }
    public virtual Account Account { get; set; } = null!;

    public Guid UserId { get; set; }
    public virtual User User { get; set; } = null!;
    #endregion
     
}
