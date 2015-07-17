using System.Threading.Tasks;

namespace IX.Retry
{
    internal static class TaskExtensions
    {
        internal static Task EmptyTask
        {
            get
            {
#if NET40
                return TaskEx.FromResult(0);
#else
                return Task.FromResult(0);
#endif
            }
        }
    }
}