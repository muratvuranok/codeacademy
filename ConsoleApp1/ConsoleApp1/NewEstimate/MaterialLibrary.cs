using PRO.SharedKernel.Domain.Application.NewEstimate.Enums;
using PRO.SharedKernel.Domain.Membership.AccountDomain;
using PRO.SharedKernel.Infrastructure.DbProvider.EFCore.Aggregates;

namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

public partial class MaterialLibrary : Entity<Guid>, ISoftDelete, ITenant
{ 
    #region Properties
    public string? Name { get; set; }
    public decimal? Low { get; set; }
    public decimal? High { get; set; }
    public decimal? Medium { get; set; }

    public DateTime? DeletedDate { get; set; }
    public DeleteTypes? DeleteType { get; set; }

    public int? UnitOfMeasurementId { get; set; }
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

    #region Constructor
    public MaterialLibrary()
    {
        this.EstimateMaterials = new HashSet<EstimateMaterial>();
    }

    public MaterialLibrary(
        string? name,
        decimal? low,
        decimal? high,
        decimal? medium,
        Guid? materialCategoryId,
        MaterialTypes materialTypeId,
        IEnumerable<EstimateMaterial>? estimateMaterials = null
        ) : this()
    {
        this.Low = low;
        this.Name = name;
        this.High = high;
        this.Medium = medium;
        this.DeletedDate = null;
        this.DeleteType = DeleteTypes.Active;
        this.MaterialTypeId = (byte)materialTypeId;
        this.MaterialCategoryId = materialCategoryId;
        this.EstimateMaterials.AddRange(estimateMaterials);
    }
    #endregion

    #region Public Methods
    public void Update(
    string? name,
    decimal? low,
    decimal? high,
    decimal? medium,
    MaterialTypes materialTypeId
    )
    {
        this.Low = low;
        this.Name = name;
        this.High = high;
        this.Medium = medium;
        this.DeletedDate = null;
        this.DeleteType = DeleteTypes.Active;
        this.MaterialTypeId = (byte)materialTypeId;
    }

    public void Delete()
    {
        this.DeletedDate = DateTime.UtcNow;
        this.DeleteType = DeleteTypes.Trash;
    }
    public void DeleteForever()
    {
        this.DeletedDate = DateTime.UtcNow;
        this.DeleteType = DeleteTypes.Forever;
    }
    public void Recover()
    {
        this.DeletedDate = null;
        this.DeleteType = DeleteTypes.Active;
    }
    #endregion
     
}
