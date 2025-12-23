namespace GameStore.api.Dtos;

public record class CreateGameDto(
    String Name,
    String Genre,
    decimal Price,
    DateOnly ReleaseDate
);