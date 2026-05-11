namespace Agent.Tools;

public interface IToolRegistry
{
    void Register(IAgentTool tool);
    IAgentTool? Get(string name);
    IEnumerable<IAgentTool> GetAll();
}