namespace Abstraction;

internal class Laptop
{
    public string Brand { get; set; }
    public string Model { get; set; }

    /// <summary>
    /// Displays laptop brand and model details.
    /// Return Type: void
    /// </summary>
    public void LaptopDetails()
    {
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Model: {Model}");
    }

    /// <summary>
    /// Displays motherboard information (internal use only).
    /// Return Type: void
    /// </summary>
    private void MotherBoardInfo()
    {
        Console.WriteLine("MotherBoard Information");
    }
}
