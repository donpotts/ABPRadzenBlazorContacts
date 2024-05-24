using ContactsWebClientRadzen.Authentication;
using ContactsWebClientRadzen.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Radzen;
using System.Collections.Specialized;
using System.Web;

namespace ContactsWebClientRadzen;

public static class Extensions
{
    public static void AddBlazorServices(this IServiceCollection services, string baseAddress)
    {
        services.AddScoped<AppService>();

        services.AddScoped(sp
            => new HttpClient { BaseAddress = new Uri(baseAddress) });

        services.AddAuthorizationCore();
        services
            .AddScoped<AuthenticationStateProvider, JwtAuthenticationStateProvider>();

        services.AddScoped<DialogService>();
        services.AddScoped<NotificationService>();
        services.AddScoped<TooltipService>();
        services.AddScoped<ContextMenuService>();
    }

    
}
