using PRO.SharedKernel.Domain.Membership.AccountDomain;
using PRO.SharedKernel.Infrastructure.DbProvider.EFCore.Aggregates;

namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

public class TaskLibraryType : Entity<byte> 
{
    #region Properties
    public string Name { get; set; } = null!; 
    #endregion

    #region Constructor
    public TaskLibraryType() { }
    public TaskLibraryType(string name) : this() { this.Name = name; }
    public void Update(string name) { this.Name = name; }
    #endregion  
}
