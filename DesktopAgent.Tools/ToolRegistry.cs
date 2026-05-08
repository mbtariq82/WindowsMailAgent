namespace DesktopAgent.Tools;

public interface IToolRegistry
{
    void Register(IAgentTool tool);
    IAgentTool? Get(string name);
    IEnumerable<IAgentTool> GetAll();
}

public class ToolRegistry : IToolRegistry
{
    private readonly Dictionary<string, IAgentTool> _tools = new();

    public void Register(IAgentTool tool)
    {
        _tools[tool.Name] = tool;
    }

    public IAgentTool? Get(string name)
    {
        return _tools.TryGetValue(name, out var tool) ? tool : null;
    }

    public IEnumerable<IAgentTool> GetAll()
    {
        return _tools.Values;
    }
}