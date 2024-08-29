using System;
using Relationship.Models;
using Relationship.Models.Exceptions;
using Relationship.Strategy;

namespace Relationship;

class Program
{
    static void Main(string[] args)
    {
        var foundation = new Foundation();
        var humbleAndKind = new HumbleAndKind();

        foundation.ShowStatus();

        foundation.NurturePatience();
        foundation.BuildTrust();

        foundation.ExpressLove();

        SimulateBrokenTrust(foundation, humbleAndKind);
        SimulateLackOfPatience(foundation, humbleAndKind);
        SimulateFadingLove(foundation, humbleAndKind);
        SimulateCheatedWithBestFriendsSon(foundation, humbleAndKind);

        foundation.RandomEvent();
        foundation.ShowStatus();

        Console.WriteLine("\nProgram completed. Remember, relationships need care and attention.");
    }

    static void SimulateBrokenTrust(Foundation foundation, HumbleAndKind humbleAndKind)
    {
        try
        {
            Console.WriteLine("\nSimulating a scenario where trust is severely broken...");
            throw new BrokenTrustException();
        }
        catch (BrokenTrustException ex)
        {
            humbleAndKind.Handle(ex);
        }
    }

    static void SimulateLackOfPatience(Foundation foundation, HumbleAndKind humbleAndKind)
    {
        try
        {
            Console.WriteLine("\nSimulating a scenario with lack of patience...");
            throw new LackOfPatienceException();
        }
        catch (LackOfPatienceException ex)
        {
            humbleAndKind.Handle(ex);
        }
    }

    static void SimulateFadingLove(Foundation foundation, HumbleAndKind humbleAndKind)
    {
        try
        {
            Console.WriteLine("\nSimulating a scenario where love fades...");
            throw new FadingLoveException();
        }
        catch (FadingLoveException ex)
        {
            humbleAndKind.Handle(ex);
        }
    }

    static void SimulateCheatedWithBestFriendsSon(Foundation foundation, HumbleAndKind humbleAndKind)
    {
        try
        {
            Console.WriteLine("\nSimulating a dramatic betrayal...");
            throw new CheatedWithBestFriendsSonException();
        }
        catch (CheatedWithBestFriendsSonException ex)
        {
            humbleAndKind.Handle(ex);
        }
    }
}

