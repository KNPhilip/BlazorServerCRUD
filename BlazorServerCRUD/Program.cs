global using Microsoft.EntityFrameworkCore;
global using BlazorServerCRUD.Models;
global using BlazorServerCRUD.Data;
global using BlazorServerCRUD.Services.GameService;
global using Microsoft.AspNetCore.Components;
global using Mapster;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDbContext<GameContext>(options => options.UseInMemoryDatabase("videogamedb"));
builder.Services.AddScoped<IGameService, GameService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();