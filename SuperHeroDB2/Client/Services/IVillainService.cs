//using Microsoft.AspNetCore.Components;
using SuperHeroDB.Shared;
using System.Net.Http.Json;

namespace SuperHeroDB.Client.Services
{
    public interface IVillainService
    {
       
        List<Villain> Villains { get; set; }
        Task GetVillains();
        
    }
}
