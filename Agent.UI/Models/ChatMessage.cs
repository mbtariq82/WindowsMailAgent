namespace Agent.UI.Models;

public class ChatMessage
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Role { get; set; } = string.Empty;
    // "User", "Assistant", "System"

    public string Content { get; set; } = string.Empty;

    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}