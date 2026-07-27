using CedeSys_Api_v1.Configurations;

namespace CedeSys_Api_v1.Extensions
{
    public static class ConfigurationExtensions
    {

        public static IServiceCollection AddConfigurationOptions(
        this IServiceCollection services,
        IConfiguration configuration)
        {
            // registrar todas las opciones

            // jwt
            services.Configure<JwtOptions>(
                configuration.GetSection(JwtOptions.SectionName));

            // CORS
            services.Configure<CorsOptions>(
                configuration.GetSection(CorsOptions.SectionName));

            //RATE LIMIT
            services.Configure<RateLimitOptions>(
                configuration.GetSection(RateLimitOptions.SectionName));

            // AUTHENTICATION
            services.Configure<AuthenticationOptions>(
                configuration.GetSection(AuthenticationOptions.SectionName));

            //COOKIES
            services.Configure<CookieeOptions>(
                configuration.GetSection(CookieeOptions.SectionName));

            // SQL CONNECTION
            services.Configure<SqlServerOptions>(
                configuration.GetSection(SqlServerOptions.SectionName));

            return services;
        }

    }
}
