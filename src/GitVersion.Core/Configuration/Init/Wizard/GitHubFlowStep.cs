using GitVersion.Configuration.Init.SetConfig;
using GitVersion.Logging;

namespace GitVersion.Configuration.Init.Wizard;

internal class GitHubFlowStep : GlobalModeSetting
{
    public GitHubFlowStep(IConsole console, IFileSystem fileSystem, ILog log, IConfigInitStepFactory stepFactory) : base(console, fileSystem, log, stepFactory)
    {
    }

    protected override string GetPrompt(ConfigurationBuilder configurationBuilder, string workingDirectory) => $"By default GitVersion will only increment the version when tagged{System.Environment.NewLine}{System.Environment.NewLine}" + base.GetPrompt(configurationBuilder, workingDirectory);
}
