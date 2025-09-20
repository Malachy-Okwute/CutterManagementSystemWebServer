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

// Get application database context
var db = app.Services.CreateScope().ServiceProvider.GetRequiredService<ApplicationDbContext>();

// Apply any pending migration to database or generate a new database if it hasn't been created yet
await db.Database.MigrateAsync();

// Add admin as a default user
// If admin doesn't exist...
if (await db.Users.AnyAsync(user => user.LastName == "admin") is false)
{
    // add admin user
    await db.Users.AddAsync(new UserDataModel
    {
        FirstName = "resource",
        LastName = "admin",
        DateCreated = DateTime.Now,
        Shift = UserShift.First
    });

    // Save changes
    await db.SaveChangesAsync();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.ConfigureApiEndpoint();

app.MapGet("CutterManagement.Web.Server", () => "Cutter Management Web Server is running...");

app.Run();