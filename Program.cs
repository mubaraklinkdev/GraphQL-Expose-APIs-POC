using GraphQL.Services;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddGraphQLServer().AddQueryType<StudentService>();
builder.Services.AddGraphQLServer().AddQueryType<DepartmentService>();
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

//app cors
app.UseCors("corsapp");
app.UseHttpsRedirection();


app.UseRouting();

app.UseEndpoints(endpoints =>{
    endpoints.MapGraphQL();

});

app.MapGet("/", () => "Hello World!");

app.Run();
