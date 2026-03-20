namespace Polymorphism;

internal class Duck : Bird
{
    /// <summary>
    /// Prints the duck voice.
    /// Return Type: void
    /// </summary>
    public override void Voice()
    {
        Console.WriteLine("Quack Quack");
    }
}
