

using Productivity.Domain.Entities;

namespace Productivity.Application.Interfaces;

public interface IFocusSessionRepository
{
    public Task<bool> GetActiveSession();

    public Task CreateDistractionEvent();

    public Task ReduceFocusScore();

    public Task TriggerAlert();

}