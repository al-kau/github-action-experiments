using System.Reflection;

Console.WriteLine("Hello, World!");
Console.WriteLine($"Version: {Assembly.GetExecutingAssembly().GetName().Version}");
Console.WriteLine($"Name: {Assembly.GetExecutingAssembly().GetName().Name}");
Console.WriteLine($"CultureInfo: {Assembly.GetExecutingAssembly().GetName().CultureInfo}");
Console.WriteLine($"Title: {Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>()?.Title}");
Console.WriteLine($"Company: {Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyCompanyAttribute>()?.Company}");
