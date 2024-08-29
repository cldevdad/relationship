using System;

namespace Relationship.Models.Exceptions;

/// <summary>
/// Exception thrown when the Patience component in a relationship is
/// insufficient to sustain the relationship.
/// </summary>
public class LackOfPatienceException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LackOfPatienceException"/>
    /// class with a default message.
    /// </summary>
    public LackOfPatienceException()
        : base("There is not enough patience left to continue.")
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="LackOfPatienceException"/>
    /// class with a custom message.
    /// </summary>
    /// <param name="message">The custom message that describes the
    /// error.</param>
    public LackOfPatienceException(string message)
        : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="LackOfPatienceException"/>
    /// class with a custom message and an inner exception.
    /// </summary>
    /// <param name="message">The custom message that describes the
    /// error.</param>
    /// <param name="innerException">The exception that is the cause of the
    /// current exception.</param>
    public LackOfPatienceException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}

