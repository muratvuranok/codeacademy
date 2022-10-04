using Code.Application.Common.Interfaces;

namespace Code.Infrastructure.Service;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
