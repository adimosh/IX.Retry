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
        /// <value>A <see cref="RetryPolicy">retry policy delegate</see> that should be used in an operation.</value>
        RetryPolicy ExecuteRetryPolicy { get; }
    }
}
