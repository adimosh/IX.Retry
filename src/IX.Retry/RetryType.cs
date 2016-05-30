using System;

namespace IX.Retry
{
    /// <summary>
    /// The ntype of retry procedure.
    /// </summary>
    [Flags]
    public enum RetryType
    {
        None = 0,
        Times = 1,
        Until = 2,
        For = 4
    }
}