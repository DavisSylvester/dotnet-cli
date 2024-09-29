// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using Cocona;
using Microsoft.Extensions.DependencyInjection;

var builder = CoconaApp.CreateBuilder();


builder.Services.AddLogging();
builder.Services.AddHttpClient();

var app = builder.Build();


CoconaApp.Run((string projectName) => {
    
    Console.WriteLine($"Hello, {projectName}");
    Process.Start("git", "--version");

}); 