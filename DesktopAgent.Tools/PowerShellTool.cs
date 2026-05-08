using System.Diagnostics;

namespace DesktopAgent.Tools;

public class PowerShellTool : IAgentTool
{
    public string Name => "PowerShell";

    public string Description => "Executes PowerShell commands and returns the output.";

    public async Task<string> ExecuteAsync(string input, CancellationToken ct)
    {
        var process = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-Command \"{input}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            }
        };

        process.Start();
        var output = await process.StandardOutput.ReadToEndAsync(ct);
        var error = await process.StandardError.ReadToEndAsync(ct);
        await process.WaitForExitAsync(ct);

        return string.IsNullOrWhiteSpace(error) ? output : $"Error: {error}\nOutput: {output}";
    }
}