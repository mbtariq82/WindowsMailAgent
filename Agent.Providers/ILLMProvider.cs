namespace Agent.Providers;

public interface ILLMProvider
{
    Task<LLMResponse> CompleteAsync(string prompt);
}
public class LLMResponse
{
    public string Content { get; set; } = "";

    // Tool execution fields 
    public string? ToolName { get; set; }
    public string? ToolInput { get; set; }
}