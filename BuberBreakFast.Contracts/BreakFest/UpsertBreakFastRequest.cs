namespace BuberBreakFest.Contracts.BreakFest;

public record UpsertBreakFastRequest(
    string Name,
    string Description,
    DateTime startDateTime,
    DateTime EndDateTime,
    List<string> Savory,
    List<string> Sweet);