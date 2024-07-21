using Emlak_Api.Hubs;
using Emlak_Api.Models.DapperContext;
using Emlak_Api.Repositories.BottomGridRepositories;
using Emlak_Api.Repositories.CategoryRepository;
using Emlak_Api.Repositories.ContactRepositories;
using Emlak_Api.Repositories.EmployeeRepositories;
using Emlak_Api.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories;
using Emlak_Api.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories;
using Emlak_Api.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticRepositories;
using Emlak_Api.Repositories.MessageRepositories;
using Emlak_Api.Repositories.PopularLocationRepositories;
using Emlak_Api.Repositories.ProductRepository;
using Emlak_Api.Repositories.ServiceRepository;
using Emlak_Api.Repositories.StatisticRepositories;
using Emlak_Api.Repositories.TestimonialRepositories;
using Emlak_Api.Repositories.ToDoListRepositories;
using Emlak_Api.Repositories.WhoWeAreRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddTransient<Context>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IWhoWeAreDetailRepository, WhoWeAreDetailRepository>();
builder.Services.AddTransient<IServiceRepository, ServiceRepository>();
builder.Services.AddTransient<IBottomGridRepository, BottomGridRepository>();
builder.Services.AddTransient<IPopularLocationRepository, PopularLocationRepository>();
builder.Services.AddTransient<ITestimonialRepository, TestimonialRepository>();
builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddTransient<IStatisticsRepository, StatisticsRepository>();
builder.Services.AddTransient<IContactRepository, ContactRepository>();
builder.Services.AddTransient<IToDoListRepository, ToDoListRepository>();
builder.Services.AddTransient<IStatisticRepository, StatisticRepository>();
builder.Services.AddTransient<IChartRepository, ChartRepository>();
builder.Services.AddTransient<ILast5ProductsRepository, Last5ProductsRepository>();
builder.Services.AddTransient<IMessageRepository, MessageRepository>();

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", builder =>
    {
        builder.AllowAnyHeader()
        .AllowAnyMethod()
        .SetIsOriginAllowed((Host) => true)
        .AllowCredentials();


    });
});
builder.Services.AddHttpClient();
builder.Services.AddSignalR();

builder.Services.AddControllers();
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

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapHub<SignalRHub>("/signalrhub");

app.Run();
