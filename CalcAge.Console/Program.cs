Console.Write("I hvilket år er du født? ");
var year = int.Parse(Console.ReadLine());
Console.Write("Har du hatt bursdag i år? (j/n) ");
var answer = Console.ReadLine();
var age = DateTime.Now.Year - year;
var hadBirthday = answer == "j";
if (!hadBirthday)
{
    age--;
}
Console.WriteLine($"Du er {age} år gammel.");

