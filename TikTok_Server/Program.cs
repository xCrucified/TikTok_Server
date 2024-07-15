using Bussiness_Logic;
using TikTok_Server;

var builder = WebApplication.CreateBuilder(args);
var connStr = builder.Configuration.GetConnectionString("TikTokDb")!;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddJWT(builder.Configuration);
builder.Services.AddCustomServices();

var app = builder.Build();

//using (var scope = app.Services.CreateScope())
//{
//    scope.ServiceProvider.SeedRoles().Wait();
//    scope.ServiceProvider.SeedAdmin().Wait();
//}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseCors(options =>
{
    options.WithOrigins("http://localhost:4200", "https://localhost:7018"/*, "https://yellow-pond-03cd86610.5.azurestaticapps.net"*/)
        .AllowAnyMethod()
        .AllowAnyHeader();
});

app.UseAuthorization();

app.MapControllers();

app.Run();
