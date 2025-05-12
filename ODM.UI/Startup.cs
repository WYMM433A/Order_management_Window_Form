using Microsoft.Extensions.DependencyInjection;
using ODM.BLL;
using ODM.DAL;
using ODM.UI;

public static class Startup
{
    public static ServiceProvider ConfigureServices()
    {
        var services = new ServiceCollection();

        // Register DbContext
        services.AddSingleton<AppDbContext>();

        // Register Repositories
        services.AddSingleton<OrderRepository>();
        services.AddSingleton<ItemRepository>();
        services.AddSingleton<AgentRepository>();

        // Register Services
        services.AddSingleton<OrderService>();
        services.AddSingleton<ItemService>();

        // Register Forms
        services.AddTransient<MainForm>();

        return services.BuildServiceProvider();
    }
}