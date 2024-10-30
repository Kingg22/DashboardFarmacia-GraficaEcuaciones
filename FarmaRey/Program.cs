using FarmaRey.contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FarmaRey
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var services = new ServiceCollection();
            // Crear conexión con la base de datos (No pude usar el json)
            services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql("Host=localhost;Port=5432;Database=farmarey;Username=postgres;Password="));
            // añadir los forms al service collection para que le coloque las dependencias
            services.AddTransient<FrmDashboard>();
            services.AddTransient<FrmAgregarMed>();
            var serviceProvider = services.BuildServiceProvider();
            // inyectar la dependencia requerida del forms
            var form = serviceProvider.GetRequiredService<FrmDashboard>();
            // iniciar la aplicación
            // Los logs no se ven por consola I don't know why, pero estarán en el archivo
            Application.Run(form);
        }
    }
}