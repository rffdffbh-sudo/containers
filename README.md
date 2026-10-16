# TaskService

Простое API сервиса задач в Docker-контейнере (.NET 10).

## Endpoints
- GET /health - проверка работоспособности
- GET /tasks - список задач

## Запуск без Docker
dotnet run --urls http://localhost:8080

## Docker
docker build -t task-service .
docker run -d --name task-service -p 8080:8080 task-service

## Проверка
docker ps
curl http://localhost:8080/tasks
docker logs task-service

## Результаты
- docs/docker-ps.txt
- docs/api-response.txt
- docs/docker-logs.txt
