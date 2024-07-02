IEnumerable<string> listOfDirs = Directory.EnumerateDirectories(".");

// foreach (var item in listOfDirs)
// {
//     Console.WriteLine($"{item}");
// }

IEnumerable<string> files = Directory.EnumerateFiles("./obj");

foreach (var file in files)
{
    Console.WriteLine($"{file}");
}
