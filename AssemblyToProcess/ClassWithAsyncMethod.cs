﻿using System;
using System.Threading;
using System.Threading.Tasks;
using MethodTimer;

#if(DEBUG)
public class ClassWithAsyncMethod
{
    [Time]
    public async void Method()
    {
        Thread.Sleep(10);
    }
    [Time]
    public async Task<DateTime> MethodWithReturn()
    {
        Thread.Sleep(10);
        return DateTime.Now;
    }

    [Time]
    public async void MethodWithAwait()
    {
            await Task.Delay(2000);
    }
}
#endif