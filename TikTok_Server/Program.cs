using business_logic;
using TikTok_Server;
using data_access;
using Hangfire;
using TikTok_Server.Helpers;
using business_logic.Profiles;

var builder = WebApplication.CreateBuilder(args);
var connStr = builder.Configuration.GetConnectionString("SomeeDb")!;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddJWT(builder.Configuration);
builder.Services.AddCustomServices();
builder.Services.AddDbContext(connStr);
builder.Services.AddIdentity();
builder.Services.AddRepositories();

//builder.Services.AddAutoMapper(typeof(ApplicationProfile));
builder.Services.AddAutoMapper();
builder.Services.AddFluentValidators();

builder.Services.AddCustomServices();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    scope.ServiceProvider.SeedRoles().Wait();
    scope.ServiceProvider.SeedAdmin().Wait();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseMiddleware<MiddlewareHandler>();


app.UseCors(options =>
{
    options.WithOrigins("http://localhost:4200", "https://localhost:7018", "https://localhost:5602"/*, "https://yellow-pond-03cd86610.5.azurestaticapps.net"*/)
        .AllowAnyMethod()
        .AllowAnyHeader();
});

app.UseAuthorization();

app.MapControllers();

app.Run();
