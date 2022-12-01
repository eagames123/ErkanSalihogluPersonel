using Microsoft.Extensions.DependencyInjection;
using ES.Project.Business.Abstract;
using ES.Project.Business.Concrete;
using ES.Project.DataAccess.Abstract;
using ES.Project.DataAccess.Concrete;

namespace ES.Project.Business.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, CategoryDal>();
            
        }
    }
}
