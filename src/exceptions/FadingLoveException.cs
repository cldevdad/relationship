using System;

namespace Relationship.Models.Exceptions;

/// <summary>
/// Exception thrown when the Love component in a relationship has faded beyond a recoverable point.
/// </summary>
public class FadingLoveException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FadingLoveException"/> class with a default message.
    /// </summary>
    public FadingLoveException()
        : base("Love has faded and can no longer sustain the relationship.")
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FadingLoveException"/> class with a custom message.
    /// </summary>
    /// <param name="message">The custom message that describes the error.</param>
    public FadingLoveException(string message)
        : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FadingLoveException"/> class with a custom message and an inner exception.
    /// </summary>
    /// <param name="message">The custom message that describes the error.</param>
    /// <param name="innerException">The exception that is the cause of the current exception.</param>
    public FadingLoveException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}

