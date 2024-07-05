using System.Globalization;

string numberString = "$1,234.56";
NumberStyles style = NumberStyles.Currency;
IFormatProvider provider = new CultureInfo("en-US");

if (decimal.TryParse(numberString, style, provider, out decimal result))
{
    Console.WriteLine($"Parsed successfully: {result}");
}
else
{
    Console.WriteLine("Failed to parse.");
}
