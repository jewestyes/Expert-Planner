using ExpertPlanner.Models;
using ExpertPlanner.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Startup
{
    private readonly IConfiguration _configuration;

    public Startup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        ConfigureLogging(services);

        services.AddControllersWithViews();
        services.AddRazorPages();

        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlite(_configuration.GetConnectionString("DefaultConnection")));


        services.AddIdentity<ApplicationUser, IdentityRole>(ConfigureIdentityOptions)
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders()
    .AddUserManager<UserManager<ApplicationUser>>()
    .AddUserStore<UserStore<ApplicationUser, IdentityRole, ApplicationDbContext, string, IdentityUserClaim<string>, IdentityUserRole<string>, IdentityUserLogin<string>, IdentityUserToken<string>, IdentityRoleClaim<string>>>();

        services.AddTransient<FileVersionHelper>();
    }


    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();

            ApplyMigrations(app);
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthentication();
        app.UseAuthorization();

        ConfigureEndpoints(app);
    }

    private void ConfigureLogging(IServiceCollection services)
    {
        services.AddLogging(builder =>
        {
            builder.AddConsole();
        });
    }

    private void ConfigureIdentityOptions(IdentityOptions options)
    {
        options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
        options.User.RequireUniqueEmail = false;
        options.Password.RequireUppercase = false;
        options.Password.RequireLowercase = false;
        options.Password.RequireDigit = false;
        options.Password.RequireNonAlphanumeric = false;
    }

    private void ApplyMigrations(IApplicationBuilder app)
    {
        using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
        {
            var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
            context.Database.Migrate();
        }
    }

    private void ConfigureEndpoints(IApplicationBuilder app)
    {
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Authorization}/{action=Auth}/{id?}");
            endpoints.MapRazorPages();
        });

        // Вызываем сидер после применения миграций
        using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
        {
            var userManager = serviceScope.ServiceProvider.GetService<UserManager<ApplicationUser>>();
            var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
            DbSeeder.Seed(context, userManager).Wait();
        }
    }
}
