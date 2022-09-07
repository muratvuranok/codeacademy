using PRO.SharedKernel.Domain.Membership.AccountDomain;
using PRO.SharedKernel.Infrastructure.DbProvider.EFCore.Aggregates;

namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

public partial class SubGroupLibrary : Entity<Guid>, ITenant
{
    #region Properties
    public short Number { get; set; }
    public string Name { get; set; } = null!;
    public Guid AccountId { get; set; }
    public virtual Account Account { get; set; } = null!;
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    public Guid GroupLibraryId { get; set; }
    public virtual GroupLibrary GroupLibrary { get; set; } = null!;
    public virtual ICollection<TaskLibrary> TaskLibraries { get; set; }
    #endregion

    #region Constructor
    public SubGroupLibrary()
    {
        this.TaskLibraries = new HashSet<TaskLibrary>();
    }

    public SubGroupLibrary(
        string name,
        short number,
        Guid groupLibraryId,
        IEnumerable<TaskLibrary>? taskLibraries = null
        ) : this()
    {
        this.Name = name;
        this.Number = number;
        this.GroupLibraryId = groupLibraryId;
        this.TaskLibraries.AddRange(taskLibraries);
    }
    #endregion

    #region Public Methods
    public void Update(
    string name,
    short number
    )
    {
        this.Name = name;
        this.Number = number;

    }
    #endregion 
}
