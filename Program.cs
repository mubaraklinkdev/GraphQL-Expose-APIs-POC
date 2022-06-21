using GraphQL.Services;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddGraphQLServer().AddQueryType<StudentService>();
builder.Services.AddGraphQLServer().AddQueryType<DepartmentService>();

var app = builder.Build();
app.UseRouting();

app.UseEndpoints(endpoints =>{
    endpoints.MapGraphQL();

});

app.MapGet("/", () => "Hello World!");

app.Run();
