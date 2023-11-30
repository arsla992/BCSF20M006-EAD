using System;
using TemplateDesignPattren;
public class WebPage
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Generating Home Page:");
        HomePage homePage = new HomePage();
        homePage.GeneratePage();

        Console.WriteLine("\nGenerating About Page:");
        AboutPage aboutPage = new AboutPage();
        aboutPage.GeneratePage();
    }
}

