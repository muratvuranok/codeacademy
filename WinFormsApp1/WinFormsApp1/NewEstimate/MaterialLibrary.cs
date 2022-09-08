namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

public partial class MaterialLibrary : Entity<Guid> 
{ 
    #region Properties
    public string? Name { get; set; }
    public decimal? Low { get; set; }
    public decimal? High { get; set; }
    public decimal? Medium { get; set; }

    public DateTime? DeletedDate { get; set; }
    public DeleteTypes? DeleteType { get; set; }

    public int? UnitOfMeasurementId { get; set; }
    public UnitsOfMeasurement? UnitsOfMeasurementId { get; set; }
    public Guid AccountId { get; set; }
    public virtual Account Account { get; set; } = null!;
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;
    public byte? MaterialTypeId { get; set; }
    public MaterialType? MaterialType { get; set; }

    public Guid? MaterialCategoryId { get; set; }
    public virtual MaterialCategory? MaterialCategory { get; set; }

    public virtual ICollection<EstimateMaterial> EstimateMaterials { get; set; }


    #endregion
     
     
}
