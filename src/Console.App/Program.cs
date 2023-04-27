using System.Reflection;

Console.WriteLine("Hello, World!");
Console.WriteLine($"CultureInfo: {Assembly.GetExecutingAssembly().GetName().CultureInfo}");		
Console.WriteLine($"Name: {Assembly.GetExecutingAssembly().GetName().Name}");
Console.WriteLine($"Title: {Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>()?.Title}");
Console.WriteLine($"Product: {Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyProductAttribute>()?.Product}");
Console.WriteLine($"Company: {Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyCompanyAttribute>()?.Company}");
Console.WriteLine($"Description: {Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyDescriptionAttribute >()?.Description}");
Console.WriteLine($"Copyright: {Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyCopyrightAttribute >()?.Copyright}");
Console.WriteLine($"Trademark: {Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTrademarkAttribute >()?.Trademark}");
Console.WriteLine($"Version: {Assembly.GetExecutingAssembly().GetName().Version}");
Console.WriteLine($"FileVersion: {Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyFileVersionAttribute>()?.Version}");
Console.WriteLine($"InformationalVersion: {Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion}");
Console.WriteLine($"Configuration: {Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyConfigurationAttribute>()?.Configuration}");
