using System.Reflection.Metadata.Ecma335;

namespace Productivity.Application.Interfaces;

public interface IBlockedApplicationRepository
{
    public Task<bool> IsBlockedApplication();

    public Task<TimeSpan> GetTimeSpan();

    public Task<String> GetByProcessName(string name);
}