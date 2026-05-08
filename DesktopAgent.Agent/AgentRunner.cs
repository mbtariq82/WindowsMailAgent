namespace DesktopAgent.Agent;

using DesktopAgent.Providers;
using DesktopAgent.Tools;
public class AgentRunner
{
    private readonly ILLMProvider _llm;
    private readonly IToolRegistry _tools;

    public AgentRunner(ILLMProvider llm, IToolRegistry tools)
    {
        _llm = llm;
        _tools = tools;
    }

    public async Task<string> RunAsync(string input)
    {
        // 1. Ask LLM what to do
        var response = await _llm.CompleteAsync(input);

        // 2. If tool requested
        if (!string.IsNullOrWhiteSpace(response.ToolName))
        {
            var tool = _tools.Get(response.ToolName);

            if (tool == null)
                return $"Tool not found: {response.ToolName}";

            var result = await tool.ExecuteAsync(response.ToolInput, CancellationToken.None);

            // 3. Send result back to LLM (optional second pass)
            var finalResponse = await _llm.CompleteAsync($"Tool result: {result}");
            return finalResponse.Content;
        }

        // 4. Otherwise just return response
        return response.Content;
    }
}