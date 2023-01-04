using ManufacturingData_Blazor.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
// Syncfusion package
using Syncfusion.Blazor;
// Radzen Blazor package
using Radzen;
using Radzen.Blazor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<SFCDashboardService>();
builder.Services.AddSyncfusionBlazor();
builder.Services.AddScoped<ProdDataService>();

var app = builder.Build();

// Syncfusion
//Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("");

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
