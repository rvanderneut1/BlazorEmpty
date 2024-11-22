using BlazorEmpty.Components;
// hier geef ik weer aan dat ik de methodes in namespace BlazorEmpty.Data wil gebruiken
using BlazorEmpty.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

/* Hier geef ik aan dat ik de klasse MagicNumberService wil kunnen injecteren in pagina's
 Blazor regelt dan dat waar ik @inject MagicNumberService heb staan. Dat hij weet dat ik dan deze klasse
 bedoel. Wat AddSingleton doet is voor Periode 2 even niet belangrijk. */
builder.Services.AddSingleton<MagicNumberService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
