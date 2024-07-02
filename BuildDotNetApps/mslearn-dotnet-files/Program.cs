using Newtonsoft.Json;

var currentDir = Directory.GetCurrentDirectory();
var storesDirectory = Path.Combine(currentDir, "stores");

var salesTotalDir = Path.Combine(currentDir, "salesTotalDir");
Directory.CreateDirectory(salesTotalDir);

var salesFiles = FindSales(storesDirectory);
var salesTotal = CalculteSalesTotal(salesFiles);

// if (!File.Exists(Path.Combine(salesTotalDir, "totals.txt")))
// {
//     File.WriteAllText(Path.Combine(salesTotalDir, "totals.txt"), string.Empty);
// }

File.AppendAllText(Path.Combine(salesTotalDir, "totals.txt"), $"{salesTotal}{Environment.NewLine}");

IEnumerable<string> FindSales(string folderName)
{
    // List<string> salesFiles = [];
    // var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    // foreach (var file in foundFiles)
    // {
    //     if (file.EndsWith("sales.json"))
    //     {
    //         salesFiles.Add(file);
    //     }
    // }

    return Directory
        .EnumerateFiles(folderName, "*", SearchOption.AllDirectories)
        .Where(file => Path.GetExtension(file) == ".json");
}

double CalculteSalesTotal(IEnumerable<string> salesFiels)
{
    double salesTotal = 0;

    foreach (var file in salesFiels)
    {
        string salesJson = File.ReadAllText(file);
        SalesData? data = JsonConvert.DeserializeObject<SalesData>(salesJson);
        salesTotal += data?.Total ?? 0;
    }

    return salesTotal;
}

record SalesData(double Total);
