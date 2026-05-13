namespace Agent.UI.Models;

public class Conversation
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Title { get; set; } = "New Conversation";

    public List<ChatMessage> Messages { get; set; } = [];
}