using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Bussiness_Logic.Interfaces;
using Bussiness_Logic.Services;

namespace Bussiness_Logic
{
    public static class ServiceExtentions
    {
        public static void AddAutoMapper(this IServiceCollection services)
        {
            //services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddSingleton(provider => new MapperConfiguration(cfg =>
            {
                //cfg.AddProfile(new ApplicationProfile(provider.CreateScope().ServiceProvider.GetService</*IFileService*/>()!));
            }).CreateMapper());
        }

        public static void AddFluentValidators(this IServiceCollection services)
        {
            services.AddValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
        }
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IAccountsService, AccountsService>();
            services.AddScoped<IFileService, FileService>();
            services.AddScoped<IJwtService, JwtService>();
            services.AddScoped<IVideoService, VideoService>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<ILikeService, LikeService>();
            services.AddScoped<ISaveService, SaveService>();
        }
    }
}
