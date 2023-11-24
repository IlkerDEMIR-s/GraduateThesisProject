using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Contracts;
using Services;
using Services.Contracts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<RepositoryContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("sqlconnection"),
    b => b.MigrationsAssembly("GtApp"));
});

builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();  // IoC registration
builder.Services.AddScoped<IThesisRepository, ThesisRepository>();
builder.Services.AddScoped<ISubjectTopicRepository, SubjectTopicRepository>();

builder.Services.AddScoped<IServiceManager, ServiceManager>();  // IoC registration
builder.Services.AddScoped<IThesisService, ThesisManager>();
builder.Services.AddScoped<ISubjectTopicService, SubjectTopicManager>();
builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
builder.Services.AddScoped<IAuthorService, AuthorManager>();
builder.Services.AddScoped<IThesisAuthorshipRepository, ThesisAuthorshipRepository>();
builder.Services.AddScoped<IThesisAuthorshipService, ThesisAuthorshipManager>();
builder.Services.AddScoped<IUniversityRepository, UniversityRepository>();
builder.Services.AddScoped<IUniversityService, UniversityManager>();
builder.Services.AddScoped<IInstituteRepository, InstitudeRepository>();
builder.Services.AddScoped<IInstituteService, InstituteManager>();
builder.Services.AddScoped<IThesisSubjectTopicRepository, ThesisSubjectTopicRepository>();
builder.Services.AddScoped<IThesisSubjectTopicService, ThesisSubjectTopicManager>();
builder.Services.AddScoped<IKeywordRepository, KeywordRepository>();
builder.Services.AddScoped<IKeywordService, KeywordManager>();
builder.Services.AddScoped<ISupervisorRepository, SupervisorRepository>();
builder.Services.AddScoped<ISupervisorService, SupervisorManager>();
builder.Services.AddScoped<IThesisSupervisionRepository, ThesisSupervisionRepository>();
builder.Services.AddScoped<IThesisSupervisionService, ThesisSupervisionManager>();
builder.Services.AddScoped<IThesisTypeRepository, ThesisTypeRepository>();
builder.Services.AddScoped<IThesisTypeService, ThesisTypeManager>();


var app = builder.Build();

app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
        name: "Admin",
        areaName: "Admin",
        pattern: "Admin/{controller=Dashboard}/{action=Index}/{id?}"
    );

    endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

});

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();
