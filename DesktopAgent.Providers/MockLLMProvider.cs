namespace DesktopAgent.Providers;

public class MockLLMProvider : ILLMProvider
{
    public async Task<LLMResponse> CompleteAsync(string prompt)
    {
        // Simulate a delay
        await Task.Delay(500);

        // For demo, if prompt contains "run powershell", return a tool call
        if (prompt.ToLower().Contains("run powershell"))
        {
            return new LLMResponse
            {
                Content = "I'll run a PowerShell command for you.",
                ToolName = "PowerShell",
                ToolInput = "Get-Date"
            };
        }

        return new LLMResponse
        {
            Content = $"Mock response to: {prompt}"
        };
    }
}