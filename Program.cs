using MC5to7.Services.MadLib;
using MC5to7.Services.OddorEven;
using MC5to7.Services.ReverseItAlpha;
using MC5to7.Services.ReverseItNum;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IOddorEvenService, OddorEvenService>();
builder.Services.AddScoped<IReverseItNum, ReverseItNum>();
builder.Services.AddScoped<IReverseItAlpha, ReverseItAlpha>();
builder.Services.AddScoped<IMadLibService, MadLibService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
