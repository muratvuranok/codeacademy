﻿namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;
public partial class SubGroupLibrary : Entity<Guid>
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
     
}
