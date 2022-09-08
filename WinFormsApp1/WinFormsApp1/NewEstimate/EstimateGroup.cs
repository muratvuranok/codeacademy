namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

public partial class EstimateGroup : Entity<Guid>
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
 
      
}
