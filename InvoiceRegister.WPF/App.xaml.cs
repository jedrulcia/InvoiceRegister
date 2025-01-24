﻿using InvoiceRegister.EntityFramework;
using InvoiceRegister.WPF.Factories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;

namespace InvoiceRegister.WPF
{
	public partial class App : Application
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			IServiceProvider serviceProvider = CreateServiceProvider();

			base.OnStartup(e);
		}

		private IServiceProvider CreateServiceProvider()
		{
			IServiceCollection services = new ServiceCollection();

			services.AddDbContext<AppDbContext>(options =>
			options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=InvoiceRegister;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=False"));

			services.AddScoped<IWindowFactory, WindowFactory>();

			return services.BuildServiceProvider();
		}
	}

}
