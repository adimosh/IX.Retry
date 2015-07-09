using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IX.Retry
{
    /// <summary>
    /// Represents a stateful retry policy that can be used for retry operations.
    /// </summary>
    public interface IRetryPolicy
    {
        /// <summary>
        /// A retry policy delegate to be executed.
        /// </summary>
        RetryPolicy ExecutePolicy { get; }
    }
}
