using ExpertPlanner.Models;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
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


        services.AddRazorPages();
        services.AddMvc();
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlite(_configuration.GetConnectionString("DefaultConnection")));
        services.AddSession();
        services.AddMvc().AddRazorPagesOptions(options =>
        {
            options.Conventions.AddPageRoute("/UserItems/UserIndex", "UserItems/UserIndex/{weekNumber}");
        });
        services.AddAntiforgery(options =>
        {

            options.HeaderName = "X-CSRF-TOKEN";
            options.Cookie.Name = "Z-XSRF-COOKIE";
            options.FormFieldName = "Y-XSRF-TOKEN";
        });
        services.AddAuthentication("CookieAuthScheme")
            .AddCookie("CookieAuthScheme", options =>
    {
        options.LoginPath = "/";
    });
        services.AddAuthorization(options =>
        {
            options.FallbackPolicy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .Build();
        });
        services.AddIdentity<ApplicationUser, IdentityRole>(ConfigureIdentityOptions)

    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders()
    .AddUserManager<UserManager<ApplicationUser>>()
    .AddUserStore<UserStore<ApplicationUser, IdentityRole, ApplicationDbContext, string, IdentityUserClaim<string>, IdentityUserRole<string>, IdentityUserLogin<string>, IdentityUserToken<string>, IdentityRoleClaim<string>>>();
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
        app.UseSession();
        app.UseRouting();
        app.UseAntiforgery();

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


        using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
        {
            var userManager = serviceScope.ServiceProvider.GetService<UserManager<ApplicationUser>>();
            var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
            DbSeeder.Seed(context, userManager).Wait();
        }
    }
}
