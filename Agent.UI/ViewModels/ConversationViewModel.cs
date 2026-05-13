using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Agent.UI.Models;

namespace Agent.UI.ViewModels;

public partial class ConversationViewModel : ObservableObject
{
    public ObservableCollection<ChatMessage> Messages { get; } = [];

    public void AddUserMessage(string text)
    {
        Messages.Add(new ChatMessage
        {
            Role = "User",
            Content = text
        });
    }

    public void AddAssistantMessage(string text)
    {
        Messages.Add(new ChatMessage
        {
            Role = "Assistant",
            Content = text
        });
    }
}