namespace Agent.UI.ViewModels;

public class MainWindowViewModel
{
    public HeaderViewModel Header { get; } = new();

    public ConversationViewModel Conversation { get; } = new();

    public ComposerViewModel Composer { get; } = new();

    public MainWindowViewModel()
    {
        Composer.MessageSubmitted += OnMessageSubmitted;
    }

    private void OnMessageSubmitted(string message)
    {
        Conversation.AddUserMessage(message);

        // temporary fake response
        Conversation.AddAssistantMessage(
            $"Agent received: {message}");
    }
}