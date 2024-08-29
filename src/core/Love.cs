namespace Relationship.Models;

/// <summary>
/// Represents the Love component of a relationship.
/// </summary>
public class Love
{
    public int Intensity { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Love"/> class with a
    /// default intensity.
    /// </summary>
    public Love()
    {
        Intensity = 70;
    }

    /// <summary>
    /// Increases the intensity of Love.
    /// </summary>
    public void Grow()
    {
        Intensity += 15;
    }

    /// <summary>
    /// Boosts the intensity of Love by a specified amount.
    /// </summary>
    /// <param name="amount">The amount to boost.</param>
    public void Boost(int amount)
    {
        Intensity += amount;
    }

    /// <summary>
    /// Reduces the intensity of Love.
    /// </summary>
    public void Reduce()
    {
        Intensity -= 5;
    }
}

