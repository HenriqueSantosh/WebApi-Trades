﻿using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebLinkTrades.Dados.Context;
using WebLinkTrades.Dados.ImplemantationTrades;
using WebLinkTrades.Dados.Interfaces;
using WebLinkTrades.Dados.Repository;
using WebLinkTrades.DTO.Mappings;
using WebLinkTrades.Services.Implemantation;
using WebLinkTrades.Services.Interfaces;

namespace WebLinkTrades
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ITradesRepository, TradesRepository>();
            services.AddScoped(typeof(IRepository<>),typeof( BaseRespository<>));

            services.AddTransient<ITradesServices, TradesServices>();

            services
                .AddDbContext<BaseContext>(
                                options => options
                                .UseSqlServer(Configuration
                                .GetConnectionString("DefaultConnection"))
                            );

            services.AddSingleton( new  MapperConfiguration( mapper => {
                  mapper.AddProfile(new MappingProfile());
            }).CreateMapper());


            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    builder =>
                    {
                        builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                    });
            });

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
