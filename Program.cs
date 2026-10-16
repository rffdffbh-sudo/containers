var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var tasks = new List<TaskItem>
{
    new(1, "Написать Dockerfile", false),
    new(2, "Собрать образ", false),
    new(3, "Запустить контейнер", true)
};

app.MapGet("/health", () => Results.Ok(new { status = "ok" }));

app.MapGet("/tasks", (ILogger<Program> log) =>
{
    log.LogInformation("GET /tasks, возвращено {Count} задач", tasks.Count);
    return Results.Ok(tasks);
});

app.Run();

record TaskItem(int Id, string Title, bool IsDone);