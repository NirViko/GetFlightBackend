using getflightsbackend.Repository;
using getflightsbackend.RepositoryModels;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IFlightsRepository, FlightsRepository>();
builder.Services.AddScoped<IFlightsServices, FlightsServices>();

// Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalhost",
        builder => builder.WithOrigins("*") // Replace 3000 with your client's port number
                          .AllowAnyHeader()
                          .AllowAnyMethod());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowLocalhost"); // Apply CORS policy

app.UseAuthorization();

app.MapControllers();

app.Run();
