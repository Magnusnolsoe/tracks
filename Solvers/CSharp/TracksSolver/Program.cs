// See https://aka.ms/new-console-template for more information
using CommandLine;
using TracksSolver;

Parser.Default.ParseArguments<Options>(args).WithParsed(Run);

void Run(Options options)
{
    var dir = new DirectoryInfo(options.TracksDirectory);
    var file = dir.GetFiles().FirstOrDefault()!;
    var lines = File.ReadLines(file.FullName);
    foreach (var line in lines)
        Console.WriteLine(line);
}

class Options
{
    [Option('d', "directory", Required = true, HelpText = "Tracks directory")]
    public string TracksDirectory { get; set; } = "";
}