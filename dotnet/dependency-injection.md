# Dependency Injection — ASP.NET Core

## What it is
A design pattern where dependencies are injected into a class instead of the class creating them directly. Promotes loose coupling and testability.

## Three Lifetimes
| Lifetime | Instance Created | Use For |
|----------|-----------------|---------|
| Transient | Every request to DI container | Stateless lightweight services |
| Scoped | Once per HTTP request | DbContext, Unit of Work |
| Singleton | Once for app lifetime | Cache, config, HttpClientFactory |

## Registration
builder.Services.AddTransient<IService, Service>();
builder.Services.AddScoped<IService, Service>();
builder.Services.AddSingleton<IService, Service>();

## Trap: Captive Dependency
Injecting Scoped into Singleton = Scoped never disposed.
ASP.NET Core throws InvalidOperationException at startup in Development.

## Constructor Injection (most common)
public class OrderService {
    private readonly IEmailService _email;
    public OrderService(IEmailService email) {
        _email = email;
    }
}
