using KombatFighters;
using KombatFighters.Services; // <-- NOUVEAU : On indique où trouver nos services
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

// 1. INITIALISATION
var builder = WebAssemblyHostBuilder.CreateDefault(args);

// 2. LES BRANCHEMENTS (Liaison C# -> HTML)
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// 3. CONFIGURATION DES SERVICES (Boîte à outils globale)
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<DeckService>();
builder.Services.AddScoped<PdfExportService>();

// 4. DÉMARRAGE
await builder.Build().RunAsync();