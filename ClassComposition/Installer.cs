using System;

namespace ClassComposition;

public class Installer
{
    private readonly Logger _logger;

    public Installer(Logger logger)
    {
        _logger = logger;
    }

    public void Install()
    {
        System.Console.WriteLine("We are installing the application.");
    }
}
