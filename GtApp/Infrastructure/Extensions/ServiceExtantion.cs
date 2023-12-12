using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Contracts;
using Services;
using Services.Contracts;

namespace GtApp.Infrastructure
{
    public static class ServiceExtantion
    {
        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RepositoryContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("sqlconnection"),
                b => b.MigrationsAssembly("GtApp"));

                options.EnableSensitiveDataLogging(true); // For testing not for production
            });

        }

        public static void ConfigureIdentity(this IServiceCollection services)
        {
            services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                options.User.AllowedUserNameCharacters =
                              "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 çığöşüÇİĞÖŞÜ-._@+";
                options.SignIn.RequireConfirmedAccount = false;
                options.User.RequireUniqueEmail = true;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireDigit = false;                
                options.Password.RequiredLength = 6;
                /*
                options.Password.RequiredUniqueChars = 3;
                options.Password.RequireNonAlphanumeric = false;
                */
            })
            .AddEntityFrameworkStores<RepositoryContext>();
        }   


        public static void ConfigureSession(this IServiceCollection services)
        {
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.Cookie.Name = "GtApp.Session";
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        public static void ConfigureRepositoryRegistration(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();  // IoC registration
            services.AddScoped<IThesisRepository, ThesisRepository>();
            services.AddScoped<ISubjectTopicRepository, SubjectTopicRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IThesisAuthorshipRepository, ThesisAuthorshipRepository>();
            services.AddScoped<IUniversityRepository, UniversityRepository>();
            services.AddScoped<IInstituteRepository, InstitudeRepository>();
            services.AddScoped<IThesisSubjectTopicRepository, ThesisSubjectTopicRepository>();
            services.AddScoped<IKeywordRepository, KeywordRepository>();
            services.AddScoped<ISupervisorRepository, SupervisorRepository>();
            services.AddScoped<IThesisSupervisionRepository, ThesisSupervisionRepository>();
            services.AddScoped<IThesisTypeRepository, ThesisTypeRepository>();
        }

        public static void ConfigureServiceRegistration(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, ServiceManager>();  // IoC registration
            services.AddScoped<IThesisService, ThesisManager>();
            services.AddScoped<ISubjectTopicService, SubjectTopicManager>();
            services.AddScoped<IAuthorService, AuthorManager>();
            services.AddScoped<IThesisAuthorshipService, ThesisAuthorshipManager>();
            services.AddScoped<IUniversityService, UniversityManager>();
            services.AddScoped<IInstituteService, InstituteManager>();
            services.AddScoped<IThesisSubjectTopicService, ThesisSubjectTopicManager>();
            services.AddScoped<IKeywordService, KeywordManager>();
            services.AddScoped<ISupervisorService, SupervisorManager>();
            services.AddScoped<IThesisSupervisionService, ThesisSupervisionManager>();
            services.AddScoped<IThesisTypeService, ThesisTypeManager>();
            services.AddScoped<IAuthService, AuthManager>();
        }

        public static void ConfigureApplicationCookie(this IServiceCollection services)
        {
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = new PathString("/Account/Login");
                options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                options.AccessDeniedPath = new PathString("/Account/AccessDenied");
            });
        }
     

        public static void ConfigureRouting(this IServiceCollection services)
        {
            services.AddRouting(options => 
            {                    
               options.LowercaseUrls = true;
                options.AppendTrailingSlash = true;
            });
        }

    }

}

