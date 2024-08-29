namespace Relationship.Models;

/// <summary>
/// Represents the Trust component of a relationship.
/// </summary>
public class Trust
{
    public int Level { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Trust"/> class with a
    /// default level.
    /// </summary>
    public Trust()
    {
        Level = 50; // Default initial level
    }

    /// <summary>
    /// Increases the level of Trust.
    /// </summary>
    public void Grow()
    {
        Level += 10;
    }

    /// <summary>
    /// Boosts the level of Trust by a specified amount.
    /// </summary>
    /// <param name="amount">The amount to boost.</param>
    public void Boost(int amount)
    {
        Level += amount;
    }

    /// <summary>
    /// Reduces the level of Trust.
    /// </summary>
    public void Reduce()
    {
        Level -= 10;
    }
}

