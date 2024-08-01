using Microsoft.EntityFrameworkCore;
using MyBackendApi.Data;
using MyBackendApi.Services.Implementations;
using MyBackendApi.Services.Interface;
using MyBackendApi.Services.Interfaces;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

        // Register services for DI
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IOrderService, OrderService>();
        services.AddScoped<ICustomerService, CustomerService>();
        services.AddScoped<IDeliveryService, DeliveryService>();
        services.AddScoped<IShopService, ShopService>();

        // Register the DeliveryService
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy",
                builder => builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
        });
        // Add services to the container
        //services.AddControllers();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseCors("CorsPolicy");

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }

    //public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    //{
    //    if (env.IsDevelopment())
    //    {
    //        app.UseDeveloperExceptionPage();
    //    }
    //    else
    //    {
    //        app.UseExceptionHandler("/Home/Error");
    //        app.UseHsts();
    //    }

    //    // Enable HTTPS redirection
    //    app.UseHttpsRedirection();
    //    app.UseStaticFiles();

    //    app.UseRouting();

    //    app.UseAuthorization();

    //    app.UseEndpoints(endpoints =>
    //    {
    //        endpoints.MapControllers();
    //    });
    //}

    //public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    //{
    //    if (env.IsDevelopment())
    //    {
    //        app.UseDeveloperExceptionPage();
    //    }
    //    else
    //    {
    //        app.UseExceptionHandler("/Home/Error");
    //        app.UseHsts();
    //    }

    //    app.UseHttpsRedirection();
    //    app.UseStaticFiles();

    //    app.UseRouting();

    //    app.UseAuthorization();

    //    app.UseEndpoints(endpoints =>
    //    {
    //        endpoints.MapControllerRoute(
    //            name: "default",
    //            pattern: "{controller=Home}/{action=Index}/{id?}");
    //        endpoints.MapControllers();
    //    });
    //}
}
