namespace PRO.SharedKernel.Domain.Application.NewEstimateDomain;

public partial class EmailLog : Entity<Guid>
{
    

    public Guid AccountId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public Guid EmailTemplateId { get; set; }
    public DateTime? SentOn { get; set; }
    public bool IsScheduled { get; set; }
    public string? ScheduleUniqueId { get; set; }
    public DateTime? ScheduledOn { get; set; }
    public string? EmailTrackingId { get; set; }
    public string? EmailContent { get; set; }
    public string? Sender { get; set; }
    public string? Receivers { get; set; }

    public virtual Account Account { get; set; } = null!;
 
}


