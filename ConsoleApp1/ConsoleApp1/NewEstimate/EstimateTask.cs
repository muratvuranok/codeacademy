using PRO.SharedKernel.Domain.Application.NewEstimate.Enums;
using PRO.SharedKernel.Domain.Membership.AccountDomain;
using PRO.SharedKernel.Infrastructure.DbProvider.EFCore.Aggregates;

namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;
public partial class EstimateTask : Entity<Guid>, ITenant
{
    #region Properties
    public int? Number { get; set; }
    public bool? HasTax { get; set; }
    public string? Name { get; set; }
    public byte? Sequence { get; set; }
    public string? Locations { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? LaborRate { get; set; }
    public decimal? LaborHours { get; set; }
    public decimal? LaborUnitCost { get; set; }
    public int? UnitOfMeasurementId { get; set; }
    public decimal? LaborMarkupAmount { get; set; }
    public decimal? LaborMarkupPercentage { get; set; }



    public byte? MarkupTypeId { get; set; }
    public MarkupTypes? MarkupTypes { get; set; }

    public Guid? TaskLibraryId { get; set; }
    public TaskLibrary? TaskLibrary { get; set; }

    public Guid EstimateGroupId { get; set; }
    public virtual EstimateGroup EstimateGroup { get; set; } = null!;
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;
    public Guid AccountId { get; set; }
    public Account Account { get; set; } = null!;

    //TODO: Done -> userID accountId ekleyelim. Eklemeyi unuttugum yerler varsa da onlarada ekleyelim. ITenant ile. 

    public virtual ICollection<EstimateMaterial> EstimateMaterials { get; set; }
    public virtual ICollection<EstimateTaskNote> EstimateTaskNotes { get; set; }
    public virtual ICollection<EstimateTaskPhoto> EstimateTaskPhotos { get; set; }
    #endregion

    #region Constructor
    public EstimateTask()
    {
        this.EstimateMaterials = new HashSet<EstimateMaterial>();
        this.EstimateTaskNotes = new HashSet<EstimateTaskNote>();
        this.EstimateTaskPhotos = new HashSet<EstimateTaskPhoto>();
    }

    public EstimateTask(
        int? number,
        string? name,
        bool? hasTax,
        byte? sequence,
        string? locations,
        decimal? quantity,
        decimal? laborRate,
        Guid? taskLibraryId,
        decimal? laborHours,
        Guid estimateGroupId,
        decimal? laborUnitCost,
        int? unitOfMeasurementId,
        MarkupTypes markupTypeId,
        decimal? laborMarkupAmount,
        decimal? laborMarkupPercentage,
        IEnumerable<EstimateMaterial>? estimateMaterials = null,
        IEnumerable<EstimateTaskNote>? estimateTaskNotes = null,
        IEnumerable<EstimateTaskPhoto>? estimateTaskPhotos = null) : this()
    {
        this.Name = name;
        this.Number = number;
        this.HasTax = hasTax;
        this.Quantity = quantity;
        this.Sequence = sequence;
        this.LaborRate = laborRate;
        this.Locations = locations;
        this.LaborHours = laborHours;
        this.TaskLibraryId = taskLibraryId;
        this.LaborUnitCost = laborUnitCost;
        this.EstimateGroupId = estimateGroupId;
        this.MarkupTypeId = (byte)markupTypeId;
        this.LaborMarkupAmount = laborMarkupAmount;
        this.UnitOfMeasurementId = unitOfMeasurementId;
        this.LaborMarkupPercentage = laborMarkupPercentage;
        this.EstimateMaterials.AddRange(estimateMaterials);
        this.EstimateTaskNotes.AddRange(estimateTaskNotes);
        this.EstimateTaskPhotos.AddRange(estimateTaskPhotos);
    }
    #endregion
  
    //TODO: Done -> Task librarid degismez.  ( silindi )
     
}
