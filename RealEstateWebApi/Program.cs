using RealEstateWebApi.Hubs;
using RealEstateWebApi.Models.DapperContext;
using RealEstateWebApi.Repositories.BottomGridRepository;
using RealEstateWebApi.Repositories.CategoryRepository;
using RealEstateWebApi.Repositories.ContactRepository;
using RealEstateWebApi.Repositories.EmployeeRepository;
using RealEstateWebApi.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories;
using RealEstateWebApi.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories;
using RealEstateWebApi.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticRepositories;
using RealEstateWebApi.Repositories.MessageRepository;
using RealEstateWebApi.Repositories.PopularLocationRepository;
using RealEstateWebApi.Repositories.ProductRepository;
using RealEstateWebApi.Repositories.ServiceRepository;
using RealEstateWebApi.Repositories.StatisticRepository;
using RealEstateWebApi.Repositories.TestimonialRepository;
using RealEstateWebApi.Repositories.ToDoListRepository;
using RealEstateWebApi.Repositories.WhoWeAreRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<Context>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IWhoWeAreRepository, WhoWeAreRepository>();
builder.Services.AddTransient<IServiceRepository, ServiceRepository>();
builder.Services.AddTransient<IBottomGridRepository, BottomGridRepository>();
builder.Services.AddTransient<IPopularLocationRepository, PopularLocationRepository>();
builder.Services.AddTransient<ITestimonialRepository, TestimonialRepository>();
builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddTransient<IStatisticRepository, StatisticRepository>(); 
builder.Services.AddTransient<IContactRepository, ContactRepository>(); 
builder.Services.AddTransient<IToDoListRepository, ToDoListRepository>(); 
builder.Services.AddTransient<IAgentStatisticRepository, AgentStatisticRepository>(); 
builder.Services.AddTransient<IChartRepository, ChartRepository>(); 
builder.Services.AddTransient<ILast5ProductsRepository, Last5ProductsRepository>(); 
builder.Services.AddTransient<IMessageRepository, MessageRepository>(); 

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", builder =>
    {
        builder.AllowAnyHeader()
            .AllowAnyMethod()
            .SetIsOriginAllowed((host) => true)
            .AllowCredentials();
    });
});
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
