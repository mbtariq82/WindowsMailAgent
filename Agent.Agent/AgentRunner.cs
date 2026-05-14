using System;
using Azure.AI.Projects;
using Azure.Identity;
using Microsoft.Agents.AI;

namespace Agent.Agent;

public class AgentRunner
{
    private readonly AIAgent _agent;

    public AgentRunner()
    {
        var endpoint = Environment.GetEnvironmentVariable("AZURE_OPENAI_ENDPOINT")
            ?? throw new InvalidOperationException("Set AZURE_OPENAI_ENDPOINT");
        var deploymentName = Environment.GetEnvironmentVariable("AZURE_OPENAI_DEPLOYMENT_NAME") ?? "gpt-4o-mini";

        _agent = new AIProjectClient(new Uri(endpoint), new DefaultAzureCredential())
            .AsAIAgent(
                model: deploymentName,
                instructions: "You are a friendly assistant. Keep your answers brief.",
                name: "HelloAgent");
    }

    public async Task<string> RunAsync(string input)
    {
        var response = await _agent.RunAsync<string>(input);
        return response.Result;
    }
}