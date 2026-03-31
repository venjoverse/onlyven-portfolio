using VenxWeb.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services
    .AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Error handling
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

// Middleware
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

// Map components
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();