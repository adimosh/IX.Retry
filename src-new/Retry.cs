public class Retry
{
    public void Now(System.Action action)
    {
        action();
    }
}