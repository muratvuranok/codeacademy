namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

public partial class TaskLibrary : Entity<Guid>
{
    #region Properties
    public string? Name { get; set; }
    public byte? Number { get; set; } 
    public decimal? LaborUnitCost { get; set; }


    public byte? TaskLibraryTypeId { get; set; }
    public TaskLibraryType TaskLibraryType { get; set; }

    public int? UnitsOfMeasurementId { get; set; }
    public UnitsOfMeasurement UnitsOfMeasurement { get; set; }

    public Guid AccountId { get; set; }
    public virtual Account Account { get; set; } = null!;
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;


    public Guid GroupLibraryId { get; set; }
    public virtual GroupLibrary GroupLibrary { get; set; } = null!;
    public Guid? SubGroupLibraryId { get; set; }
    public virtual SubGroupLibrary? SubGroupLibrary { get; set; }
    #endregion
     
}
