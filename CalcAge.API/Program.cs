var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpsRedirection();
//app.MapGet("/calcage", (core.CalcAge calcAge, bool hadBirthday) =>
//{
//    return calcAge.returnCurrentAge(hadBirthday);
//});
app.MapPut("/saveinfo", (core.CalcAge calcAge, int birthYear) =>
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
app.MapGet("/calcage", (int birthYear, bool hadBirthday) =>
{
    var calcAge = new core.CalcAge(birthYear);
    return calcAge.returnCurrentAge(hadBirthday);
});