

using PRO.SharedKernel.Domain.Application.NewEstimateDomain;

namespace PRO.SharedKernel.Domain.Application.NewEstimate;

public class ResolveType : Entity<Guid>
{
    #region Properties
    public string Name { get; set; } = null!;
    #endregion

    #region Constructor
    public ResolveType() { }
    public ResolveType(string name) : this() { this.Name = name; }
    #endregion

    #region Public Methods
    public void Update(string name) { this.Name = name; }
    #endregion
}