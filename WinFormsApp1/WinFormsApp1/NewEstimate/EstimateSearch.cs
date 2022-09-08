using PRO.SharedKernel.Domain.Application.NewEstimateDomain;


namespace PRO.SharedKernel.Domain.Application.NewEstimate;
 
//TODO: One to One Relation
public partial class EstimateSearch : Entity<Guid>
{ 
    #region Properties
    public Guid EstimateId { get; set; }
    public Estimate Estimate { get; set; } = null!;
    public string Search { get; set; } = null!;
    #endregion

    #region Constructor
    public EstimateSearch() { }
    public EstimateSearch(
        Guid estimateId,
        string search
        ) : this()
    {
        this.EstimateId = estimateId;
        this.Search = search;
    }
    #endregion

    #region Public Methods
    public void Update(
        string search
        )
    {
        this.Search = search;
    }
    #endregion
     
}
