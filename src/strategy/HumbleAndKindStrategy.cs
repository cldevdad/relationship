using System;
using Relationship.Models.Exceptions;

namespace Relationship.Strategy;

/// <summary>
/// Represents the concept of being humble and kind in a relationship. This
/// class provides methods to handle exceptions in a compassionate and
/// understanding manner.
/// </summary>
public class HumbleAndKind
{
    /// <summary>
    /// Handles the BrokenTrustException by acknowledging the breach and
    /// suggesting ways to rebuild trust.
    /// </summary>
    /// <param name="ex">The BrokenTrustException to handle.</param>
    public void Handle(BrokenTrustException ex)
    {
        Console.WriteLine($"Humble Response: {ex.Message}");
        Console.WriteLine("Solution: Trust has been broken, but let's take the first steps to rebuild it. This will require time, honesty, and open communication.");
    }

    /// <summary>
    /// Handles the LackOfPatienceException by recognizing the strain and
    /// suggesting ways to practice patience.
    /// </summary>
    /// <param name="ex">The LackOfPatienceException to handle.</param>
    public void Handle(LackOfPatienceException ex)
    {
        Console.WriteLine($"Humble Response: {ex.Message}");
        Console.WriteLine("Solution: Patience is thin, but let's slow down, take deep breaths, and focus on understanding each other's perspectives.");
    }

    /// <summary>
    /// Handles the FadingLoveException by acknowledging the fading love and
    /// suggesting ways to rekindle it.
    /// </summary>
    /// <param name="ex">The FadingLoveException to handle.</param>
    public void Handle(FadingLoveException ex)
    {
        Console.WriteLine($"Humble Response: {ex.Message}");
        Console.WriteLine("Solution: Love has faded, but we can reignite it by spending quality time together, showing appreciation, and remembering why we fell in love.");
    }

    /// <summary>
    /// Handles the CheatedWithBestFriendsSonException by addressing the
    /// betrayal and offering a path towards healing or closure.
    /// </summary>
    /// <param name="ex">The CheatedWithBestFriendsSonException to
    /// handle.</param>
    public void Handle(CheatedWithBestFriendsSonException ex)
    {
        Console.WriteLine($"Humble Response: {ex.Message}");
        Console.WriteLine("Solution: This is a deep betrayal, and it will take immense strength to heal. Consider seeking professional help, and focus on self-care and understanding.");
    }
}

