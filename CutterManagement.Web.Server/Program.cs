// ============================================================================
//
// Application entry point for the Cutter Management Web Server application.
// This file sets up the web application, configures services, and defines the HTTP request pipeline.
//
// ============================================================================

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options => 
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
}, ServiceLifetime.Scoped);

builder.Services.AddScoped(typeof(IDataAccessService<>), typeof(DataAccessService<>));
builder.Services.AddScoped<IDataAccessServiceFactory, DataAccessServiceFactory>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.ConfigureApiEndpoint();

app.Run();
