using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using RepoManager;
using Syncfusion.Blazor;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

//TODO: Put code to access azure Keyvault here 

// Declare constants for KeyVault
//const string AZUREAPPID = "ebf89c68-57a8-4142-b3d4-f542f14730bd";
//const string SYNCFUSIONSECRET = "e577Q~UQ4~bbpKqZxSc6StDHdUvyKE3sJGWzG";
const string KEYVAULTURI = "https://bulkrepokeyvault.vault.azure.net/";

//SecretClient secretClient = new SecretClient(new Uri(KEYVAULTURI), new DefaultAzureCredential());
//KeyVaultSecret sfkey = secretClient.GetSecret("SyncFusionLicenseKey");

//var sfLicenseKey = sfkey.Value.ToString();

// Register Syncfusion License
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("");

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Register SyncFusion Blazor Service
builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = true; });

await builder.Build().RunAsync();
