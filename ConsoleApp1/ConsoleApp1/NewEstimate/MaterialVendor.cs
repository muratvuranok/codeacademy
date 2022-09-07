using PRO.SharedKernel.Domain.Membership.AccountDomain;
using PRO.SharedKernel.Infrastructure.DbProvider.EFCore.Aggregates;

namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

public partial class MaterialVendor : Entity<Guid>, ITenant
{ 
    #region Properties

    public string? Name { get; set; }
    public virtual ICollection<MaterialCategory> MaterialCategories { get; set; }
    public Guid AccountId { get; set; }
    public virtual Account Account { get; set; } = null!;
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    #endregion

    #region Constructor
    public MaterialVendor()
    {
        this.MaterialCategories = new HashSet<MaterialCategory>();
    }

    public MaterialVendor(
        string? name,
        IEnumerable<MaterialCategory> materialCategories
        ) : this()
    {
        this.Name = name;
        this.MaterialCategories.AddRange(materialCategories);
    }
    #endregion

    #region Public Methods
    public void Update(
    string name
    )
    {
        this.Name = name;
    }
    #endregion 
}
