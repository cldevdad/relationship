namespace Relationship.Models;

/// <summary>
/// Represents the Patience component of a relationship.
/// </summary>
public class Patience
{
    public int Level { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Patience"/> class with a
    /// default level.
    /// </summary>
    public Patience()
    {
        Level = 50;
    }

    /// <summary>
    /// Increases the level of Patience.
    /// </summary>
    public void Grow()
    {
        Level += 10;
    }

    /// <summary>
    /// Boosts the level of Patience by a specified amount.
    /// </summary>
    /// <param name="amount">The amount to boost.</param>
    public void Boost(int amount)
    {
        Level += amount;
    }

    /// <summary>
    /// Reduces the level of Patience.
    /// </summary>
    public void Reduce()
    {
        Level -= 10;
    }
}

