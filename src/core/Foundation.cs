using System;

namespace Relationship.Models;

/// <summary>
/// Represents the core foundation of a relationship, focusing on key components
/// like Patience, Trust, and Love.
/// </summary>
public class Foundation
{
    private Patience _patience;
    private Trust _trust;
    private Love _love;

    /// <summary>
    /// Initializes a new instance of the <see cref="Foundation"/> class,
    /// setting up the initial levels of Patience, Trust, and Love.
    /// </summary>
    public Foundation()
    {
        this._patience = new Patience();
        this._trust = new Trust();
        this._love = new Love();
    }

    /// <summary>
    /// Nurtures the Patience component, helping it grow.
    /// </summary>
    public void NurturePatience()
    {
        _patience.Grow();
        Console.WriteLine("Patience has been nurtured.");
    }

    /// <summary>
    /// Builds the Trust component, strengthening it.
    /// </summary>
    public void BuildTrust()
    {
        _trust.Grow();
        Console.WriteLine("Trust has been built.");
    }

    /// <summary>
    /// Expresses love, which boosts all components.
    /// </summary>
    public void ExpressLove()
    {
        _love.Grow();
        _patience.Boost(_love.Intensity);
        _trust.Boost(_love.Intensity);
        Console.WriteLine("Love has been expressed. All components have been boosted.");
    }

    /// <summary>
    /// Evaluates if the foundation is strong based on current levels of
    /// Patience, Trust, and Love.
    /// </summary>
    /// <returns>True if the foundation is strong, otherwise false.</returns>
    public bool IsStrong()
    {
        return _patience.Level > 75 && _trust.Level > 75 && _love.Intensity > 50;
    }

    /// <summary>
    /// Handles conflicts, which can reduce the levels of Patience, Trust, and
    /// Love.
    /// </summary>
    public void HandleConflict()
    {
        _patience.Reduce();
        _trust.Reduce();
        _love.Reduce();
        Console.WriteLine("Conflict has occurred. Levels of Patience, Trust, and Love have been reduced.");
    }

    /// <summary>
    /// Shows the current status of the foundation, including levels of
    /// Patience, Trust, and Love.
    /// </summary>
    public void ShowStatus()
    {
        Console.WriteLine($"Foundation Status:\nPatience Level: {_patience.Level}\nTrust Level: {_trust.Level}\nLove Intensity: {_love.Intensity}");
        Console.WriteLine(IsStrong() ? "The foundation is strong." : "The foundation needs more care and attention.");
    }

    /// <summary>
    /// Introduces a random event that can either boost or reduce the levels of
    /// the components.
    /// </summary>
    public void RandomEvent()
    {
        var random = new Random();
        int eventOutcome = random.Next(1, 101);

        if (eventOutcome > 50)
        {
            _patience.Boost(10);
            _trust.Boost(10);
            _love.Boost(20);
            Console.WriteLine("A positive event occurred! All components have been boosted.");
        }
        else
        {
            _patience.Reduce();
            _trust.Reduce();
            _love.Reduce();
            Console.WriteLine("A negative event occurred. All components have been reduced.");
        }
    }
}

