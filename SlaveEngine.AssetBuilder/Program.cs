using System.CommandLine;
using Spectre.Console;

namespace SlaveEngine.AssetBuilder;

class Program {
    static int Main(string[] args) {
        var inputOption = new Option<DirectoryInfo>("--input", "Path to the input SlaveMatrix/Assets folder");
        inputOption.SetDefaultValueFactory(() => new DirectoryInfo("./SlaveMatrix/Assets"));

        var outputOption = new Option<DirectoryInfo>("--output", "Path to the output directory for compiled .spart files");
        outputOption.SetDefaultValueFactory(() => new DirectoryInfo("./Assets"));

        var rootCommand = new RootCommand(
            "SlaveEngine Asset Builder — compiles YAML + SVG assets into .spart binaries");
        rootCommand.AddOption(inputOption);
        rootCommand.AddOption(outputOption);

        rootCommand.SetHandler((DirectoryInfo input, DirectoryInfo output) => {
            if (!input.Exists) {
                AnsiConsole.MarkupLine("[red]Error:[/] input directory not found: {0}", input.FullName);
                Environment.Exit(1);
            }

            var compiler = new Compiler(input.FullName, output.FullName);
            var result = compiler.Run();
            Environment.Exit(result);
        }, inputOption, outputOption);

        return rootCommand.Invoke(args);
    }
}
