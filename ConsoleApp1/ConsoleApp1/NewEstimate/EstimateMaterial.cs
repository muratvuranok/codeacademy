using PRO.SharedKernel.Domain.Application.NewEstimate.Enums;
using PRO.SharedKernel.Domain.Membership.AccountDomain;
using PRO.SharedKernel.Infrastructure.DbProvider.EFCore.Aggregates;

namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

public partial class EstimateMaterial : Entity<Guid>, ITenant
{
    #region Properties
    public string? Name { get; set; }
    public byte? Sequence { get; set; }
    public bool? Allowance { get; set; }
    public decimal? UnitCost { get; set; }
    public decimal? Quantity { get; set; }
    public bool? ClientFurnished { get; set; }
    public int? UnitOfMeasurementId { get; set; }
    public decimal? MaterialMarkupAmount { get; set; }
    public decimal? MaterialMarkupPercentage { get; set; }

 
    public byte MaterialTypeId { get; set; }
    public MaterialType MaterialType { get; set; } = null!;

 
    public Guid EstimateTaskId { get; set; }
    public virtual EstimateTask EstimateTask { get; set; } = null!;

    public byte? MarkupTypeId { get; set; }
    public MarkupType? MaterialMarkupType { get; set; }

    public Guid? MaterialLibraryId { get; set; }
    public virtual MaterialLibrary? MaterialLibrary { get; set; }


    public Guid AccountId { get; set; }
    public virtual Account Account { get; set; } = null!;

    public Guid UserId { get; set; }
    public virtual User User { get; set; } = null!;
    #endregion

    #region Constructor
    public EstimateMaterial() { }
    public EstimateMaterial(
        string? name,
        byte? sequence,
        bool? allowance,
        decimal? quantity,
        decimal? unitCost,
        Guid estimateTaskId,
        bool? clientFurnished,
        Guid? materialLibraryId,
        int? unitOfMeasurementId,
        MarkupTypes markupTypeId,
        MaterialTypes materialTypeId,
        decimal? materialMarkupAmount,
        decimal? materialMarkupPercentage
        ) : this()
    {
        this.Name = name;
        this.Sequence = sequence;
        this.Quantity = quantity;
        this.UnitCost = unitCost;
        this.Allowance = allowance;
        this.EstimateTaskId = estimateTaskId;
        this.ClientFurnished = clientFurnished;
        this.MarkupTypeId = (byte)markupTypeId;
        this.MaterialTypeId = (byte)materialTypeId;
        this.MaterialLibraryId = materialLibraryId;
        this.UnitOfMeasurementId = unitOfMeasurementId;
        this.MaterialMarkupAmount = materialMarkupAmount;
        this.MaterialMarkupPercentage = materialMarkupPercentage;
    }
    #endregion

    #region Public Methods
    
    public void UpdateAllowance(bool? allowance) => this.Allowance = allowance;
    public void UpdateMarkUp(MarkupTypes markupTypeId) => this.MarkupTypeId = (byte)markupTypeId;
    public void UpdateClientFurnished(bool? clientFurnished) => this.ClientFurnished = clientFurnished;


    public void Update(
        string? name,
        byte? sequence,
        bool? allowance,
        decimal? quantity,
        decimal? unitCost,
        bool? clientFurnished,
        Guid? materialLibraryId,
        int? unitOfMeasurementId,
        MarkupTypes markupTypeId,
        MaterialTypes materialTypeId,
        decimal? materialMarkupAmount,
        decimal? materialMarkupPercentage
        )
    {
        this.Name = name;
        this.Sequence = sequence;
        this.Quantity = quantity;
        this.UnitCost = unitCost;
        this.Allowance = allowance;
        this.ClientFurnished = clientFurnished;
        this.MarkupTypeId = (byte)markupTypeId;
        this.MaterialTypeId = (byte)materialTypeId;
        this.MaterialLibraryId = materialLibraryId;
        this.UnitOfMeasurementId = unitOfMeasurementId;
        this.MaterialMarkupAmount = materialMarkupAmount;
        this.MaterialMarkupPercentage = materialMarkupPercentage;
    }
    #endregion

}
