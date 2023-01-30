namespace BuberBreakFest.Contracts.BreakFest;

public record CreateBreakFastRequest(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Savory,
    List<string> Sweet);