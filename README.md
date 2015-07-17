IX.Retry
========

An operational retry policy framework for any operations that might fail due to recoverable circumstances.

Each failure is handled based on a specific policy which can be customized (note: future release).

Usage
-----

Simple.

Original code:
```c#
int x = GetNumberOfHeadbangsPerMinuteFromRemoteServer(param1, param2, param3);
```
With retry:
```c#
int x = With.Retry(GetNumberOfHeadbangsPerMinuteFromRemoteServer, param1, param2, param3, Policy.TimeBasedRetryPolicy<SomeTransportException>(TimeSpan.FromSeconds(10)));
```

Asynchronous operations are also supported.

Original code:
```c#
int x = await GetNumberOfHeadbangsPerMinuteFromRemoteServer(param1, param2, param3);
```
With retry:
```c#
int x = await With.RetryAsync(GetNumberOfHeadbangsPerMinuteFromRemoteServer, param1, param2, param3, Policy.TimeBasedRetryPolicy<SomeTransportException>(TimeSpan.FromSeconds(10)));
```

Extension methods are also available for delegate parameters.

Original code:
```c#
public int SomeMethod(Func<Type1, Type2, Type3, int> getNumberOfHeadbangsPerMinuteFromRemoteServer, Type1 param1, Type2 param2, Type3 param3)
{
    return getNumberOfHeadbangsPerMinuteFromRemoteServer(param1, param2, param3);
}
```
With retry:
```c#
public int SomeMethod(Func<Type1, Type2, Type3, int> getNumberOfHeadbangsPerMinuteFromRemoteServer, Type1 param1, Type2 param2, Type3 param3)
{
    return getNumberOfHeadbangsPerMinuteFromRemoteServer.WithRetry(param1, param2, param3, Policy.TimeBasedRetryPolicy<SomeTransportException>(TimeSpan.FromSeconds(10)));
}
```

Installation
------------

In order to install this package, please either search for "IX.Retry" in the NuGet Package Manager or use the NuGet Package Manager Console:

```
Install-Package IX.Retry
```

License
-------

License information can be found [here](https://github.com/adimosh/IX.Retry/blob/master/LICENSE.md).

Credits
-------

The project is based on a variety of other open-source projects, with no code copied, but adapted.

_TODO: Add list_