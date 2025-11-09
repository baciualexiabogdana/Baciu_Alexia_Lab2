using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Baciu_Alexia_Lab2.Data;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddDbContext<Baciu_Alexia_Lab2Context>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("Baciu_Alexia_Lab2Context") ??
                      throw new InvalidOperationException("Connection string 'Baciu_Alexia_Lab2Context' not found.")));

builder.Services.AddDbContext<LibraryIdentityContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("LibraryIdentityContext") ??
                      throw new InvalidOperationException("Connection string 'LibraryIdentityContext' not found.")));

builder.Services.AddDefaultIdentity<IdentityUser>(options =>
        options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<LibraryIdentityContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();