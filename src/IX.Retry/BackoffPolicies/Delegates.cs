using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IX.Retry.BackoffPolicies
{
    /// <summary>
    /// A delegate representing a back-off policy between retries.
    /// </summary>
    /// <param name="retryCount">The maximum number of retries.</param>
    /// <param name="minBackoff">The minimal back-off time.</param>
    /// <param name="maxBackoff">The maximal back-off time.</param>
    /// <param name="deltaBackoff">The back-off delta between back-off attempts.</param>
    /// <returns>A <see cref="TimeSpan"/> to be used as back-off time.</returns>
    public delegate TimeSpan BackOffPolicy(int retryCount, TimeSpan minBackoff, TimeSpan maxBackoff, TimeSpan deltaBackoff);
}
