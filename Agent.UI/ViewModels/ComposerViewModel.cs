using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Agent.UI.ViewModels;

public partial class ComposerViewModel : ObservableObject
{
    [ObservableProperty]
    private string currentMessage = string.Empty;

    public event Action<string>? MessageSubmitted;

    [RelayCommand]
    private void Send()
    {
        if (string.IsNullOrWhiteSpace(CurrentMessage))
            return;

        MessageSubmitted?.Invoke(CurrentMessage);

        CurrentMessage = string.Empty;
    }
}