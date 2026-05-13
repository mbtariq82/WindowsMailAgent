namespace Agent.UI.Models;

public class AgentStatus
{
    public bool IsConnected { get; set; }

    public bool IsBusy { get; set; }

    public string StatusText { get; set; } = "Disconnected";
}