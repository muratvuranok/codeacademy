using PRO.SharedKernel.Infrastructure.DbProvider.EFCore.Aggregates;

namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

public class EstimateNoteType : Entity<Guid>
{
    #region Properties
    public string Name { get; set; } = null!;
    #endregion

    #region Constructor
    public EstimateNoteType() { }
    public EstimateNoteType(string name) : this() { this.Name = name; }
    #endregion

    #region Public Methods
    public void Update(string name) { this.Name = name; }
    #endregion 

}