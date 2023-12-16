﻿using Core.Abstracts;
using Core.Business.Rules;
using Core.Concretes;
using Core.Rules;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Core;

public static class BusinessServiceRegistration
{

    public static IServiceCollection AddBusinessServices(this IServiceCollection services)
    {
        services.AddSubClassesOfType(Assembly.GetExecutingAssembly(), typeof(BaseBusinessRules));
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        services.AddScoped<IProductService, ProductManager>();
        services.AddScoped<ICategoryService, CategoryManager>();

        services.AddScoped<CategoryBusinessRules>();
        services.AddScoped<ProductBusinessRules>();

        return services;
    }
    public static IServiceCollection AddSubClassesOfType(
    this IServiceCollection services,
    Assembly assembly,
    Type type,
    Func<IServiceCollection, Type, IServiceCollection>? addWithLifeCycle = null)
    {
        var types = assembly.GetTypes().Where(t => t.IsSubclassOf(type) && type != t).ToList();
        foreach (var item in types)
            if (addWithLifeCycle == null)
                services.AddScoped(item);

            else
                addWithLifeCycle(services, type);
        return services;
    }
}