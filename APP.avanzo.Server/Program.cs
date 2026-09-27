using APP_avanzo.Server.data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


//Agregamos Cors para que el cliente pueda consumir los servicios del servidor
builder.Services.AddCors(options =>
{
    options.AddPolicy("BlazorClient", policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});



// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();



// ==========================================
// POSTGRESQL + ENTITY FRAMEWORK
// ==========================================

var connectionString =
    builder.Configuration.GetConnectionString("Cnn");

builder.Services.AddDbContext<AplicationDBContext>(options =>
    options.UseNpgsql(connectionString));


// ==========================================
// APLICACIÓN
// ==========================================



var app = builder.Build();


// Activamos los Cors
app.UseCors("BlazorClient");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}


app.UseHttpsRedirection();

//Creacion de los EndPoints

// para llamar http://localhost:5036/api/calculos

app.MapGet("/api/calculos", async (AplicationDBContext db) =>
    {
        var calculos = await db.Calculos
            .AsNoTracking()
            .ToListAsync();

        return Results.Ok(calculos);
    });



app.MapPost("/api/calculos",
    async (Calcular2 calcular, AplicationDBContext db) =>
    {
        db.Calculos.Add(calcular);

        await db.SaveChangesAsync();

        return Results.Created($"/api/calculos/{calcular.Id}", calcular);
    });

app.Run();

