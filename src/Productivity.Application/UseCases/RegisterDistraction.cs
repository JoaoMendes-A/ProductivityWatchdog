using Productivity.Domain.Entities;
using Productivity.Application.Interfaces;
using Productivity.Application.Services;


namespace Productivity.Application.Usecases;

public class RegisterDistractionUseCase
{
    private readonly IFocusSessionRepository _focusSession;
    private readonly IBlockedApplicationRepository _blockedApplicationRepository;
    private readonly IFocusRules _focusRules;
    private readonly AlertService _alertService;
    private readonly DistractionService _distractionService;
    private readonly FocusService _focusService;

    public RegisterDistractionUseCase(
        IFocusSessionRepository focusSession,
        IBlockedApplicationRepository blockedApplicationRepository,
        IFocusRules focusRules,
        AlertService alertService,
        DistractionService distractionService,
        FocusService focusService)
    {
        _focusSession = focusSession;
        _blockedApplicationRepository = blockedApplicationRepository;
        _focusRules = focusRules;   
        _alertService = alertService;
        _distractionService = distractionService;
        _focusService = focusService;
    }

    public async Task ExecuteAsync(string processName)
    {
        
        var activeSession = 
            await _focusSession.GetActiveSession();

        if (activeSession == false)
            return;

        var blockedApplication =
            await _blockedApplicationRepository
                .GetByProcessName(processName);
        
        if (blockedApplication == null)
            return;

        var focusRule = 
            await _focusRules
                .GetApplicationId(blockedApplication.Id);
        
        if (focusRule == null)
            return;

        await _distractionService.RegisterDistraction();

        await _focusService.ReduceScore();

        await _alertService.Trigger();
    }
    
}