global using System.Net.NetworkInformation;
global using System.Net.Http;
global using System.Net.Http.Json;
global using Microsoft.AspNetCore.Components;
global using Microsoft.AspNetCore.Components.Forms;
global using Microsoft.AspNetCore.Components.Routing;
global using Microsoft.AspNetCore.Components.Web;
global using Microsoft.AspNetCore.Components.Web.Virtualization;
global using Microsoft.AspNetCore.Components.WebAssembly.Http;
global using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
global using Microsoft.JSInterop;
global using MudBlazor;
global using MudBlazor.Services;
global using TaskDragNDropBlazor;
global using TaskDragNDropBlazor.Shared;
global using static TaskDragNDropBlazor.EventHandlers;

public static class Extensions
{
    public static string RemovePrefix(this string source, string prefix) => source.Replace(prefix, "");
}