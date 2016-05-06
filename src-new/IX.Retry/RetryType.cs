using System;

namespace IX.Retry
{
    [Flags]
    public enum RetryType
    {
        None = 0,
        Times = 1,
        Until = 2,
        For = 4
    }
}