using CopilotWebAPI.Abstractions;
using CopilotWebAPI.Controllers;
using CopilotWebAPI.Services;

	var builder = WebApplication.CreateBuilder(args);

	// Add services to the container.
	builder.Services.AddControllers();

    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
	builder.Services.AddSwaggerGen();

	//inject IWeatherService into the controller
	builder.Services.AddScoped<IWeatherService, WeatherForecastService>();

	//inject IUserService into the controller and the service class as singleton instance


var app = builder.Build();

	// Configure the HTTP request pipeline.
	if (app.Environment.IsDevelopment())
	{
		app.UseSwagger();
		app.UseSwaggerUI();
	}

	//app.UseHttpsRedirection();

	app.UseAuthorization();

	app.MapControllers();

	app.Run();
