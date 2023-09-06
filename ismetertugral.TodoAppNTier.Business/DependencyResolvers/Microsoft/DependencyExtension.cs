using AutoMapper;
using FluentValidation;
using ismetertugral.TodoAppNTier.Business.Interfaces;
using ismetertugral.TodoAppNTier.Business.Mappings.AutoMapper;
using ismetertugral.TodoAppNTier.Business.Services;
using ismetertugral.TodoAppNTier.Business.ValidationRules;
using ismetertugral.TodoAppNTier.DataAccess.Contexts;
using ismetertugral.TodoAppNTier.DataAccess.UniteOfWork;
using ismetertugral.TodoAppNTier.Dtos.WorkDtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ismetertugral.TodoAppNTier.Business.DependencyResolvers.Microsoft
{
    public static class DependencyExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddDbContext<TodoContext>(opt =>
            {
                opt.UseSqlServer("server=ISMETERTUGRALNB\\SQLEXPRESS;database=TodoDb;integrated security=true;TrustServerCertificate=true;");
                opt.LogTo(Console.WriteLine,LogLevel.Information);
            });

            var configuration = new MapperConfiguration(opt =>
            {
                opt.AddProfile(new WorkProfile());
            });

            var mapper = configuration.CreateMapper();

            services.AddSingleton(mapper);

            services.AddTransient<IValidator<WorkCreateDto>, WorkCreateDtoValidator>();
            services.AddTransient<IValidator<WorkUpdateDto>, WorkUpdateDtoValidator>();

            services.AddScoped<IUow, Uow>();
            services.AddScoped<IWorkService, WorkService>();
        }
    }
}
