using PRO.SharedKernel.Infrastructure.DbProvider.EFCore.Aggregates;

namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

public class EstimateStatus : Entity<byte>
{
    #region Properties
    public string Name { get; set; } = null!;
    #endregion

    #region Constructor
    public EstimateStatus() { }
    public EstimateStatus(string name) : this() { this.Name = name; }
    #endregion

    #region Public Methods
    public void Update(string name) { this.Name = name; }
    #endregion 
}