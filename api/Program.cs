using api.Data;
using api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<PaletteData>();
builder.Services.AddScoped<PaletteService>();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options => {
    options.AddPolicy("_myAllowSpecificOrigins", policy => {
        policy.WithOrigins("https://gomyor.com")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

//app.UseHttpsRedirection();
app.UseCors("_myAllowSpecificOrigins");

app.MapControllers();
app.Run();
