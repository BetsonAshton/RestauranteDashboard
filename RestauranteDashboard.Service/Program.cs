using RestauranteDashBoard.Infra.Data.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddTransient<PagamentoRepository>();
builder.Services.AddCors(
       s => s.AddPolicy("CorsSetup", builder =>
       {
           builder.AllowAnyOrigin() //qualquer projeto/origem pode acessar a API
                  .AllowAnyMethod() //qualquer método (POST, PUT, DELETE, GET)
                  .AllowAnyHeader(); //qualquer informação de cabeçalho
       })
   );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();
app.UseCors("CorsSetup");
app.Run();
