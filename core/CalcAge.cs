namespace core
{
    public class CalcAge
    {
        private int _year;
        public CalcAge()
        {
            _year = 0;
        }
        public CalcAge(string yearInput)
        {
            _year = int.Parse(yearInput);
        }
        public CalcAge(int yearInput)
        {
            _year = yearInput;
        }

        public void UpdateYear(int newYear)
        {
            _year = newYear;
        }

        public int calculateAge()
        {
            return DateTime.Now.Year - _year;
        }

        public int returnCurrentAge(bool hadBirthday)
        {
            int age = calculateAge();
            return hadBirthday ? age : age - 1;
        }
    }
}
