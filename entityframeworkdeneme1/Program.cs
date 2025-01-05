using DBConnectProject.context;
using DBConnectProject.controller;
using DBConnectProject.repository;
using DBConnectProject.service;
using entityframeworkdeneme1.service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace entityframeworkdeneme1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceCollection services = new ServiceCollection();

            services.AddScoped<IMusteriRepository, MusteriRepository>();
            services.AddScoped<IMusteriService , MusteriService>();

            MusteriController m= new MusteriController(services.BuildServiceProvider().GetService<IMusteriService>());
            var a=m.getMusteriByEmail("aysefatma@gmail.com");
            Console.WriteLine("adasd");
        }
    }
}
