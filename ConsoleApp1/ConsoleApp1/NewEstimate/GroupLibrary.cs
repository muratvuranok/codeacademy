using PRO.SharedKernel.Domain.Membership.AccountDomain;
using PRO.SharedKernel.Infrastructure.DbProvider.EFCore.Aggregates;

namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

public partial class GroupLibrary : Entity<Guid>, ITenant
{

    #region Properties
    public short Number { get; set; }
    public string Name { get; set; } = null!;
    public Guid AccountId { get; set; }
    public virtual Account Account { get; set; } = null!;
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    public virtual ICollection<SubGroupLibrary> SubGroupLibraries { get; set; }
    public virtual ICollection<TaskLibrary> TaskLibraries { get; set; }
    #endregion

    #region Constructor
    public GroupLibrary()
    {
        this.SubGroupLibraries = new HashSet<SubGroupLibrary>();
        this.TaskLibraries = new HashSet<TaskLibrary>();
    }

    public GroupLibrary(
        string name,
        short number,
        IEnumerable<TaskLibrary>? taskLibraries = null,
        IEnumerable<SubGroupLibrary>? subGroupLibraries = null
        ) : this()
    {
        this.Name = name;
        this.Number = number;
        this.SubGroupLibraries.AddRange(subGroupLibraries);
        this.TaskLibraries.AddRange(taskLibraries);
    }
    #endregion

    #region Public Methods
    public void Update(
        string name,
        short number,
        IEnumerable<TaskLibrary>? taskLibraries = null,
        IEnumerable<SubGroupLibrary>? subGroupLibraries = null
        )
    {
        this.Name = name;
        this.Number = number;
        this.SubGroupLibraries.AddRange(subGroupLibraries);
        this.TaskLibraries.AddRange(taskLibraries);
    }
    #endregion

}
