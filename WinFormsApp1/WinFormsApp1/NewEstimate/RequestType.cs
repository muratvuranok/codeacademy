

using PRO.SharedKernel.Domain.Application.NewEstimateDomain;

namespace PRO.SharedKernel.Domain.Application.NewEstimate; 
public class RequestType : Entity<Guid>
{
    #region Properties
    public string Name { get; set; } = null!;
    #endregion
     
}
