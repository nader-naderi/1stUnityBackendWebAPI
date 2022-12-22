var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Dependency Injection.
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline. Adding middlewares.
if (app.Environment.IsDevelopment())
{

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
