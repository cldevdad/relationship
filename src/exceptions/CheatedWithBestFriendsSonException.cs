using System;

namespace Relationship.Models.Exceptions;

/// <summary>
/// Exception thrown when a partner cheats with the best friend's son, causing
/// severe damage to the relationship.
/// </summary>
public class CheatedWithBestFriendsSonException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see
    /// cref="CheatedWithBestFriendsSonException"/> class with a default
    /// message.
    /// </summary>
    public CheatedWithBestFriendsSonException()
        : base("A devastating betrayal has occurred: cheating with the best friend's son.")
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see
    /// cref="CheatedWithBestFriendsSonException"/> class with a custom message.
    /// </summary>
    /// <param name="message">The custom message that describes the
    /// error.</param>
    public CheatedWithBestFriendsSonException(string message)
        : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see
    /// cref="CheatedWithBestFriendsSonException"/> class with a custom message
    /// and an inner exception.
    /// </summary>
    /// <param name="message">The custom message that describes the
    /// error.</param>
    /// <param name="innerException">The exception that is the cause of the
    /// current exception.</param>
    public CheatedWithBestFriendsSonException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}

