using GamesApi.Models;
namespace GamesApi.Data;

public static class GamesStore {
    private static int _nextId = 4;
    public static List<Game> Games { get; } = new() {
        new Game {
            Id = 1,
            Title = "GTA",
            Genre = "FPS",
            ReleaseYear = 2006,
        },
        new Game {
            Id = 2,
            Title = "Ready or Not",
            Genre = "Tactical-shooter",
            ReleaseYear = 2024,
        },
        new Game {
            Id = 3,
            Title = "Painkiller",
            Genre = "FPS",
            ReleaseYear = 2004,
        },
    };
    public static int NextId() => _nextId++;
}