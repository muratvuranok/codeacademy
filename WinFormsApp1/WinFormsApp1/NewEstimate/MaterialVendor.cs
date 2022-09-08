namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;
public partial class MaterialVendor : Entity<Guid>
{ 
    #region Properties

    public string? Name { get; set; }
    public virtual ICollection<MaterialCategory> MaterialCategories { get; set; }
    public Guid AccountId { get; set; }
    public virtual Account Account { get; set; } = null!;
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    #endregion
     
}
