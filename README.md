# Lab28_GamesList

Веб-API для управления списком любимых игр на ASP.NET Core.

## Запуск

```bash
cd GamesApi
dotnet run
```

## Маршруты

| Метод | Маршрут | Описание | Статус |
|-------|---------|----------|--------|
| GET | /api/games | Получить все игры | 200 |
| GET | /api/games/{id} | Получить игру по id | 200 / 404 |
| GET | /api/games/favourites | Получить избранные игры | 200 |
| POST | /api/games | Добавить игру | 201 |
| DELETE | /api/games/{id} | Удалить игру | 204 / 404 |
| PUT | /api/games/{id} | Обновить игру | 200 / 404 |

## Примеры curl

```bash
curl http://localhost:5124/api/games

curl -X POST http://localhost:5124/api/games -H "Content-Type: application/json" -d "{\"title\": \"Stardew Valley\", \"genre\": \"Simulation\", \"releaseYear\": 2016}"

curl -X PUT http://localhost:5124/api/games/2 -H "Content-Type: application/json" -d "{\"title\": \"Witcher 2\", \"genre\": \"Action RPG\", \"releaseYear\": 2011}"

curl -X DELETE http://localhost:5124/api/games/1
```