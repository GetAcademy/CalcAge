using core;

namespace CalcAgeConsole
{
    internal class CalcAgeApp
    {

        public void Run()
        {
            while (true)
            {
                PrintText("I hvilket år er du født? ");
                var year = Console.ReadLine();
                var calcAge = new CalcAge(year);
                PrintText("Har du hatt bursdag i år? (j/n) ");
                var hadBirthday = ReturnBoolInput(Console.ReadKey());
                PrintText($"\nDu er {calcAge.returnCurrentAge(hadBirthday)} år gammel.");
                PrintText("\n... continue ...\n");
                Console.ReadKey();
            }
        }

        private void PrintText(string txt)
        {
            Console.WriteLine(txt);
        }

        private bool ReturnBoolInput(ConsoleKeyInfo input)
        {
            return input.Key == ConsoleKey.J;
        }
    }
}
