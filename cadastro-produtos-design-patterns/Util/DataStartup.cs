﻿using Cadastro.Data;
using Microsoft.EntityFrameworkCore;

namespace cadastro_produtos_design_patterns.Util
{
    public static class DataStartup
    {
        public static IServiceCollection AddConectionBD(this IServiceCollection services, string mySqlConnection)
        {
            services.AddDbContext<AppDbContext>(options =>
            { 
                options.UseSqlServer(mySqlConnection, sqlOptions =>
                {
                    sqlOptions.EnableRetryOnFailure();
                    sqlOptions.MigrationsAssembly("Cadastro.Data");
                });
            });

            return services;
        }
    }
}
