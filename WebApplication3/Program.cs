using WebApplication3;
using WebApplication3.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSingleton<CalcService>();
builder.Services.AddTransient<TimeService>();
builder.Services.AddControllers();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseRouting();

app.MapControllers();

app.Run();