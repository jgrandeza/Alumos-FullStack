using jeancarlos.grandezaguilar.alumnos.services.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);

string connectionString = builder.Configuration.GetConnectionString("LibraryConnectionString");

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddInfrastructure(opt => opt.ConnectionString = connectionString);
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
var app = builder.Build();
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

