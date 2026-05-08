using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DesktopAgent.Agent;
using DesktopAgent.Providers;
using DesktopAgent.Tools;

namespace DesktopAgent.UI;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly AgentRunner _agent;

    public MainWindow()
    {
        InitializeComponent();

        var llm = new MockLLMProvider();
        var tools = new ToolRegistry();
        tools.Register(new PowerShellTool());

        _agent = new AgentRunner(llm, tools);
    }

    private async void SendButton_Click(object sender, RoutedEventArgs e)
    {
        var prompt = PromptTextBox.Text;
        if (string.IsNullOrWhiteSpace(prompt)) return;

        SendButton.IsEnabled = false;
        ResponseTextBlock.Text = "Processing...";

        try
        {
            var result = await _agent.RunAsync(prompt);
            ResponseTextBlock.Text = result;
        }
        catch (Exception ex)
        {
            ResponseTextBlock.Text = $"Error: {ex.Message}";
        }
        finally
        {
            SendButton.IsEnabled = true;
        }
    }
}