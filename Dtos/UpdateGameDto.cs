namespace GameStore.api.Dtos;

public record class UpdateGameDto(
    String Name,
    String Genre,
    decimal Price,
    DateOnly ReleaseDate
);