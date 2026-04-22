using Productivity.Domain.Entities;
using Productivity.Application.Interfaces;


namespace Productivity.Application.Usecases;

public class RegisterDistractionUseCase
{
    private readonly IFocusSessionRepository _focusSession;

    public RegisterDistractionUseCase(
        IFocusSessionRepository focusSession)
    {
        _focusSession = focusSession;
    }
    
}