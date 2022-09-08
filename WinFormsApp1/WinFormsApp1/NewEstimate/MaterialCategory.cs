namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;
public partial class MaterialCategory : Entity<Guid>
{

    #region Properties
    public string? Name { get; set; }

    public Guid? ParentId { get; set; }
    public virtual MaterialCategory? Parent { get; set; }

    public Guid? MaterialVendorId { get; set; }
    public virtual MaterialVendor? MaterialVendor { get; set; }


    public Guid AccountId { get; set; }
    public virtual Account Account { get; set; } = null!;

    public Guid UserId { get; set; }
    public virtual User User { get; set; } = null!;

    public virtual ICollection<MaterialCategory> ChildCategories { get; set; }
    public virtual ICollection<MaterialLibrary> MaterialLibraries { get; set; }
    #endregion
     
}
