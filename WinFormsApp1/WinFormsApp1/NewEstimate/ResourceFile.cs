using Microsoft.VisualBasic.ApplicationServices;

namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

public partial class ResourceFile : Entity<Guid>
{
    public ResourceFile()
    {
        ResourceFileAssociations = new HashSet<ResourceFileAssociation>();
        Tags = new HashSet<Tag>();
    }

    public Guid AccountId { get; set; }
    public Guid UserId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public string FileName { get; set; } = null!;
    public string FilePath { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int FileSize { get; set; }
    public string FileExtension { get; set; } = null!;

    public virtual Account Account { get; set; } = null!;
    public virtual User User { get; set; } = null!;

    public virtual ICollection<ResourceFileAssociation> ResourceFileAssociations { get; set; }
    public virtual ICollection<Tag> Tags { get; set; }
}
public partial class ResourceFileAssociation : Entity<Guid>
{
    public Guid ResourceFileId { get; set; }
    public byte ApplicationType { get; set; }
    public string? ApplicationId { get; set; }
    public int? ProjectId { get; set; }
     
    public virtual ResourceFile ResourceFile { get; set; } = null!;
}
public partial class Tag : Entity<Guid> 
{
    

    public string Name { get; set; } = null!;
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;
    public Guid AccountId { get; set; }
    public Account Account { get; set; } = null!;
    public byte ApplicationId { get; set; } 
     
    public virtual ICollection<ResourceFile> ResourceFiles { get; set; }
}