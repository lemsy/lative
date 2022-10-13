using Lative.Discounts.Domain.Enums;
using Lative.Discounts.Infrastructure.Repositories;
using Lative.Discounts.Infrastructure.Services;

var DevPolicySpecificOrigins = "_devPolicySpecificOrigins";

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddCors(options =>
{
    options.AddPolicy(name: DevPolicySpecificOrigins,
                policy =>
                {
                    policy.WithOrigins("http://localhost:3000")
                            .WithMethods("GET");
                });
});


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = builder.Environment.ApplicationName, Version = "v1" });
});

builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IDiscountService, DiscountService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", $"{builder.Environment.ApplicationName} v1"));

    app.UseCors(DevPolicySpecificOrigins);
}

app.MapFallback(() => Results.Redirect("/swagger"));


app.MapGet("/get-discounts/{date:DateTime}/{employeeType}", (DateTime date, string employeeType, IEmployeeRepository employeeRepository, IDiscountService discountService) =>
{
    var eType = EmployeeTypeHelpers.GetEmployeeTypeByNameOrDefault(employeeType);
    if (eType == null) return Results.BadRequest($"Non recognizable employee type: {employeeType}.");

    var res = employeeRepository.GetEmployees()
                .Where(e => e.StartDate < date && e.Type == eType)
                .Select(e => new { 
                    identifier = e.Identifier,
                    firstName = e.FirstName,
                    lastName = e.LastName,
                    type = e.Type.GetReadableName(),
                    discount = discountService.TotalDiscount(e, date) 
                })
                .OrderByDescending(a => a.discount);
    return Results.Json(res);
});

app.Run();