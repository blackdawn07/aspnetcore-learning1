var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.Use(async (context, next)=>
{
    Console.WriteLine("Middleware A - before");
});
app.MapGet("/", () => "Server is Running");

app.MapGet("/notes", ()=> 
{
   return new[] {"Note 1", "Note 2"};
});

app.Run();