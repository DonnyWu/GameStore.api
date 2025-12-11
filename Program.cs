using GameStore.api.Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

List<GameDto> games = [
    new(1, 
    "Pokemon: Heartgold",
    "Role-Playing",
    69.99M,
    new DateOnly(2010, 3, 14))
];

app.Run();
