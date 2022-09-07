using PRO.SharedKernel.Infrastructure.DbProvider.EFCore.Aggregates;

namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

public class MarkupType : Entity<byte>
{
    #region Properties
    public string Name { get; set; } = null!;
    #endregion

    #region Constructor
    public MarkupType() { }
    public MarkupType(string name) : this() { this.Name = name; }
    #endregion

    #region Public Methods
    public void Update(string name) { this.Name = name; }
    #endregion 
}
