using proxy;
using System;


public class RealImage : IImage
{
    private string fileName;

    public RealImage(string fileName)
    {
        this.fileName = fileName;
        LoadImage();
    }

    private void LoadImage()
    {
        Console.WriteLine($"Loading image: {fileName}");
    }

    public void Display()
    {
        Console.WriteLine($"Displaying image: {fileName}");
    }
}

public class VirtualImageProxy : IImage
{
    private RealImage realImage;
    private string fileName;

    public VirtualImageProxy(string fileName)
    {
        this.fileName = fileName;
    }

    public void Display()
    {
        if (realImage == null)
        {
            realImage = new RealImage(fileName);
        }
        realImage.Display();
    }
}


public class Image
{
    public static void Main(string[] args)
    {
        // Using the virtual proxy to delay image loading
        IImage image = new VirtualImageProxy("sample.jpg");

        image.Display();
    }
}
