using PRO.SharedKernel.Domain.Application.NewEstimate.Enums;
using PRO.SharedKernel.Domain.Membership.AccountDomain;
using PRO.SharedKernel.Infrastructure.DbProvider.EFCore.Aggregates;

namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

public partial class TaskLibrary : Entity<Guid>, ITenant
{ 
    #region Properties
    public string? Name { get; set; }
    public byte? Number { get; set; }

    public decimal? LaborUnitCost { get; set; }
    public byte? TaskLibraryTypeId { get; set; }
    public int? UnitOfMeasurementId { get; set; }


    public Guid AccountId { get; set; }
    public virtual Account Account { get; set; } = null!;
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

     
    public Guid GroupLibraryId { get; set; }
    public virtual GroupLibrary GroupLibrary { get; set; } = null!;
    public Guid? SubGroupLibraryId { get; set; }
    public virtual SubGroupLibrary? SubGroupLibrary { get; set; }
    #endregion

    #region Constructor
    public TaskLibrary() { }
    public TaskLibrary(
        string? name,
        byte? number,
        Guid groupLibraryId,
        decimal? laborUnitCost,
        Guid subGroupLibraryId,
        int? unitOfMeasurementId,
        TaskLibraryTypes taskLibraryTypeId
        ) : this()
    {
        this.Name = name;
        this.Number = number;
        this.LaborUnitCost = laborUnitCost;
        this.GroupLibraryId = groupLibraryId;
        this.SubGroupLibraryId = subGroupLibraryId;
        this.UnitOfMeasurementId = unitOfMeasurementId;
        this.TaskLibraryTypeId = (byte)taskLibraryTypeId;
    }
    #endregion

    #region Public Methods
    public void Update(
    string? name,
    byte? number,
    decimal? laborUnitCost,
    int? unitOfMeasurementId 
    )
    {
        this.Name = name;
        this.Number = number;
        this.LaborUnitCost = laborUnitCost;
        this.UnitOfMeasurementId = unitOfMeasurementId;
    }
    #endregion 
}
