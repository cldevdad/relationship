using System;

namespace Relationship.Models.Exceptions;

/// <summary>
/// Exception thrown when the Trust component in a relationship has been broken
/// beyond repair.
/// </summary>
public class BrokenTrustException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BrokenTrustException"/>
    /// class with a default message.
    /// </summary>
    public BrokenTrustException()
        : base("Trust has been broken and cannot be restored.")
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BrokenTrustException"/>
    /// class with a custom message.
    /// </summary>
    /// <param name="message">The custom message that describes the
    /// error.</param>
    public BrokenTrustException(string message)
        : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BrokenTrustException"/>
    /// class with a custom message and an inner exception.
    /// </summary>
    /// <param name="message">The custom message that describes the
    /// error.</param>
    /// <param name="innerException">The exception that is the cause of the
    /// current exception.</param>
    public BrokenTrustException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}

