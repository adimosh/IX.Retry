using System;

public class RetryOptions
{
    public RetryType Type { get; set; }
    
    #region Retry by number
    
    public int RetryTimes { get; set; }
    
    public void Times(int times)
    {
        if (times <= 0)
        {
            throw new ArgumentException(nameof(times));
        }
        
        Type |= RetryType.Times;
        RetryTimes = times;
    }
    
    public void Once()
    {
        Type |= RetryType.Times;
        RetryTimes = 1;
    }
    
    public void Twice()
    {
        Type |= RetryType.Times;
        RetryTimes = 2;
    }
    
    public void ThreeTimes()
    {
        Type |= RetryType.Times;
        RetryTimes = 3;
    }
    
    public void FiveTimes()
    {
        Type |= RetryType.Times;
        RetryTimes = 5;
    }
    
    #endregion
    
    #region Retry by timeSpan
    
    public TimeSpan RetryFor { get; set; }
    
    public void For(TimeSpan timeSpan)
    {
        Type |= RetryType.For;
        RetryFor = timeSpan;
    }
    
    public void For(int milliseconds)
    {
        Type |= RetryType.For;
        RetryFor = TimeSpan.FromMilliseconds(milliseconds);
    }
    
    #endregion
}