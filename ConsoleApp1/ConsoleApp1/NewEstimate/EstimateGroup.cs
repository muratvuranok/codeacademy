using PRO.SharedKernel.Domain.Membership.AccountDomain;
using PRO.SharedKernel.Infrastructure.DbProvider.EFCore.Aggregates;

namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

public partial class EstimateGroup : Entity<Guid>, ITenant
{ 
    #region Properties
   
    public short Number { get; set; }
    public string? Name { get; set; }
    public byte? Sequence { get; set; }
     
    public Guid SubGroupLibraryId { get; set; }
    public virtual SubGroupLibrary SubGroupLibrary { get; set; } = null!;
    public Guid EstimateId { get; set; }
    public virtual Estimate Estimate { get; set; } = null!;
    public Guid AccountId { get; set; }
    public virtual Account Account { get; set; } = null!;
    public Guid UserId { get; set; }
    public virtual User User { get; set; } = null!;
    public virtual ICollection<EstimateTask> EstimateTasks { get; set; }
    #endregion

    #region Constructor
    public EstimateGroup()
    {
        this.EstimateTasks = new HashSet<EstimateTask>();
    }
  
    public EstimateGroup(
        short number,
        string? name,
        byte? sequence,
        Guid estimateId,
        Guid subGroupLibraryId,
        IEnumerable<EstimateTask>? estimateTasks = null
        ) : this()
    {
        this.Name = name;
        this.Number = number;
        this.Sequence = sequence;
        this.EstimateId = estimateId;
        this.SubGroupLibraryId = subGroupLibraryId;
        this.EstimateTasks.AddRange(estimateTasks);
    }
    #endregion

    #region Public Methods
   
    public void Update(
        string? name,
        byte? sequence )
    {
        this.Name = name;
        this.Sequence = sequence; 
    }
    #endregion
      
}
