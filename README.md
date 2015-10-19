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
int x = With.Retry(GetNumberOfHeadbangsPerMinuteFromRemoteServer, param1, param2, param3, Policy.TimeBased<SomeTransportException>(TimeSpan.FromSeconds(10)));
```

Asynchronous operations are also supported.

Original code:
```c#
int x = await GetNumberOfHeadbangsPerMinuteFromRemoteServer(param1, param2, param3);
```
With retry:
```c#
int x = await With.RetryAsync(GetNumberOfHeadbangsPerMinuteFromRemoteServer, param1, param2, param3, Policy.TimeBased<SomeTransportException>(TimeSpan.FromSeconds(10)));
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
    return getNumberOfHeadbangsPerMinuteFromRemoteServer.WithRetry(param1, param2, param3, Policy.TimeBased<SomeTransportException>(TimeSpan.FromSeconds(10)));
}
```

Asynchronous support as well.

Original code:
```c#
public async Task<int> SomeMethod(Func<Type1, Type2, Type3, Task<int>> getNumberOfHeadbangsPerMinuteFromRemoteServer, Type1 param1, Type2 param2, Type3 param3)
{
    return await getNumberOfHeadbangsPerMinuteFromRemoteServer(param1, param2, param3);
}
```
With retry:
```c#
public async Task<int> SomeMethod(Func<Type1, Type2, Type3, Task<int>> getNumberOfHeadbangsPerMinuteFromRemoteServer, Type1 param1, Type2 param2, Type3 param3)
{
    return await getNumberOfHeadbangsPerMinuteFromRemoteServer.WithRetryAsync(param1, param2, param3, Policy.TimeBased<SomeTransportException>(TimeSpan.FromSeconds(10)));
}
```

Or you can completely forget about explicitly specifying the policy.

One might ask "What if I want to asynchronously wait for a synchronous method?" That is possible as well, as you will notice, with the same syntax.
```c#
public async Task<int> SomeMethod(Func<Type1, Type2, Type3, int> getNumberOfHeadbangsPerMinuteFromRemoteServer, Type1 param1, Type2 param2, Type3 param3)
{
    return await getNumberOfHeadbangsPerMinuteFromRemoteServer.WithRetryAsync(param1, param2, param3, Policy.TimeBased<SomeTransportException>(TimeSpan.FromSeconds(10)));
}
```


Synchronous vs Asynchronous
---------------------------

Please be advised that, due to threading and compatibility issues, and the desire to offer only the best practices available, the synchronous retry calls will retry for as many times as specified, but they will not delay.

If delays are needed, due to the exponential nature of retry policies, the thread can be blocked for a long time. It is therefore advisable to use the asynchronous methods if delay is necessary.

Installation
------------

In order to install this package, please either search for "IX.Retry" in the NuGet Package Manager or use the NuGet Package Manager Console:

```
Install-Package IX.Retry
```

Starting 0.2.0, a different way of installing and using this library is provided.

On some projects, NuGet packages do not properly install, due to the unavailability of the related NuGet packages. This appears to be by design.

Therefore, only code that can actually run with the "dotnet" targeting and also .NET 4.0 will be available in the main project, and a separate project is necessary for the PCL.

You can, of course, use the package normally on any .NET 4.5-targeting system (Xamarin-included libraries for iOS and Android), however, this support is achieved at a few costs:
1. There has to be an extra project involved (IX.Retry.PCL).
2. Not all configurations are supported (as of currently, we do not know whether Silverlight is properly supported, but we assume it is not).
3. Xamarin- and Mono-based applications are supported, however, please use at your own risk.
4. IntelliSense throws a lot of errors which are, in fact, false, due to the improper tooling available in the project. Hopefully, this will be corrected in a future version of ASP.NET vNext.

Currently, only projects that target .NET 4.0 and above (including Core and DNX) are fully supported.

License
-------

License information can be found [here](https://github.com/adimosh/IX.Retry/blob/master/LICENSE.md).

Credits
-------

The project is based on a variety of other open-source projects, with no code copied, but adapted.