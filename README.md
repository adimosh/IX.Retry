IX.Retry
========

An operational retry policy framework for any operations that might fail due to recoverable circumstances.

Each failure is handled based on a specific policy which can be customized (note: future rlease).

Usage
-----

Simple.

Original code:
```c#
int x = GetNumberOfHeadbangsPerMinuteFromRemoteServer(param1, param2, param3);
```
With retry:
```c#
Func<int> getHeadbangs = GetNumberOfHeadbangsPerMinuteFromRemoteServer;
int x = getHeadbangs.WithRetry(param1, param2, param3, Policy.TimeBasedPolicy(TimeSpan.FromSeconds(10), new[] { typeof(SomeTransportException) }));
```
Asynchronous operations are also supported.

Original code:
```c#
int x = await GetNumberOfHeadbangsPerMinuteFromRemoteServer(param1, param2, param3);
```
With retry:
```c#
Func<Task<int>> getHeadbangs = GetNumberOfHeadbangsPerMinuteFromRemoteServer;
int x = await getHeadbangs.WithRetry(param1, param2, param3, Policy.TimeBasedPolicy(TimeSpan.FromSeconds(10), new[] { typeof(SomeTransportException) }));
```

Credits
-------

The project is based on a variety of other open-source projects, with no code copied, but adapted.

<TODO: Add list>