var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpsRedirection();
app.MapGet("/calcage", (int birthYear, bool hadBirthday) =>
{
    return DateTime.Now.Year - birthYear - (hadBirthday ? 0 : 1);
});
app.Run();

