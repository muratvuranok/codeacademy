using PRO.SharedKernel.Domain.Membership.AccountDomain;
using PRO.SharedKernel.Infrastructure.DbProvider.EFCore.Aggregates;

namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

public partial class MaterialCategory : Entity<Guid>, ITenant
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

    #region Constructor
    public MaterialCategory()
    {
        this.ChildCategories = new HashSet<MaterialCategory>();
        this.MaterialLibraries = new HashSet<MaterialLibrary>();
    }
    public MaterialCategory(
        string? name,
        Guid? parentId,
        Guid? materialVendorId
        ) : this()
    {
        this.Name = name;
        this.ParentId = parentId;
        this.MaterialVendorId = materialVendorId;
    }
    #endregion

    #region Public Methods

    public void Update(
        string? name
        )
    {
        this.Name = name;
    }
    #endregion 
}
