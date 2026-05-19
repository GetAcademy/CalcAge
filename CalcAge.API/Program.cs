using core;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpsRedirection();
app.MapGet("/calcage", (CalcAge calcAge, bool hadBirthday) =>
{
    return calcAge.returnCurrentAge(hadBirthday);
});
app.MapPut("/saveinfo", (CalcAge calcAge, int birthYear) =>
{
    calcAge.UpdateYear(birthYear);
});
app.Run();

/*
 app.MapPut("/saveInfo", (int birthYear) =>
{
    CalcAge calcAge = new CalcAge(birthYear);
});
 */