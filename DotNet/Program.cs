using System;
using System.IO;
using System.IO.Compression;
using Assimp;

var context = new AssimpContext();

try
{
    var scene = context.ImportFile(args[0]);
    string glbFileName = "output.glb";

    if (!context.ExportFile(scene, glbFileName, "glb2"))
        throw new Exception("Export failed");

    Console.WriteLine($"Model exported as {glbFileName}");
}
catch (FileNotFoundException e)
{
    Console.WriteLine($"File not found: {e.Message}");
}
catch (Exception)
{
    Console.WriteLine("Model failed to export");
}
