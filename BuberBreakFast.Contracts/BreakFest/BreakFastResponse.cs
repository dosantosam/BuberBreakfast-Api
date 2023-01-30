namespace BuberBreakFest.Contracts.BreakFest;

public record BreakFastResponse(
    Guid Id,
    string Name,
    string Description,
    DateTime startDateTime,
    DateTime EndDateTime,
    DateTime LastModifiedDateTime,
    List<string> Savory,
    List<string> Sweet);