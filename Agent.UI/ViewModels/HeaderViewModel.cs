using CommunityToolkit.Mvvm.ComponentModel;

namespace Agent.UI.ViewModels;

public partial class HeaderViewModel : ObservableObject
{
    [ObservableProperty]
    private string statusText = "Disconnected";

    [ObservableProperty]
    private bool isConnected;

    [ObservableProperty]
    private string emailAddress = "Not Logged In";
}