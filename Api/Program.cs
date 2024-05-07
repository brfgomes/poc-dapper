using Application.Repositories;
using Infra.Factory;
using Infra.Repository;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<SqlFactory>();
builder.Services.AddTransient<IPersonRepository, PersonRepository>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
app.Run();