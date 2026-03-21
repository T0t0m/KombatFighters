using KombatFighters;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

// 1. INITIALISATION
// On crée un "bâtisseur" (builder) préconfiguré pour une application WebAssembly.
var builder = WebAssemblyHostBuilder.CreateDefault(args);

// 2. LES BRANCHEMENTS (Liaison C# -> HTML)
// On indique que le composant racine "App" (ton fichier App.razor) 
// doit être injecté dans l'élément HTML qui possède l'ID "app" (dans index.html).
builder.RootComponents.Add<App>("#app");

// On autorise Blazor à modifier dynamiquement la balise <head> de ta page HTML.
// C'est grâce à cette ligne que le composant <PageTitle> de ton Home.razor fonctionne !
builder.RootComponents.Add<HeadOutlet>("head::after");

// 3. CONFIGURATION DES SERVICES (Boîte à outils globale)
// On ajoute le service HttpClient à l'application. 
// Cela te permettra de "demander" un HttpClient n'importe où dans tes pages 
// (via @inject) pour aller récupérer des données sur une API ou un serveur.
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// 4. DÉMARRAGE
// On construit l'application avec tous les paramètres ci-dessus et on la lance.
await builder.Build().RunAsync();