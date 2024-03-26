namespace Project1;

using System;

public class OverfillException : Exception
{
    public OverfillException() : base("Cargo mass exceeds the container's capacity")
    {
    }
}
